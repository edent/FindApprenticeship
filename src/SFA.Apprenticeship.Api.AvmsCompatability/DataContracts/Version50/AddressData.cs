﻿namespace SFA.Apprenticeship.Api.AvmsCompatability.DataContracts.Version50
{
    using System.Runtime.Serialization;
    using AvmsCompatability;

    [DataContract( Namespace = CommonNamespaces.ExternalInterfaces )]
    public class AddressData
    {
        [DataMember( IsRequired = true, Order = 1 )]
        public string AddressLine1;

        [DataMember( IsRequired = false, Order = 2 )]
        public string AddressLine2;

        [DataMember( IsRequired = false, Order = 3 )]
        public string AddressLine3;

        [DataMember( IsRequired = false, Order = 4 )]
        public string AddressLine4;

        [DataMember( IsRequired = false, Order = 5 )]
        public string AddressLine5;

        [DataMember( IsRequired = false, Order = 6 )]
        public string County;

        [DataMember( IsRequired = false, Order = 7 )]
        public int? GridEastM;

        [DataMember( IsRequired = false, Order = 8 )]
        public int? GridNorthM;

        [DataMember( IsRequired = false, Order = 9 )]
        public decimal? Latitude;

        [DataMember( IsRequired = false, Order = 10 )]
        public decimal? Longitude;

        [DataMember( IsRequired = true, Order = 13 )]
        public string PostCode;

        [DataMember( IsRequired = true, Order = 14 )]
        public string Town;
    }
}
