﻿namespace SFA.Apprenticeship.Api.AvmsCompatability.DataContracts.Version50
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract(Namespace = CommonNamespaces.ExternalInterfaces)]
    public class VacancySummaryResponseData
    {
        [DataMember(IsRequired = true, Order = 1)]
        public WebInterfaceGenericDetailsData AVMSHeader { get; set; }

        [DataMember(IsRequired = true, Order = 2)]
        public List<VacancySummaryData> SearchResults { get; set; }

        [DataMember(IsRequired = true, Order = 2)]
        public int TotalPages { get; set; }
    }
}