﻿namespace SFA.Apprenticeships.Data.Migrate.Faa
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using Application.Interfaces;
    using Entities.Mongo;
    using Entities.Sql;
    using Infrastructure.Repositories.Sql.Common;
    using MongoDB.Driver;
    using Repository.Mongo;
    using Repository.Sql;
    using Candidate = Entities.Mongo.Candidate;

    public class AuditMigrationProcessor : IMigrationProcessor
    {
        private readonly ILogService _logService;

        private readonly SyncRepository _syncRepository;
        private readonly AuditRepository _auditRepository;
        private readonly CandidateRepository _candidateRepository;

        public AuditMigrationProcessor(SyncRepository syncRepository, IGetOpenConnection targetDatabase, IConfigurationService configurationService, ILogService logService)
        {
            _logService = logService;

            _syncRepository = syncRepository;
            _auditRepository = new AuditRepository(configurationService, logService);
            _candidateRepository = new CandidateRepository(targetDatabase);
        }

        public void Process(CancellationToken cancellationToken)
        {
            var syncParams = _syncRepository.GetSyncParams();
            if (syncParams.IsValidForAuditIncrementalSync)
            {
                ExecuteIncrementalSync(syncParams, cancellationToken);
            }
            else
            {
                ExecuteFullSync(syncParams, cancellationToken);
            }
        }

        private void ExecuteFullSync(SyncParams syncParams, CancellationToken cancellationToken)
        {
            _logService.Warn($"ExecuteFullSync on audits collection with LastAuditEventDate: {syncParams.LastAuditEventDate}");

            var expectedCount = _auditRepository.GetAuditItemsCount(cancellationToken).Result;
            var auditItems = _auditRepository.GetAllAuditItems(cancellationToken).Result;
            ProcessCandidates(auditItems, expectedCount, cancellationToken);
        }

        private void ExecuteIncrementalSync(SyncParams syncParams, CancellationToken cancellationToken)
        {
            _logService.Info($"ExecutePartialSync on candidates collection with LastAuditEventDate: {syncParams.LastAuditEventDate}");

            var expectedCreatedCount = _auditRepository.GetAuditItemsCreatedSinceCount(syncParams.LastAuditEventDate, cancellationToken).Result;
            var createdCursor = _auditRepository.GetAllAuditItemsCreatedSince(syncParams.CandidateLastCreatedDate, cancellationToken).Result;
            ProcessCandidates(createdCursor, expectedCreatedCount, cancellationToken);
        }

        private void ProcessCandidates(IAsyncCursor<AuditItem> cursor, long expectedCount, CancellationToken cancellationToken)
        {
            var count = 0;
            while (cursor.MoveNextAsync(cancellationToken).Result && !cancellationToken.IsCancellationRequested)
            {
                var batch = cursor.Current.ToList();
                if (batch.Count == 0) continue;
                
                _logService.Info($"Processing {batch.Count} audit items");
                
                var maxAuditEvent = batch.Max(a => a.EventDate);

                //Process candidate deltions
                var candidateDeletions = batch.Where(a => a.EventType == AuditEventTypes.HardDeleteCandidateUser);
                var candidateGuids = _candidateRepository.GetCandidateIdsByGuid(candidateDeletions.Select(a => a.PrimaryEntityId));

                count += batch.Count;
                _logService.Info($"Processing {batch.Count} candidate deletions and {candidateGuids.Count} deleted candidates");

                BulkDelete(candidateGuids);

                var syncParams = _syncRepository.GetSyncParams();
                syncParams.LastAuditEventDate = maxAuditEvent;
                _syncRepository.SetAuditEventSyncParams(syncParams);

                var percentage = ((double)count / expectedCount) * 100;
                _logService.Info($"Processed batch of {batch.Count} candidate deletions and {candidateGuids.Count} deleted candidates out of {expectedCount} in total. {Math.Round(percentage, 2)}% complete. LastAuditEventDate: {syncParams.LastAuditEventDate}");
            }
        }

        private void BulkDelete(IDictionary<Guid, int> candidateGuids)
        {
            //throw new NotImplementedException();
        }
    }
}