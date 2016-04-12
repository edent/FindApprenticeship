﻿using SFA.Apprenticeships.Application.Interfaces.Locations;
using SFA.Apprenticeships.Web.Common.Constants;

namespace SFA.Apprenticeships.Web.Raa.Common.UnitTests.Providers.VacancyPosting
{
    using Application.Interfaces.Applications;
    using Application.Interfaces.Employers;
    using Application.Interfaces.Providers;
    using Application.Interfaces.ReferenceData;
    using Application.Interfaces.Users;
    using Application.Interfaces.Vacancies;
    using Application.Interfaces.VacancyPosting;
    using Moq;
    using NUnit.Framework;
    using Common.Providers;
    using SFA.Infrastructure.Interfaces;
    using Web.Common.Configuration;

    public abstract class TestBase
    {
        private Mock<ILogService> _mockLogService;
        private Mock<IApprenticeshipApplicationService> _apprenticeshipApplicationService;
        private Mock<ITraineeshipApplicationService> _traineeshipApplicationService;
        private Mock<IVacancyLockingService> _mockVacancyLockingService;
        protected Mock<IConfigurationService> MockConfigurationService;
        protected Mock<IMapper> MockMapper;
        protected Mock<IVacancyPostingService> MockVacancyPostingService;
        protected Mock<IProviderService> MockProviderService;
        protected Mock<IEmployerService> MockEmployerService;
        protected Mock<IReferenceDataService> MockReferenceDataService;
        protected Mock<IDateTimeService> MockTimeService;
        private Mock<ICurrentUserService> _mockCurrentUserService;
        private Mock<IUserProfileService> _mockUserProfileService;
        protected Mock<IGeoCodeLookupService> MockGeocodeService;
        protected Mock<ILocalAuthorityLookupService> MockLocalAuthorityLookupService;

        [SetUp]
        public void SetUpBase()
        {
            _mockLogService = new Mock<ILogService>();
            MockConfigurationService = new Mock<IConfigurationService>();
            MockMapper = new Mock<IMapper>();
            MockVacancyPostingService = new Mock<IVacancyPostingService>();
            MockProviderService = new Mock<IProviderService>();
            MockEmployerService = new Mock<IEmployerService>();
            MockReferenceDataService = new Mock<IReferenceDataService>();

            MockConfigurationService.Setup(mcs => mcs.Get<CommonWebConfiguration>()).Returns(new CommonWebConfiguration());

            MockTimeService = new Mock<IDateTimeService>();
            _apprenticeshipApplicationService = new Mock<IApprenticeshipApplicationService>();
            _traineeshipApplicationService = new Mock<ITraineeshipApplicationService>();
            _mockVacancyLockingService = new Mock<IVacancyLockingService>();
            _mockCurrentUserService = new Mock<ICurrentUserService>();
            _mockUserProfileService = new Mock<IUserProfileService>();
            MockGeocodeService = new Mock<IGeoCodeLookupService>();
            MockLocalAuthorityLookupService = new Mock<ILocalAuthorityLookupService>();
        }

        protected IVacancyPostingProvider GetVacancyPostingProvider()
        {
            return new VacancyProvider(_mockLogService.Object,
                MockConfigurationService.Object,
                MockVacancyPostingService.Object,
                MockReferenceDataService.Object,
                MockProviderService.Object,
                MockEmployerService.Object,
                MockTimeService.Object,
                MockMapper.Object,
                _apprenticeshipApplicationService.Object,
                _traineeshipApplicationService.Object,
                _mockVacancyLockingService.Object,
                _mockCurrentUserService.Object,
                _mockUserProfileService.Object,
                MockGeocodeService.Object,
                MockLocalAuthorityLookupService.Object);
        }
    }
}