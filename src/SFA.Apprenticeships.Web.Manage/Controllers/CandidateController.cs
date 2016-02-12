﻿namespace SFA.Apprenticeships.Web.Manage.Controllers
{
    using System.Web.Mvc;
    using Attributes;
    using Common.Mediators;
    using Domain.Entities;
    using FluentValidation.Mvc;
    using Mediators.Candidate;
    using ViewModels;

    public class CandidateController : ManagementControllerBase
    {
        private readonly ICandidateMediator _candidateMediator;

        public CandidateController(ICandidateMediator candidateMediator)
        {
            _candidateMediator = candidateMediator;
        }

        [HttpGet]
        [AuthorizeUser(Roles = Roles.Raa)]
        public ActionResult Search()
        {
            var response = _candidateMediator.Search();

            return View(response.ViewModel);
        }

        [HttpPost]
        [AuthorizeUser(Roles = Roles.Raa)]
        public ActionResult Search(CandidateSearchResultsViewModel viewModel)
        {
            var response = _candidateMediator.Search(viewModel);

            ModelState.Clear();

            switch (response.Code)
            {
                case CandidateMediatorCodes.Search.FailedValidation:
                    response.ValidationResult.AddToModelState(ModelState, string.Empty);
                    return View(response.ViewModel);

                case CandidateMediatorCodes.Search.Ok:
                    return View(response.ViewModel);

                default:
                    throw new InvalidMediatorCodeException(response.Code);
            }
        }
    }
}