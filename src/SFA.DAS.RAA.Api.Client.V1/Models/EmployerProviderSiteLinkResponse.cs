// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace SFA.DAS.RAA.Api.Client.V1.Models
{
    using System.Linq;

    /// <summary>
    /// Specifies which provider site to link an employer to
    /// </summary>
    public partial class EmployerProviderSiteLinkResponse
    {
        /// <summary>
        /// Initializes a new instance of the EmployerProviderSiteLinkResponse
        /// class.
        /// </summary>
        public EmployerProviderSiteLinkResponse() { }

        /// <summary>
        /// Initializes a new instance of the EmployerProviderSiteLinkResponse
        /// class.
        /// </summary>
        /// <param name="employerId">The employer's primary identifier.</param>
        /// <param name="employerEdsUrn">The employer's secondary
        /// identifier.</param>
        /// <param name="providerSiteId">The provider site's primary
        /// identifier. You must supply this or the provider site's EDSURN.
        /// The Provider associated with your API key must also have a
        /// relationship with the employer.</param>
        /// <param name="providerSiteEdsUrn">The provider site's secondary
        /// identifier. You must supply this or the provider site's ID.
        /// The Provider associated with your API key must also have a
        /// relationship with the employer.</param>
        /// <param name="employerDescription">The description of the employer
        /// for this link (required)</param>
        /// <param name="employerWebsiteUrl">The employer's website for this
        /// link (optional)</param>
        public EmployerProviderSiteLinkResponse(int? employerId = default(int?), int? employerEdsUrn = default(int?), int? providerSiteId = default(int?), int? providerSiteEdsUrn = default(int?), string employerDescription = default(string), string employerWebsiteUrl = default(string))
        {
            EmployerId = employerId;
            EmployerEdsUrn = employerEdsUrn;
            ProviderSiteId = providerSiteId;
            ProviderSiteEdsUrn = providerSiteEdsUrn;
            EmployerDescription = employerDescription;
            EmployerWebsiteUrl = employerWebsiteUrl;
        }

        /// <summary>
        /// Gets or sets the employer's primary identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "EmployerId")]
        public int? EmployerId { get; set; }

        /// <summary>
        /// Gets or sets the employer's secondary identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "EmployerEdsUrn")]
        public int? EmployerEdsUrn { get; set; }

        /// <summary>
        /// Gets or sets the provider site's primary identifier. You must
        /// supply this or the provider site's EDSURN.
        /// The Provider associated with your API key must also have a
        /// relationship with the employer.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ProviderSiteId")]
        public int? ProviderSiteId { get; set; }

        /// <summary>
        /// Gets or sets the provider site's secondary identifier. You must
        /// supply this or the provider site's ID.
        /// The Provider associated with your API key must also have a
        /// relationship with the employer.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ProviderSiteEdsUrn")]
        public int? ProviderSiteEdsUrn { get; set; }

        /// <summary>
        /// Gets or sets the description of the employer for this link
        /// (required)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "EmployerDescription")]
        public string EmployerDescription { get; set; }

        /// <summary>
        /// Gets or sets the employer's website for this link (optional)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "EmployerWebsiteUrl")]
        public string EmployerWebsiteUrl { get; set; }

    }
}
