﻿namespace SFA.Apprenticeship.Api.AvmsCompatability.MessageContracts.Version51
{
    using System.Collections.Generic;
    using System.ServiceModel;
    using DataContracts.Version51;

    [MessageContract]
    public class GetLocalAuthoritiesInternalResponse : NavmsInternalResponseHeader
    {
        [MessageBodyMember(Namespace = CommonNamespaces.ExternalInterfacesRel51)]
        public List<LocalAuthorityData> LocalAuthorities { get; set; }
    }
}