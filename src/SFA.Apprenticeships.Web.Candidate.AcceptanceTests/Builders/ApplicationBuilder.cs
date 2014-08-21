﻿namespace SFA.Apprenticeships.Web.Candidate.AcceptanceTests.Builders
{
    using System;
    using System.Linq;
    using Domain.Entities.Applications;
    using Domain.Entities.Candidates;
    using Domain.Interfaces.Repositories;
    using StructureMap;

    public class ApplicationBuilder
    {
        public ApplicationBuilder(Guid candidateId, string emailAddress)
        {
            RegistrationBuilder = new RegistrationBuilder(emailAddress);

            ApplicationDetail = new ApplicationDetail
            {
                CandidateId = candidateId,
                CandidateInformation = new ApplicationTemplate()
            };
        }

        public ApplicationDetail ApplicationDetail { get; private set; }

        public RegistrationBuilder RegistrationBuilder { get; private set; }

        public ApplicationDetail Build()
        {
            var repo = ObjectFactory.GetInstance<IApplicationWriteRepository>();

            ApplicationDetail.CandidateDetails = RegistrationBuilder.Build();

            repo.Save(ApplicationDetail);

            return ApplicationDetail;
        }

        public void DeleleApplications(Guid userCandidateId)
        {
            var writerepo = ObjectFactory.GetInstance<IApplicationWriteRepository>();
            var readrepo = ObjectFactory.GetInstance<IApplicationReadRepository>();
            var candidateApplications = readrepo.GetForCandidate(UserBuilder.UserAndCandidateId);
            candidateApplications.ToList().ForEach(a => writerepo.Delete(a.ApplicationId));
        }
    }
}
