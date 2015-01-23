﻿namespace SFA.Apprenticeships.Infrastructure.AsyncProcessor.Consumers
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Application.ApplicationUpdate.Entities;
    using Application.VacancyEtl.Entities;
    using Domain.Entities.Applications;
    using Domain.Interfaces.Caching;
    using Domain.Interfaces.Messaging;
    using Domain.Interfaces.Repositories;
    using EasyNetQ.AutoSubscribe;
    using Extensions;
    using NLog;

    public class VacancyStatusSummaryConsumerAsync : IConsumeAsync<VacancyStatusSummary>
    {
        private readonly ICacheService _cacheService;
        private readonly IApprenticeshipApplicationReadRepository _apprenticeshipApplicationReadRepository;
        private readonly ITraineeshipApplicationReadRepository _traineeshipApplicationReadRepository;
        private readonly IMessageBus _bus;
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public VacancyStatusSummaryConsumerAsync(ICacheService cacheService,
            IApprenticeshipApplicationReadRepository apprenticeshipApplicationReadRepository,
            ITraineeshipApplicationReadRepository traineeshipApplicationReadRepository,
            IMessageBus bus
            )
        {
            _cacheService = cacheService;
            _apprenticeshipApplicationReadRepository = apprenticeshipApplicationReadRepository;
            _traineeshipApplicationReadRepository = traineeshipApplicationReadRepository;
            _bus = bus;
        }

        [SubscriptionConfiguration(PrefetchCount = 20)]
        [AutoSubscriberConsumer(SubscriptionId = "VacancyStatusSummaryConsumerAsync")]
        public Task Consume(VacancyStatusSummary message)
        {
            return Task.Run(() =>
            {
                try
                {
                    var cachedSummaryUpdate = _cacheService.Get<VacancyStatusSummary>(message.CacheKey());

                    if (cachedSummaryUpdate != null)
                    {
                        return;
                    }

                    _cacheService.PutObject(message.CacheKey(), message, message.CacheDuration());

                    QueueApprenticeshipApplicationStatusSummaries(message);
                    QueueTraineeshipApplicationStatusSummaries(message);
                }
                catch (Exception ex)
                {
                    Logger.Error("Error processing application summaries", ex);
                }
            });
        }

        private void QueueApprenticeshipApplicationStatusSummaries(VacancyStatusSummary vacancyStatusSummary)
        {
            var applicationSummaries = _apprenticeshipApplicationReadRepository.GetApplicationSummaries(vacancyStatusSummary.LegacyVacancyId);
            var applicationStatusSummaries =
                applicationSummaries.Select(
                    x =>
                        new ApplicationStatusSummary
                        {
                            ApplicationId = x.ApplicationId,
                            LegacyApplicationId = x.LegacyVacancyId,
                            ApplicationStatus = x.Status,
                            VacancyStatus = vacancyStatusSummary.VacancyStatus,
                            LegacyVacancyId = x.LegacyVacancyId,
                            ClosingDate = vacancyStatusSummary.ClosingDate,
                            UnsuccessfulReason = x.UnsuccessfulReason
                        });

            //TODO: Think how to reduce applications that need processed based on their status.
            Parallel.ForEach(
                applicationStatusSummaries,
                new ParallelOptions { MaxDegreeOfParallelism = 5 },
                applicationStatusSummary => _bus.PublishMessage(applicationStatusSummary));            
        }

        private void QueueTraineeshipApplicationStatusSummaries(VacancyStatusSummary vacancyStatusSummary)
        {
            var applicationSummaries = _traineeshipApplicationReadRepository.GetApplicationSummaries(vacancyStatusSummary.LegacyVacancyId);
            var applicationStatusSummaries =
                applicationSummaries.Select(
                    x =>
                        new ApplicationStatusSummary
                        {
                            ApplicationId = x.ApplicationId,
                            LegacyApplicationId = x.LegacyVacancyId,
                            ApplicationStatus = ApplicationStatuses.Submitted,
                            VacancyStatus = vacancyStatusSummary.VacancyStatus,
                            LegacyVacancyId = x.LegacyVacancyId,
                            ClosingDate = vacancyStatusSummary.ClosingDate
                        });

            //TODO: Think how to reduce applications that need processed based on their status.
            Parallel.ForEach(
                applicationStatusSummaries,
                new ParallelOptions { MaxDegreeOfParallelism = 5 },
                applicationStatusSummary => _bus.PublishMessage(applicationStatusSummary));
        }
    }
}
