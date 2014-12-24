﻿namespace SFA.Apprenticeships.Infrastructure.AsyncProcessor.Consumers
{
    using System;
    using System.Threading.Tasks;
    using Application.Candidate;
    using Application.Interfaces.Messaging;
    using Domain.Entities.Exceptions;
    using Domain.Interfaces.Messaging;
    using Domain.Interfaces.Repositories;
    using EasyNetQ.AutoSubscribe;
    using NLog;

    public class SubmitTraineeshipApplicationRequestConsumerAsync : IConsumeAsync<SubmitTraineeshipApplicationRequest>
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private readonly ILegacyApplicationProvider _legacyApplicationProvider;
        private readonly ITraineeshipApplicationReadRepository _applicationReadApplicationReadRepository;
        private readonly ICandidateReadRepository _candidateReadRepository;
        private readonly IMessageBus _messageBus;

        public SubmitTraineeshipApplicationRequestConsumerAsync(
            ILegacyApplicationProvider legacyApplicationProvider,
            ITraineeshipApplicationReadRepository applicationReadApplicationReadRepository,
            ICandidateReadRepository candidateReadRepository,
            IMessageBus messageBus)
        {
            _legacyApplicationProvider = legacyApplicationProvider;
            _applicationReadApplicationReadRepository = applicationReadApplicationReadRepository;
            _candidateReadRepository = candidateReadRepository;
            _messageBus = messageBus;
        }

        [AutoSubscriberConsumer(SubscriptionId = "SubmitTraineeshipApplicationRequestConsumerAsync")]
        public Task Consume(SubmitTraineeshipApplicationRequest request)
        {
            return Task.Run(() =>
            {
                if (request.ProcessTime.HasValue && request.ProcessTime > DateTime.Now)
                {
                    try
                    {
                        _messageBus.PublishMessage(request);
                        return;
                    }
                    catch
                    {
                        Logger.Error("Failed to re-queue deferred 'Submit Traineeship Application' request: {{ 'ApplicationId': '{0}' }}", request.ApplicationId);
                        throw;
                    }
                }
                
                Log("Submitting", request);

                CreateApplication(request);
            });
        }

        public void CreateApplication(SubmitTraineeshipApplicationRequest request)
        {
            var applicationDetail = _applicationReadApplicationReadRepository.Get(request.ApplicationId, true);

            try
            {
                var candidate = _candidateReadRepository.Get(applicationDetail.CandidateId, true);

                if (candidate.LegacyCandidateId == 0)
                {
                    Logger.Info(
                        "Candidate with Id: {0} has not been created in the legacy system. Message will be requeued",
                        applicationDetail.CandidateId);
                    Requeue(request);
                }
                else
                {
                    applicationDetail.LegacyApplicationId = _legacyApplicationProvider.CreateApplication(applicationDetail);
                }
            }
            catch (CustomException ex)
            {
                HandleCustomException(request, ex);
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("Submit traineeship application with Id = {0} request async process failed.", request.ApplicationId), ex);
                Requeue(request);
            }
        }

        private void HandleCustomException(SubmitTraineeshipApplicationRequest request, CustomException ex)
        {
            switch (ex.Code)
            {
                case ErrorCodes.ApplicationDuplicatedError:
                    Logger.Warn("Traineeship application has already been submitted to legacy system: Application Id: \"{0}\"", request.ApplicationId);
                    break;

                case ErrorCodes.LegacyCandidateStateError:
                    Logger.Error("Legacy candidate is in an invalid state. Traineeship application cannot be processed: Application Id: \"{0}\"", request.ApplicationId);
                    break;

                case ErrorCodes.LegacyCandidateNotFoundError:
                    Logger.Error("Legacy candidate was not found. Traineeship application cannot be processed: Application Id: \"{0}\"", request.ApplicationId);
                    break;

                case ErrorCodes.LegacyVacancyStateError:
                    Logger.Warn("Legacy Vacancy was in an invalid state. Traineeship application cannot be processed: Application Id: \"{0}\"", request.ApplicationId);
                    break;

                case ErrorCodes.ApplicationInIncorrectStateError:
                    Logger.Error(string.Format("Traineeship application is in an invalid state: Application Id: \"{0}\"", request.ApplicationId), ex);
                    break;

                default:
                    Logger.Warn(string.Format("Submit traineeship application with Id = {0} request async process failed.", request.ApplicationId), ex);
                    Requeue(request);
                    break;
            }
        }

        private void Requeue(SubmitTraineeshipApplicationRequest request)
        {
            request.ProcessTime = request.ProcessTime.HasValue ? DateTime.Now.AddMinutes(5) : DateTime.Now.AddSeconds(30);
            _messageBus.PublishMessage(request);
        }

        private static void Log(string narrative, SubmitTraineeshipApplicationRequest request)
        {
            Logger.Debug("{0}: Traineeship application Id: \"{1}\"", narrative, request.ApplicationId);
        }
    }
}
