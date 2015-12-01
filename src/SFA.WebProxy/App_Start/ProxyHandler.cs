﻿namespace SFA.WebProxy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading;
    using System.Threading.Tasks;
    using Configuration;
    using Factory;
    using Logging;
    using Models;
    using Routing;

    public class ProxyHandler : DelegatingHandler
    {
        private readonly IProxyRouting _proxyRouting;
        private readonly IProxyLogging _proxyLogging;
        private readonly IConfiguration _configuration;

        public ProxyHandler(IProxyRouting proxyRouting, IProxyLogging proxyLogging, IConfiguration configuration)
        {
            _proxyRouting = proxyRouting;
            _proxyLogging = proxyLogging;
            _configuration = configuration;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // Note: No guarantee headers will end up being sent in the same order as originally
            // Note: Http protocol version may not be retained
            var requestContent = request.Method == HttpMethod.Get ? null : await request.Content.ReadAsStringAsync();

            //Log request coming in against a new identifier
            var routeIdentifier = new RouteIdentifier();
            _proxyLogging.LogRequest(request, requestContent, routeIdentifier);

            var routing = _proxyRouting.GetRouting(request.RequestUri, request.Method, GetClientIPAddress(request), requestContent, routeIdentifier);

            var responses = new List<Task<HttpResponseMessage>>();

            if (request.Method == HttpMethod.Get)
            {
                foreach (var route in routing.Routes)
                {
                    if (route.IsPrimary)
                    {
                        responses.Insert(0, GetAsyncRequest(request, route));
                    }
                    else if (_configuration.AreNonPrimaryRequestsEnabled)
                    {
                        responses.Add(GetAsyncRequest(request, route));
                    }
                }
            }
            else if (request.Method == HttpMethod.Post)
            {
                // Copy request content headers (.NET treats these separately from non-content headers)
                var requestHttpContent = new StringContent(requestContent);
                requestHttpContent.Headers.Clear();
                foreach (var header in request.Content.Headers)
                {
                    requestHttpContent.Headers.Add(header.Key, header.Value);
                }

                foreach (var route in routing.Routes)
                {
                    if (route.IsPrimary)
                    {
                        responses.Insert(0, PostAsyncRequest(request, requestHttpContent, route));
                    }
                    else if (_configuration.AreNonPrimaryRequestsEnabled)
                    {
                        responses.Add(PostAsyncRequest(request, requestHttpContent, route));
                    }
                }
            }
            else
            {
                throw new NotSupportedException();
            }

            //Primary task is always inserted as first object
            return await responses.First();
        }

        private Task<HttpResponseMessage> GetAsyncRequest(HttpRequestMessage request, Route route)
        {
            var client = RoutingHttpClientFactory.Create(request, route.Uri);
            return client.GetAsync(route.Uri).ContinueWith(ContinuationFunction(client, null, route));
        }

        private Task<HttpResponseMessage> PostAsyncRequest(HttpRequestMessage request, HttpContent requestHttpContent, Route route)
        {
            var client = RoutingHttpClientFactory.Create(request, route.Uri);
            var contentHeaders = request.Content?.Headers;
            return client.PostAsync(route.Uri, requestHttpContent).ContinueWith(ContinuationFunction(client, contentHeaders, route));
        }

        private Func<Task<HttpResponseMessage>, HttpResponseMessage> ContinuationFunction(HttpClient client, HttpContentHeaders contentHeaders, Route route)
        {
            return task =>
            {
                client.Dispose();

                if (task.IsCanceled)
                {
                    _proxyLogging.LogResponseCancelled(route, client.DefaultRequestHeaders, contentHeaders, task.Exception);
                    if (route.IsPrimary)
                    {
                        //Will display underlying exception
                        return task.Result;
                    }
                    return null;
                }

                if (task.IsFaulted)
                {
                    _proxyLogging.LogResponseFaulted(route, client.DefaultRequestHeaders, contentHeaders, task.Exception);
                    if (route.IsPrimary)
                    {
                        //Will display underlying exception
                        return task.Result;
                    }
                    return null;
                }

                if (task.IsCompleted)
                {
                    task.Result.Headers.Add("X-Response-From", route.Uri.ToString());
                    _proxyLogging.LogResponseContent(task.Result, route.Identifier);
                }

                return task.Result;
            };
        }

        // Credit: http://stackoverflow.com/questions/9565889/get-the-ip-address-of-the-remote-host
        private const string HttpContext = "MS_HttpContext";
        private const string RemoteEndpointMessage =
            "System.ServiceModel.Channels.RemoteEndpointMessageProperty";
        private const string OwinContext = "MS_OwinContext";

        public static string GetClientIPAddress(HttpRequestMessage request)
        {
            // Web-hosting. Needs reference to System.Web.dll
            if (request.Properties.ContainsKey(HttpContext))
            {
                dynamic ctx = request.Properties[HttpContext];
                if (ctx != null)
                {
                    return ctx.Request.UserHostAddress;
                }
            }

            // Self-hosting. Needs reference to System.ServiceModel.dll. 
            if (request.Properties.ContainsKey(RemoteEndpointMessage))
            {
                dynamic remoteEndpoint = request.Properties[RemoteEndpointMessage];
                if (remoteEndpoint != null)
                {
                    return remoteEndpoint.Address;
                }
            }

            // Self-hosting using Owin. Needs reference to Microsoft.Owin.dll. 
            if (request.Properties.ContainsKey(OwinContext))
            {
                dynamic owinContext = request.Properties[OwinContext];
                if (owinContext != null)
                {
                    return owinContext.Request.RemoteIpAddress;
                }
            }

            return null;
        }
    }
}