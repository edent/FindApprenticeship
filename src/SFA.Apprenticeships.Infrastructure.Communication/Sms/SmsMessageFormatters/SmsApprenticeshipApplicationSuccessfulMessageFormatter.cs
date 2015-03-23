﻿namespace SFA.Apprenticeships.Infrastructure.Communication.Sms.SmsMessageFormatters
{
    using System.Collections.Generic;
    using System.Linq;
    using Application.Interfaces.Communications;
    using Configuration;
    using Domain.Entities.Communication;
    using Domain.Interfaces.Configuration;
    using Newtonsoft.Json;

    public class SmsApprenticeshipApplicationSuccessfulMessageFormatter : SmsMessageFormatter
    {
        public SmsApprenticeshipApplicationSuccessfulMessageFormatter(IConfigurationService configurationService)
            : base(configurationService)
        {
            Message = GetTemplateConfiguration("MessageTypes.ApprenticeshipApplicationSuccessful").Message;
        }

        public override string GetMessage(IEnumerable<CommunicationToken> communicationTokens)
        {
            var json = communicationTokens.First(t => t.Key == CommunicationTokens.ApplicationStatusAlert).Value;
            var applicationStatusAlert = JsonConvert.DeserializeObject<ApplicationStatusAlert>(json);

            return string.Format(Message, applicationStatusAlert.EmployerName);
        }
    }
}
