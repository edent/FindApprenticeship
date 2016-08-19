﻿namespace SFA.Apprenticeships.Infrastructure.Repositories.Sql.Schemas.dbo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Common;
    using Domain.Interfaces.Repositories;
    using SFA.Infrastructure.Interfaces;
    using Candidate = Domain.Entities.Candidates.Candidate;
    using CandidateSummary = Domain.Entities.Candidates.CandidateSummary;
    using DbCandidateSummary = Entities.CandidateSummary;

    public class CandidateRepository : ICandidateReadRepository
    {
        private readonly IGetOpenConnection _getOpenConnection;
        private readonly IMapper _candidateMapper;
        private readonly ILogService _logService;

        public CandidateRepository(IGetOpenConnection getOpenConnection, ILogService logService)
        {
            _getOpenConnection = getOpenConnection;
            _candidateMapper = new CandidateMappers();
            _logService = logService;
        }

        public Candidate Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Candidate Get(Guid id, bool errorIfNotFound)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Candidate> Get(string username, bool errorIfNotFound = true)
        {
            throw new NotImplementedException();
        }

        public Candidate Get(int legacyCandidateId, bool errorIfNotFound = true)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Candidate> GetAllCandidatesWithPhoneNumber(string phoneNumber, bool errorIfNotFound = true)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Guid> GetCandidatesWithPendingMobileVerification()
        {
            throw new NotImplementedException();
        }

        public Candidate GetBySubscriberId(Guid subscriberId, bool errorIfNotFound = true)
        {
            throw new NotImplementedException();
        }

        public List<CandidateSummary> SearchCandidates(CandidateSearchRequest request)
        {
            _logService.Debug("Calling repository to find candidates matching search request {0}", request);

            if (string.IsNullOrEmpty(request.FirstName) && string.IsNullOrEmpty(request.LastName) && request.DateOfBirth == null && string.IsNullOrEmpty(request.Postcode))
            {
                throw new ArgumentException("You must specify at least one search parameter");
            }

            var query = new List<string>(4);
            if (!string.IsNullOrEmpty(request.FirstName))
            {
                query.Add("FirstName LIKE @FirstName + '%'");
            }
            if (!string.IsNullOrEmpty(request.LastName))
            {
                query.Add("Surname LIKE @LastName + '%'");
            }
            if (request.DateOfBirth.HasValue)
            {
                query.Add("DateofBirth = @DateOfBirth");
            }
            if (!string.IsNullOrEmpty(request.Postcode))
            {
                query.Add("Postcode LIKE @Postcode + '%'");
            }

            var candidates = _candidateMapper.Map<IEnumerable<DbCandidateSummary>, IEnumerable<CandidateSummary>>(
                _getOpenConnection.Query<DbCandidateSummary>(
@"SELECT c.CandidateGuid, p.FirstName, p.MiddleNames, p.Surname, c.DateofBirth, 
c.AddressLine1, c.AddressLine2, c.AddressLine3, c.AddressLine4, c.Postcode, c.Town, ct.FullName As County, c.Latitude, c.Longitude
FROM Person p
JOIN Candidate c ON p.PersonId = c.PersonId
JOIN County ct on c.CountyId = ct.CountyId 
WHERE " + string.Join(" AND ", query),
                    new { request.FirstName, request.LastName, request.DateOfBirth, request.Postcode })).ToList();

            _logService.Debug("Found {1} candidates matching search request {0}", request, candidates.Count);

            return candidates;
        }
    }
}