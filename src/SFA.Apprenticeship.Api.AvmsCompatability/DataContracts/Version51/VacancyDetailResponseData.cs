﻿namespace SFA.Apprenticeship.Api.AvmsCompatability.DataContracts.Version51
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract(Namespace = CommonNamespaces.ExternalInterfacesRel51)]
    public class VacancyDetailResponseData
    {
        [DataMember(IsRequired = true, Order = 1)]
        public WebInterfaceGenericDetailsData AVMSHeader { get; set; }

        [DataMember(IsRequired = true, Order = 2)]
        public List<VacancyFullData> SearchResults { get; set; }
        
        [DataMember(IsRequired = true, Order = 3)]
        public int TotalPages { get; set; }
    }
}