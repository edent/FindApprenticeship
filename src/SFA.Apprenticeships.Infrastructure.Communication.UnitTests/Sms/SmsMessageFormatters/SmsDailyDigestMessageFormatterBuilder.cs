﻿namespace SFA.Apprenticeships.Infrastructure.Communication.UnitTests.Sms.SmsMessageFormatters
{
    using System.Collections.Generic;
    using Communication.Sms.SmsMessageFormatters;
    using Configuration;
    using Domain.Interfaces.Configuration;
    using Moq;

    public class SmsDailyDigestMessageFormatterBuilder
    {
        private List<SmsTemplate> _templates;

        public SmsDailyDigestMessageFormatterBuilder WithMessageTemplate(string messageTemplate)
        {
            _templates = new List<SmsTemplate>
            {
                new SmsTemplate
                {
                    Name = SmsDailyDigestMessageFormatter.TemplateName,
                    Message = messageTemplate
                }
            };

            return this;
        }

        public SmsDailyDigestMessageFormatter Build()
        {
            var configService = new Mock<IConfigurationService>();
            configService.Setup(x => x.Get<SmsConfiguration>())
                .Returns(new SmsConfiguration() {Templates = _templates});

            return new SmsDailyDigestMessageFormatter(configService.Object);
        }
    }
}