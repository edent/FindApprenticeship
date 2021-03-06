﻿namespace SetApplicationStatus.Console
{
    using System.Linq;
    using NLog;

    public class InProgressApplicationPatch
    {
        private readonly string _ukprn;
        private readonly string _sqlConnectionString;
        private readonly string _mongoConnectionString;
        private readonly bool _update;
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public InProgressApplicationPatch(string ukprn, string sqlConnectionString, string mongoConnectionString, bool update = false)
        {
            _ukprn = ukprn;
            _sqlConnectionString = sqlConnectionString;
            _mongoConnectionString = mongoConnectionString;
            _update = update;
        }

        public void Run()
        {
            var sqlApplicationRepository = new Repositories.Sql.ApplicationRepository(_sqlConnectionString);

            var sourceApplications = sqlApplicationRepository
                .GetApplicationIdsByUkprn(_ukprn)
                .Where(application => application.Status == Entities.Sql.ApplicationStatus.InProgress);

            var mongoApplicationRepository = new Repositories.Mongo.ApplicationRepository(_mongoConnectionString);

            foreach (var sourceApplication in sourceApplications)
            {
                Logger.Info($"SOURCE: Application ID: {sourceApplication.ApplicationId}, Status: {sourceApplication.Status}");

                var ids = new[]
                {
                    sourceApplication.ApplicationId
                };

                var targetApplications = mongoApplicationRepository.GetApplicationByLegacyIds(ids);

                foreach (var targetApplication in targetApplications)
                {
                    Logger.Info($"TARGET: Id: {targetApplication.Id} Legacy Application ID: {targetApplication.LegacyApplicationId}, Status: {targetApplication.Status}");

                    if (targetApplication.Status == Entities.Mongo.ApplicationStatus.InProgress)
                    {
                        continue;
                    }

                    Logger.Warn($"Expected: {Entities.Mongo.ApplicationStatus.InProgress}, Actual: {targetApplication.Status}");

                    if (targetApplication.Status != Entities.Mongo.ApplicationStatus.Submitted)
                    {
                        continue;
                    }

                    if (!_update)
                    {
                        continue;
                    }

                    var updated = mongoApplicationRepository.SetApplicationStatus(
                        targetApplication.Id, Entities.Mongo.ApplicationStatus.InProgress);

                    if (updated)
                    {
                        Logger.Info("^Updated");
                    }
                    else
                    {
                        Logger.Error("^Update failed");
                    }
                }
            }
        }
    }
}
