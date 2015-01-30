﻿namespace SFA.Apprenticeships.Web.Candidate.UnitTests.Views.ApprenticeshipSearch
{
    using Candidate.ViewModels.VacancySearch;
    using Candidate.Views.ApprenticeshipSearch;
    using FluentAssertions;
    using NUnit.Framework;
    using RazorGenerator.Testing;

    [TestFixture]
    public class IndexTests : MediatorTestsBase
    {
        [Test]
        public void SearchModeKeywordBasicVisibilityTest()
        {
            var index = new Index();

            var searchViewModel = Mediator.Index(ApprenticeshipSearchMode.Keyword).ViewModel;
            var view = index.RenderAsHtml(searchViewModel);

            view.GetElementbyId("Keywords").ParentNode.Attributes["class"].Value.Contains(" active").Should().BeTrue();
            view.GetElementbyId("Location").Should().NotBeNull();
            view.GetElementbyId("loc-within").Should().NotBeNull();
            view.GetElementbyId("apprenticeship-level").Should().NotBeNull();
            view.GetElementbyId("search-button").Attributes["class"].Value.Contains(" active").Should().BeTrue();
            view.GetElementbyId("browse-button").Attributes["class"].Value.Contains(" active").Should().BeFalse();
        }

        [Test]
        public void SearchModeCategoryBasicVisibilityTest()
        {
            var index = new Index();

            var searchViewModel = Mediator.Index(ApprenticeshipSearchMode.Category).ViewModel;
            var view = index.RenderAsHtml(searchViewModel);

            view.GetElementbyId("Keywords").ParentNode.Attributes["class"].Value.Contains(" active").Should().BeFalse();
            view.GetElementbyId("Location").Should().NotBeNull();
            view.GetElementbyId("loc-within").Should().NotBeNull();
            view.GetElementbyId("apprenticeship-level").Should().NotBeNull();
            view.GetElementbyId("search-button").Attributes["class"].Value.Contains(" active").Should().BeFalse();
            view.GetElementbyId("browse-button").Attributes["class"].Value.Contains(" active").Should().BeTrue();
        }
    }
}