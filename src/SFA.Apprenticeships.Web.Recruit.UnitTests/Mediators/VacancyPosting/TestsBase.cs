﻿namespace SFA.Apprenticeships.Web.Recruit.UnitTests.Mediators.VacancyPosting
{
    using Moq;
    using NUnit.Framework;
    using Recruit.Mediators.VacancyPosting;
    using Recruit.Validators.VacancyPosting;
    using Raa.Common.Validators.Provider;
    using Raa.Common.Validators.Vacancy;
    using Raa.Common.Providers;

    public class TestsBase
    {
        protected Mock<IVacancyPostingProvider> VacancyPostingProvider;
        protected Mock<IProviderProvider> ProviderProvider;
        protected Mock<IEmployerProvider> EmployerProvider;

        [SetUp]
        public void SetUp()
        {
            VacancyPostingProvider = new Mock<IVacancyPostingProvider>();
            ProviderProvider = new Mock<IProviderProvider>();
            EmployerProvider = new Mock<IEmployerProvider>();
        }

        protected IVacancyPostingMediator GetMediator()
        {
            return new VacancyPostingMediator(
                VacancyPostingProvider.Object,
                ProviderProvider.Object,
                EmployerProvider.Object,
                new NewVacancyViewModelServerValidator(),
                new NewVacancyViewModelClientValidator(),
                new VacancySummaryViewModelServerValidator(),
                new VacancySummaryViewModelClientValidator(),
                new VacancyRequirementsProspectsViewModelServerValidator(),
                new VacancyRequirementsProspectsViewModelClientValidator(),
                new VacancyQuestionsViewModelServerValidator(),
                new VacancyQuestionsViewModelClientValidator(),
                new VacancyViewModelValidator(), 
                new VacancyResubmissionValidator(),
                new ProviderSiteEmployerLinkViewModelValidator(),
                new EmployerSearchViewModelServerValidator());
        }
    }
}
