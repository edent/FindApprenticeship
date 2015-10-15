﻿namespace SFA.Apprenticeship.Api.AvmsCompatability.MessageContracts.Version51
{
    using System;
    using System.ServiceModel;

    /// <summary>
    /// Generic message header
    /// </summary>
    [MessageContract]
    public abstract class NavmsResponseHeader
    {
        [MessageBodyMember(Namespace = CommonNamespaces.ExternalInterfacesRel51)]
        public Guid MessageId { get; set; }
    }
}
