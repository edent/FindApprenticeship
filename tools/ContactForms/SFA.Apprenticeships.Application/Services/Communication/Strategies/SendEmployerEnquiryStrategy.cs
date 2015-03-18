﻿using System;
using System.Linq;
using SFA.Apprenticeships.Common.AppSettings;
using SFA.Apprenticeships.Common.Extensions;
using SFA.Apprenticeships.Domain.Exceptions;

namespace SFA.Apprenticeships.Application.Services.Communication.Strategies
{
    using System.Collections.Generic;
    using Application.Interfaces;
    using Application.Interfaces.Communications;
    using Interfaces;

    public class SendEmployerEnquiryStrategy : ISendEmployerEnquiryStrategy
    {
        private readonly IEmailDispatcher _emailDispatcher;
        private readonly ILogService _logger;

        public SendEmployerEnquiryStrategy(IEmailDispatcher emailDispatcher, ILogService logger)
        {
            _emailDispatcher = emailDispatcher;
            _logger = logger;
        }

        public void Send(MessageTypes messageType, IEnumerable<CommunicationToken> tokens)
        {
            if (!tokens.IsNullOrEmpty())
            {
                var request = new EmailRequest
                {
                    ToEmail = BaseAppSettingValues.ToEmailAddress,
                    Subject = String.Format("{0} at {1} on {2}",
                                                tokens.First(a => a.Key == CommunicationTokens.FullName).Value.ToFirstCharToUpper(),
                                                DateTime.Now.ToString("hh:mm tt"),
                                                DateTime.Now.ToString("dd-MMM-yyyy")),
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