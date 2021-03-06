namespace SFA.Apprenticeships.Application.Employer.Strategies
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Communications;
    using Newtonsoft.Json;

    public class SendEmployerLinksStrategy : ISendEmployerLinksStrategy
    {
        private readonly IEmployerCommunicationService _communicationService;

        public SendEmployerLinksStrategy(IEmployerCommunicationService communicationService)
        {
            _communicationService = communicationService;
        }

        public void Send(string vacancyTitle, string providerName, IDictionary<string, string> applicationLinks, DateTime linkExpiryDateTime, string recipientEmailAddress)
        {
            _communicationService.SendMessageToEmployer(recipientEmailAddress, MessageTypes.SendEmployerApplicationLinks,
                new[]
                {
                    new CommunicationToken(CommunicationTokens.RecipientEmailAddress, recipientEmailAddress),
                    new CommunicationToken(CommunicationTokens.ApplicationVacancyTitle, vacancyTitle),
                    new CommunicationToken(CommunicationTokens.ProviderName, providerName),
                    new CommunicationToken(CommunicationTokens.EmployerApplicationLinks, JsonConvert.SerializeObject(applicationLinks)),
                    new CommunicationToken(CommunicationTokens.EmployerApplicationLinksExpiry, linkExpiryDateTime.ToString("d MMMM yyyy"))
                });
        }
    }
}