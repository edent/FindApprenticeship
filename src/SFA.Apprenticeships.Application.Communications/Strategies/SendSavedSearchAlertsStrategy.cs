﻿namespace SFA.Apprenticeships.Application.Communications.Strategies
{
    using System;
    using System.Linq;
    using Domain.Entities.Candidates;
    using Domain.Entities.Users;
    using Domain.Interfaces.Messaging;
    using Domain.Interfaces.Repositories;

    public class SendSavedSearchAlertsStrategy : ISendSavedSearchAlertsStrategy
    {
        private readonly ISavedSearchAlertRepository _savedSearchAlertRepository;
        private readonly ICandidateReadRepository _candidateReadRepository;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IServiceBus _serviceBus;

        public SendSavedSearchAlertsStrategy(
            ISavedSearchAlertRepository savedSearchAlertRepository,
            ICandidateReadRepository candidateReadRepository,
            IUserReadRepository userReadRepository,
            IServiceBus serviceBus)
        {
            _savedSearchAlertRepository = savedSearchAlertRepository;
            _candidateReadRepository = candidateReadRepository;
            _userReadRepository = userReadRepository;
            _serviceBus = serviceBus;
        }

        public void SendSavedSearchAlerts(Guid batchId)
        {
            var allCandidatesSavedSearchAlerts = _savedSearchAlertRepository.GetCandidatesSavedSearchAlerts();

            foreach (var candidateId in allCandidatesSavedSearchAlerts.Keys)
            {
                var candidate = _candidateReadRepository.Get(candidateId);
                var user = _userReadRepository.Get(candidateId);

                var candidateSavedSearchAlerts = allCandidatesSavedSearchAlerts[candidateId];

                if (candidate.AllowsCommunication() && user.IsActive())
                {
                    var communicationRequest = CommunicationRequestFactory.GetSavedSearchAlertCommunicationRequest(candidate, candidateSavedSearchAlerts);

                    _serviceBus.PublishMessage(communicationRequest);

                    // Update candidates saved search alerts to sent
                    candidateSavedSearchAlerts.ToList().ForEach(dd =>
                    {
                        dd.BatchId = batchId;
                        _savedSearchAlertRepository.Save(dd);
                    });
                }
                else
                {
                    // Soft delete candidates saved search status alerts by setting batch id to empty
                    candidateSavedSearchAlerts.ToList().ForEach(dd =>
                    {
                        dd.BatchId = Guid.Empty;
                        _savedSearchAlertRepository.Save(dd);
                    });
                }
            }
        }
    }
}