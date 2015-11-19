﻿namespace SFA.WebProxy
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using Configuration;
    using Models;

    public class BbcRouting : IProxyRouting
    {
        public Routing GetRouting(Uri requestUri, HttpMethod method, string ipAddress, string requestContent, RouteIdentifier routeIdentifier)
        {
            return new Routing
            {
                Routes = new List<Route> {new Route("http://news.bbc.co.uk", new RouteIdentifier("bbcnews"))},
            };
        }
    }

    public class LogicRouting : IProxyRouting
    {
        public Routing GetRouting(Uri requestUri, HttpMethod method, string ipAddress, string requestContent, RouteIdentifier routeIdentifier)
        {
            var routes = new List<Route>();

            if ((requestUri.PathAndQuery + "/").StartsWith("/news/"))
            {
                routes.Add(new Route("http://bbc.co.uk" + requestUri.PathAndQuery, new RouteIdentifier("bbc")));
            }
            else
            {
                routes.Add(new Route("https://webapp.services.coventry.ac.uk/" + requestUri.PathAndQuery.Substring(1), new RouteIdentifier("coventryuniversitywebappservices")));
            }

            var routing = new Routing
            {
                Routes = routes,
            };

            return routing;
        }
    }

    public class NasAvWebServicesRouting : IProxyRouting
    {
        private readonly Uri _nasAvWebServiceRootUri = new Uri("https://apprenticeshipvacancymatchingservice.lsc.gov.uk");
        private readonly Uri _compatabilityWebServiceRootUri;

        public NasAvWebServicesRouting(IConfiguration configuration)
        {
            _compatabilityWebServiceRootUri = new Uri(configuration.CompatabilityWebServiceRootUrl);
        }

        public Routing GetRouting(Uri requestUri, HttpMethod method, string ipAddress, string requestContent, RouteIdentifier routeIdentifier)
        {
            //TODO: Specify primary uri based on config
            return new Routing
            {
                Routes = new List<Route>
                {
                    new Route(new Uri(_nasAvWebServiceRootUri, requestUri.PathAndQuery), new RouteIdentifier(routeIdentifier, "nasavwebservice")),
                    new Route(GetCompatabilityWebServiceUrl(requestUri), new RouteIdentifier(routeIdentifier, "compatabilitywebservice"))
                },
            };
        }

        private Uri GetCompatabilityWebServiceUrl(Uri requestUri)
        {
            var pathAndQuery = requestUri.PathAndQuery;
            if (pathAndQuery.EndsWith(".svc"))
            {
                pathAndQuery = pathAndQuery.Substring(pathAndQuery.LastIndexOf("/", StringComparison.Ordinal));
            }
            return new Uri(_compatabilityWebServiceRootUri, pathAndQuery);
        }
    }
}