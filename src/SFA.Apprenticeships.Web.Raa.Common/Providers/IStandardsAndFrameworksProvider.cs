﻿namespace SFA.Apprenticeships.Web.Raa.Common.Providers
{
    using ViewModels.Admin;

    public interface IStandardsAndFrameworksProvider
    {
        StandardViewModel CreateStandard(StandardViewModel viewModel);
    }
}