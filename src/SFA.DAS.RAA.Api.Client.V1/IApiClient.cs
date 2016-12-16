// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace SFA.DAS.RAA.Api.Client.V1
{
    using Models;

    /// <summary>
    /// </summary>
    public partial interface IApiClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        Microsoft.Rest.ServiceClientCredentials Credentials { get; }


            /// <param name='vacancyId'>
        /// </param>
        /// <param name='vacancyReferenceNumber'>
        /// </param>
        /// <param name='vacancyGuid'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse<object>> GetVacancyWithHttpMessagesAsync(int? vacancyId = default(int?), int? vacancyReferenceNumber = default(int?), System.Guid? vacancyGuid = default(System.Guid?), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <param name='wageUpdate'>
        /// </param>
        /// <param name='vacancyId'>
        /// </param>
        /// <param name='vacancyReferenceNumber'>
        /// </param>
        /// <param name='vacancyGuid'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse<object>> EditVacancyWageWithHttpMessagesAsync(WageUpdate wageUpdate, int? vacancyId = default(int?), int? vacancyReferenceNumber = default(int?), System.Guid? vacancyGuid = default(System.Guid?), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}
