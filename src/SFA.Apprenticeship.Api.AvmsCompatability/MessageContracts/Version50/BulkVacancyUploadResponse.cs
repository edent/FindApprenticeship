﻿namespace SFA.Apprenticeship.Api.AvmsCompatability.MessageContracts.Version50
{
    using System.Collections.Generic;
    using System.ServiceModel;
    using DataContracts.Version50;

    [MessageContract]
    public class BulkVacancyUploadResponse: NavmsResponseHeader
    {
        [MessageBodyMember( Namespace = CommonNamespaces.ExternalInterfaces )]
        public List<VacancyUploadResultData> Vacancies { get; set; }
    }
}
