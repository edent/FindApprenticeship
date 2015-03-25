﻿namespace SFA.Apprenticeships.Application.Services.Communication.Strategies
{
    using System.Linq;
    using Common.AppSettings;
    using Common.Extensions;
    using Domain.Exceptions;
    using System.Collections.Generic;
    using Application.Interfaces;
    using Application.Interfaces.Communications;
    using Interfaces;

    public class SendEmployerEnquiryStrategy : ISendEmployerEnquiryStrategy
    {
        private readonly IEmailDispatcher _emailDispatcher;
        private readonly IXmlGenerator _xmlGenerator;

        private readonly ILogService _logger;

        public SendEmployerEnquiryStrategy(IEmailDispatcher emailDispatcher, ILogService logger, IXmlGenerator xmlGenerator)
        {
            _emailDispatcher = emailDispatcher;
            _logger = logger;
            _xmlGenerator = xmlGenerator;
        }

        public void SendMessageToHelpdesk(MessageTypes messageType, IEnumerable<CommunicationToken> tokens)
        {
            if (!tokens.IsNullOrEmpty())
            {
                //get xml stream to attach in the email
                var xmlAttachmentName = _xmlGenerator.SerializeToXmlFile(messageType, tokens);

                var request = new EmailRequest
                {
                    ToEmail = BaseAppSettingValues.ToEmailAddress,
                    MessageType = messageType,
                    Tokens = tokens,
                    StreamedAttachmentName = xmlAttachmentName//generate XML and attach to the email
                };

                _emailDispatcher.SendEmail(request);
            }
            else
            {
                throw new CustomException(string.Format("No tokens found for messageType:{0}", messageType));
            }
        }

        public void SendMessageToApplicant(MessageTypes messageType, IEnumerable<CommunicationToken> tokens)
        {
            if (!tokens.IsNullOrEmpty())
            {
                var request = new EmailRequest
                {
                    ToEmail = tokens.First(a => a.Key == CommunicationTokens.Email).Value,
                    MessageType = messageType,
                    Tokens = tokens
                };

                _emailDispatcher.SendEmail(request);
            }
            else
            {
                throw new CustomException(string.Format("No tokens found for messageType:{0}", messageType));
            }
        }
    }
}