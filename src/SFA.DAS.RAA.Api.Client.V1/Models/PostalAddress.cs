// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace SFA.DAS.RAA.Api.Client.V1.Models
{
    using System.Linq;

    /// <summary>
    /// The rationale behind the creation of this class is that we will
    /// eventually move from the existing Address entity,
    /// to this entity, throughout the entirety of the solution (RAA &amp;amp;
    /// FAA).
    /// TODO: Remove the existing Address entity, in favour of using this one.
    /// This should be carried out after the DB migration
    /// and private Beta release
    /// </summary>
    public partial class PostalAddress
    {
        /// <summary>
        /// Initializes a new instance of the PostalAddress class.
        /// </summary>
        public PostalAddress() { }

        /// <summary>
        /// Initializes a new instance of the PostalAddress class.
        /// </summary>
        /// <param name="validationSourceCode">AKA ValidationSourceKeyName.
        /// As at 13/01/2015, the SFA Data Standard for Postal Addresses list
        /// valid validating bodies as:
        /// 1. Royal Mail PAF file
        /// 2. GeoPlace data
        /// 3. PCA product (uses a PAF file source)</param>
        /// <param name="validationSourceKeyValue">For PAF, this is the Unique
        /// Delivery Point Reference Number (UDPRN)
        /// For GeoPlace, this is the Unique Property ReferenceNumber (UPRN)
        /// PostCode anywhere uses PAF data, so this is the UDPRN.</param>
        public PostalAddress(int? postalAddressId = default(int?), string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string addressLine4 = default(string), string addressLine5 = default(string), string town = default(string), string postcode = default(string), string validationSourceCode = default(string), string validationSourceKeyValue = default(string), System.DateTime? dateValidated = default(System.DateTime?), int? countyId = default(int?), string county = default(string), int? localAuthorityId = default(int?), string localAuthorityCodeName = default(string), string localAuthority = default(string), GeoPoint geoPoint = default(GeoPoint))
        {
            PostalAddressId = postalAddressId;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            AddressLine3 = addressLine3;
            AddressLine4 = addressLine4;
            AddressLine5 = addressLine5;
            Town = town;
            Postcode = postcode;
            ValidationSourceCode = validationSourceCode;
            ValidationSourceKeyValue = validationSourceKeyValue;
            DateValidated = dateValidated;
            CountyId = countyId;
            County = county;
            LocalAuthorityId = localAuthorityId;
            LocalAuthorityCodeName = localAuthorityCodeName;
            LocalAuthority = localAuthority;
            GeoPoint = geoPoint;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "PostalAddressId")]
        public int? PostalAddressId { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "AddressLine1")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "AddressLine2")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "AddressLine3")]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "AddressLine4")]
        public string AddressLine4 { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "AddressLine5")]
        public string AddressLine5 { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Town")]
        public string Town { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// Gets or sets AKA ValidationSourceKeyName.
        /// As at 13/01/2015, the SFA Data Standard for Postal Addresses list
        /// valid validating bodies as:
        /// 1. Royal Mail PAF file
        /// 2. GeoPlace data
        /// 3. PCA product (uses a PAF file source)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ValidationSourceCode")]
        public string ValidationSourceCode { get; set; }

        /// <summary>
        /// Gets or sets for PAF, this is the Unique Delivery Point Reference
        /// Number (UDPRN)
        /// For GeoPlace, this is the Unique Property ReferenceNumber (UPRN)
        /// PostCode anywhere uses PAF data, so this is the UDPRN.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ValidationSourceKeyValue")]
        public string ValidationSourceKeyValue { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "DateValidated")]
        public System.DateTime? DateValidated { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "CountyId")]
        public int? CountyId { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "County")]
        public string County { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "LocalAuthorityId")]
        public int? LocalAuthorityId { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "LocalAuthorityCodeName")]
        public string LocalAuthorityCodeName { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "LocalAuthority")]
        public string LocalAuthority { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "GeoPoint")]
        public GeoPoint GeoPoint { get; set; }

    }
}