﻿namespace SFA.Apprenticeships.Web.Candidate.Controllers
{
    using System;
    using System.Web.Mvc;
    using Attributes;
    using Common.Constants;
    using Common.Controllers;
    using Common.Providers;
    using FluentValidation.Mvc;
    using Providers;
    using Validators;
    using ViewModels.Applications;

    public class ApplicationController : SfaControllerBase
    {
        private const string TempAppFormSessionId = "TempAppForm"; // TODO: TEMP: will not be using session

        private readonly IApplicationProvider _applicationProvider;
        private readonly ApplicationViewModelServerValidator _validator;

        public ApplicationController(ISessionStateProvider sessionState,
            IUserServiceProvider userServiceProvider,
            IApplicationProvider applicationProvider,
            ApplicationViewModelServerValidator validator)
            : base(sessionState, userServiceProvider)
        {
            _applicationProvider = applicationProvider;
            _validator = validator;
        }

        [AuthorizeCandidate(Roles = UserRoleNames.Activated)]
        public ActionResult Apply(int id)
        {
            var candidateId = new Guid(User.Identity.Name); // TODO: REFACTOR: move to UserContext?
            var model = _applicationProvider.GetApplicationViewModel(id, candidateId);

            if (model == null)
            {
                Response.StatusCode = 404;
                return View("VacancyNotFound");
            }

            return View(model);
        }

        [HttpPost]
        [AuthorizeCandidate(Roles = UserRoleNames.Activated)]
        public ActionResult Apply(int id, ApplicationViewModel applicationViewModel)
        {
            var result = _validator.Validate(applicationViewModel);

            if (!result.IsValid)
            {
                ModelState.Clear();
                result.AddToModelState(ModelState, string.Empty);

                return View(applicationViewModel);
            }

            _applicationProvider.SaveApplication(applicationViewModel);

            return RedirectToAction("Preview", new { applicationDetailViewModelId = applicationViewModel.ApplicationViewId });
        }

        public ActionResult Preview(string applicationDetailViewModelId)
        {
            var appForm = Session.Get<ApplicationViewModel>(TempAppFormSessionId);

            ViewBag.ApplicationId = id;

            return View(appForm);
        }

        public ActionResult SubmitApplication(string applicationDetailViewModelId)
        {
            try
            {
                var applicationViewId = Guid.Parse(applicationDetailViewModelId);
                _applicationProvider.SubmitApplication(applicationViewId);

                return RedirectToAction("WhatHappensNext"); 
            }
            catch (Exception)
            {
                return RedirectToAction("Preview", new { id = applicationDetailViewModelId }); //TODO change Preview action to accept ViewModelId from Context
            }
        }

        public ActionResult WhatHappensNext()
        {
            return View();
        }
    }
}
