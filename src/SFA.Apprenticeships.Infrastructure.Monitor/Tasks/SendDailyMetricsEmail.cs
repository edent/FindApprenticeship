﻿namespace SFA.Apprenticeships.Infrastructure.Monitor.Tasks
{
    using System;
    using System.Diagnostics;
    using System.Net.Mail;
    using System.Text;
    using Application.Interfaces.Logging;
    using Domain.Entities.Applications;
    using Domain.Interfaces.Configuration;
    using Repositories;

    public class SendDailyMetricsEmail : IDailyMetricsTask
    {
        private const string DailyMetricsEmailFromSettingName = "Monitor.DailyMetrics.Email.From";
        private const string DailyMetricsEmailToSettingName = "Monitor.DailyMetrics.Email.To";

        private readonly IConfigurationManager _configurationManager;
        private readonly ILogService _logger;

        private readonly IUserMetricsRepository _userMetricsRepository;
        private readonly IApprenticeshipMetricsRepository _apprenticeshipMetricsRepository;
        private readonly ITraineeshipMetricsRepository _traineeshipMetricsRepository;
        private readonly IExpiringDraftsMetricsRepository _expiringDraftsMetricsRepository;
        private readonly IApplicationStatusAlertsMetricsRepository _applicationStatusAlertsMetricsRepository;

        private readonly int _validNumberOfDaysSinceUserActivity;

        public SendDailyMetricsEmail(
            IConfigurationManager configurationManager,
            ILogService logger,
            IApprenticeshipMetricsRepository apprenticeshipMetricsRepository,
            ITraineeshipMetricsRepository traineeshipMetricsRepository,
            IUserMetricsRepository userMetricsRepository,
            IExpiringDraftsMetricsRepository expiringDraftsMetricsRepository,
            IApplicationStatusAlertsMetricsRepository applicationStatusAlertsMetricsRepository)
        {
            _logger = logger;
            _configurationManager = configurationManager;
            _apprenticeshipMetricsRepository = apprenticeshipMetricsRepository;
            _traineeshipMetricsRepository = traineeshipMetricsRepository;
            _userMetricsRepository = userMetricsRepository;
            _expiringDraftsMetricsRepository = expiringDraftsMetricsRepository;
            _applicationStatusAlertsMetricsRepository = applicationStatusAlertsMetricsRepository;

            _validNumberOfDaysSinceUserActivity = _configurationManager.GetCloudAppSetting<int>("ValidNumberOfDaysSinceUserActivity");
        }

        public string TaskName
        {
            get { return "Send daily metrics email"; }
        }

        public void Run()
        {
            try
            {
                _logger.Debug("About to send daily metrics email");

                var body = ComposeBody();

                SendEmail(From, To, body, GetSubject());

                _logger.Debug("Sent daily metrics email");
            }
            catch (Exception e)
            {
                _logger.Error("Failed to send daily metrics email", e);
            }
        }

        #region Helpers

        private string ComposeBody()
        {
            var sb = new StringBuilder();

            sb.Append("General:\n");
            sb.AppendFormat(" - Total number of candidates registered: {0} ({1}ms)\n", TimedMongoCall(_userMetricsRepository.GetRegisteredUserCount));
            sb.AppendFormat(" - Total number of candidates registered and activated: {0} ({1}ms)\n", TimedMongoCall(_userMetricsRepository.GetRegisteredAndActivatedUserCount));

            var oneWeekAgo = DateTime.UtcNow.AddDays(-7);
            var fourWeeksAgo = DateTime.UtcNow.AddDays(-28);
            var customDaysAgo = DateTime.UtcNow.AddDays(-_validNumberOfDaysSinceUserActivity);
            sb.AppendFormat(" - Total number of candidates active in the last week: {0} ({1}ms)\n", TimedMongoCall(_apprenticeshipMetricsRepository.GetActiveUserCount, oneWeekAgo));
            sb.AppendFormat(" - Total number of candidates active in the last four weeks: {0} ({1}ms)\n", TimedMongoCall(_apprenticeshipMetricsRepository.GetActiveUserCount, fourWeeksAgo));

            var p1 = new object[3];
            var result = TimedMongoCall(_apprenticeshipMetricsRepository.GetActiveUserCount, customDaysAgo);
            p1[0] = result[0];
            p1[1] = result[1];
            p1[2] = _validNumberOfDaysSinceUserActivity;
            sb.AppendFormat(" - Total number of candidates active in the last {2} days: {0} ({1}ms)\n", p1);

            // Apprenticeship applications.
            sb.Append("Apprenticeships:\n");
            sb.AppendFormat(" - Total number of applications: {0} ({1}ms)\n", TimedMongoCall(_apprenticeshipMetricsRepository.GetApplicationCount));
            sb.AppendFormat("   - Saved: {0} ({1}ms)\n", TimedMongoCall(_apprenticeshipMetricsRepository.GetApplicationStateCount, ApplicationStatuses.Saved));
            sb.AppendFormat("   - Draft: {0} ({1}ms)\n", TimedMongoCall(_apprenticeshipMetricsRepository.GetApplicationStateCount, ApplicationStatuses.Draft));
            sb.AppendFormat("   - Submitted: {0} ({1}ms)\n", TimedMongoCall(_apprenticeshipMetricsRepository.GetApplicationStateCount, ApplicationStatuses.Submitted));
            sb.AppendFormat("   - Expired or Withdrawn: {0} ({1}ms)\n", TimedMongoCall(_apprenticeshipMetricsRepository.GetApplicationStateCount, ApplicationStatuses.ExpiredOrWithdrawn));
            sb.AppendFormat("   - Unsuccessful: {0} ({1}ms)\n", TimedMongoCall(_apprenticeshipMetricsRepository.GetApplicationStateCount, ApplicationStatuses.Unsuccessful));
            sb.AppendFormat("   - Successful: {0} ({1}ms)\n", TimedMongoCall(_apprenticeshipMetricsRepository.GetApplicationStateCount, ApplicationStatuses.Successful));

            // Apprenticeship applications per candidate.
            sb.AppendFormat(" - Total number of candidates with at least one application in any state: {0} ({1}ms)\n", TimedMongoCall(_apprenticeshipMetricsRepository.GetApplicationCountPerCandidate));
            sb.AppendFormat(" - Total number of candidates with at least one application in draft: {0} ({1}ms)\n", TimedMongoCall(_apprenticeshipMetricsRepository.GetApplicationStateCountPerCandidate, ApplicationStatuses.Draft));

            var s1 = TimedMongoCall(_apprenticeshipMetricsRepository.GetApplicationStateCountPerCandidate, ApplicationStatuses.Submitting);
            var s2 = TimedMongoCall(_apprenticeshipMetricsRepository.GetApplicationStateCountPerCandidate, ApplicationStatuses.Submitted);
            sb.AppendFormat(" - Total number of candidates with at least one submitted application: {0} ({1}ms + {2}ms)\n", (int)s1[0] + (int)s2[0], s1[1], s2[1]);

            sb.AppendFormat(" - Total number of candidates with at least one successful application: {0} ({1}ms)\n", TimedMongoCall(_apprenticeshipMetricsRepository.GetApplicationStateCountPerCandidate, ApplicationStatuses.Successful));
            sb.AppendFormat(" - Total number of candidates with at least one unsuccessful application: {0} ({1}ms)\n", TimedMongoCall(_apprenticeshipMetricsRepository.GetApplicationStateCountPerCandidate, ApplicationStatuses.Unsuccessful));

            // Traineeships.
            sb.Append("Traineeships:\n");
            sb.AppendFormat(" - Total number of applications submitted: {0} ({1}ms)\n", TimedMongoCall(_traineeshipMetricsRepository.GetApplicationCount));
            sb.AppendFormat(" - Total number of candidates with applications: {0} ({1}ms)\n", TimedMongoCall(_traineeshipMetricsRepository.GetApplicationsPerCandidateCount));

            // Communications.
            sb.Append("Communications:\n");
            sb.AppendFormat(" - Expiring draft applications emails sent today: {0} ({1}ms)\n", TimedMongoCall(_expiringDraftsMetricsRepository.GetDraftApplicationEmailsSentToday));
            sb.AppendFormat(" - Application status alert emails sent today: {0} ({1}ms)\n", TimedMongoCall(_applicationStatusAlertsMetricsRepository.GetApplicationStatusAlertEmailsSentToday));

            return sb.ToString();
        }

        private static object[] TimedMongoCall<T>(Func<T> mongoCall)
        {
            var sw = new Stopwatch();
            sw.Start();
            var result = mongoCall.Invoke();
            sw.Stop();
            return new object[] { result, sw.ElapsedMilliseconds };
        }

        private static object[] TimedMongoCall<TParam, TResult>(Func<TParam, TResult> mongoCall, TParam param)
        {
            var sw = new Stopwatch();
            sw.Start();
            var result = mongoCall.Invoke(param);
            sw.Stop();
            return new object[] { result, sw.ElapsedMilliseconds };
        } 

        private static string GetSubject()
        {
            return string.Format("Find apprenticeship - Daily Metrics for {0}", DateTime.Today.ToString("ddd dd MMM yyyy"));
        }

        private void SendEmail(string from, string to, string body, string subject)
        {
            var client = new SmtpClient();
            var mailMessage = new MailMessage(from, to, subject, body);

            client.Send(mailMessage);
        }

        private string To { get { return _configurationManager.GetAppSetting<string>(DailyMetricsEmailToSettingName); } }
        
        private string From { get { return _configurationManager.GetAppSetting<string>(DailyMetricsEmailFromSettingName); } }

        #endregion
    }
}
