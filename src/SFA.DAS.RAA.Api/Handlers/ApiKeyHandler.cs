﻿namespace SFA.DAS.RAA.Api.Handlers
{
    using System.Linq;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Services;

    public class ApiKeyHandler : DelegatingHandler
    {
        private readonly IAuthenticationService _authenticationService;

        public ApiKeyHandler(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            //Set the current principal based on authentication response
            var principal = _authenticationService.Authenticate(request.Headers.ToDictionary(h => h.Key, h => string.Join(",", h.Value)));
            request.GetRequestContext().Principal = principal;

            //Allow the request to process further down the pipeline
            var response = await base.SendAsync(request, cancellationToken);

            //Return the response back up the chain
            return response;
        }
    }
}