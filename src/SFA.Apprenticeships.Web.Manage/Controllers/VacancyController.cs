﻿namespace SFA.Apprenticeships.Web.Manage.Controllers
{
    using System.Web.Mvc;
    using Attributes;
    using Common.Attributes;
    using Constants;
    using Mediators.Vacancy;
    using Common.Mediators;
    using Common.Validators.Extensions;
    using Domain.Entities.Vacancies.ProviderVacancies;
    using FluentValidation.Mvc;
    using Raa.Common.ViewModels.Vacancy;

    [AuthorizeUser(Roles = Roles.Raa)]
    [OwinSessionTimeout]
    public class VacancyController : ManagementControllerBase
    {
        private readonly IVacancyMediator _vacancyMediator;

        public VacancyController(IVacancyMediator vacancyMediator)
        {
            _vacancyMediator = vacancyMediator;
        }

        // GET: Vacancy
        [HttpGet]
        [OutputCache(Duration = 0, NoStore = true, VaryByParam = "none")]
        public ActionResult Review(long vacancyReferenceNumber)
        {
            var response = _vacancyMediator.ReserveVacancyForQA(vacancyReferenceNumber);
            var vacancyViewModel = response.ViewModel;
            
            vacancyViewModel.BasicDetailsLink = Url.RouteUrl(ManagementRouteNames.BasicDetails, new { vacancyReferenceNumber = vacancyViewModel.VacancyReferenceNumber });
            vacancyViewModel.SummaryLink = Url.RouteUrl(ManagementRouteNames.Summary, new { vacancyReferenceNumber = vacancyViewModel.VacancyReferenceNumber });
            vacancyViewModel.RequirementsProspectsLink = Url.RouteUrl(ManagementRouteNames.RequirementsAndProspoects, new { vacancyReferenceNumber = vacancyViewModel.VacancyReferenceNumber });
            vacancyViewModel.QuestionsLink = Url.RouteUrl(ManagementRouteNames.Questions, new { vacancyReferenceNumber = vacancyViewModel.VacancyReferenceNumber });

            ModelState.Clear();

            switch (response.Code)
            {
                case VacancyMediatorCodes.GetVacancy.FailedValidation:
                    response.ValidationResult.AddToModelStateWithSeverity(ModelState, string.Empty);
                    var view = View(vacancyViewModel);
                    return view;

                case VacancyMediatorCodes.GetVacancy.Ok:
                    return View(vacancyViewModel);

                default:
                    throw new InvalidMediatorCodeException(response.Code);
            }
        }

        [HttpGet]
        [OutputCache(Duration = 0, NoStore = true, VaryByParam = "none")]
        public ActionResult BasicDetails(long vacancyReferenceNumber)
        {
            var response = _vacancyMediator.GetBasicDetails(vacancyReferenceNumber);

            ModelState.Clear();

            switch (response.Code)
            {
                case VacancyMediatorCodes.GetBasicVacancyDetails.FailedValidation:
                    response.ValidationResult.AddToModelState(ModelState, string.Empty);
                    return View(response.ViewModel);

                case VacancyMediatorCodes.GetBasicVacancyDetails.Ok:
                    return View(response.ViewModel);

                default:
                    throw new InvalidMediatorCodeException(response.Code);
            }
        }

        [MultipleFormActionsButton(SubmitButtonActionName = "BasicDetails")]
        [HttpPost]
        public ActionResult BasicDetails(NewVacancyViewModel viewModel)
        {
            var response = _vacancyMediator.UpdateVacancy(viewModel);

            ModelState.Clear();

            switch (response.Code)
            {
                case VacancyMediatorCodes.UpdateVacancy.FailedValidation:
                    response.ValidationResult.AddToModelState(ModelState, string.Empty);
                    return View(response.ViewModel);

                case VacancyMediatorCodes.UpdateVacancy.Ok:
                    return RedirectToRoute(ManagementRouteNames.ReviewVacancy,
                    new
                    {
                        vacancyReferenceNumber = response.ViewModel.VacancyReferenceNumber
                    });

                default:
                    throw new InvalidMediatorCodeException(response.Code);
            }
        }

        [MultipleFormActionsButton(SubmitButtonActionName = "BasicDetails")]
        [HttpPost]
        public ActionResult SelectFramework(NewVacancyViewModel viewModel)
        {
            var response = _vacancyMediator.GetBasicDetails(viewModel.VacancyReferenceNumber.Value);

            viewModel.TrainingType = TrainingType.Frameworks;
            viewModel.Standards = response.ViewModel.Standards;
            viewModel.SectorsAndFrameworks = response.ViewModel.SectorsAndFrameworks;

            ModelState.Clear();

            return View("BasicDetails", viewModel);
        }

        [MultipleFormActionsButton(SubmitButtonActionName = "BasicDetails")]
        [HttpPost]
        public ActionResult SelectStandard(NewVacancyViewModel viewModel)
        {
            var response = _vacancyMediator.GetBasicDetails(viewModel.VacancyReferenceNumber.Value);

            viewModel.TrainingType = TrainingType.Standards;
            viewModel.Standards = response.ViewModel.Standards;
            viewModel.SectorsAndFrameworks = response.ViewModel.SectorsAndFrameworks;

            ModelState.Clear();

            return View("BasicDetails", viewModel);
        }

        [HttpGet]
        [OutputCache(Duration = 0, NoStore = true, VaryByParam = "none")]
        public ActionResult Summary(long vacancyReferenceNumber)
        {
            var response = _vacancyMediator.GetVacancySummaryViewModel(vacancyReferenceNumber);

            ModelState.Clear();

            switch (response.Code)
            {
                case VacancyMediatorCodes.GetVacancySummaryViewModel.FailedValidation:
                    response.ValidationResult.AddToModelStateWithSeverity(ModelState, string.Empty);
                    return View(response.ViewModel);

                case VacancyMediatorCodes.GetVacancySummaryViewModel.Ok:
                    return View(response.ViewModel);

                default:
                    throw new InvalidMediatorCodeException(response.Code);
            }
        }

        [HttpPost]
        public ActionResult Summary(VacancySummaryViewModel viewModel)
        {
            var response = _vacancyMediator.UpdateVacancy(viewModel);

            ModelState.Clear();

            switch (response.Code)
            {
                case VacancyMediatorCodes.UpdateVacancy.FailedValidation:
                    response.ValidationResult.AddToModelStateWithSeverity(ModelState, string.Empty);
                    return View(response.ViewModel);

                case VacancyMediatorCodes.UpdateVacancy.Ok:
                    return RedirectToRoute(ManagementRouteNames.ReviewVacancy,
                    new
                    {
                        vacancyReferenceNumber = response.ViewModel.VacancyReferenceNumber
                    });

                default:
                    throw new InvalidMediatorCodeException(response.Code);
            }
        }

        [HttpGet]
        [OutputCache(Duration = 0, NoStore = true, VaryByParam = "none")]
        public ActionResult RequirementsAndProspects(long vacancyReferenceNumber)
        {
            var response = _vacancyMediator.GetVacancyRequirementsProspectsViewModel(vacancyReferenceNumber);

            ModelState.Clear();

            switch (response.Code)
            {
                case VacancyMediatorCodes.GetVacancyRequirementsProspectsViewModel.FailedValidation:
                    response.ValidationResult.AddToModelState(ModelState, string.Empty);
                    return View(response.ViewModel);

                case VacancyMediatorCodes.GetVacancyRequirementsProspectsViewModel.Ok:
                    return View(response.ViewModel);

                default:
                    throw new InvalidMediatorCodeException(response.Code);
            }
        }

        [HttpPost]
        public ActionResult RequirementsAndProspects(VacancyRequirementsProspectsViewModel viewModel)
        {
            var response = _vacancyMediator.UpdateVacancy(viewModel);

            ModelState.Clear();

            switch (response.Code)
            {
                case VacancyMediatorCodes.UpdateVacancy.FailedValidation:
                    response.ValidationResult.AddToModelState(ModelState, string.Empty);
                    return View(response.ViewModel);

                case VacancyMediatorCodes.UpdateVacancy.Ok:
                    return RedirectToRoute(ManagementRouteNames.ReviewVacancy, new
                    {
                        vacancyReferenceNumber = response.ViewModel.VacancyReferenceNumber
                    });

                default:
                    throw new InvalidMediatorCodeException(response.Code);
            }
        }

        [HttpGet]
        [OutputCache(Duration = 0, NoStore = true, VaryByParam = "none")]
        public ActionResult Questions(long vacancyReferenceNumber)
        {
            var response = _vacancyMediator.GetVacancyQuestionsViewModel(vacancyReferenceNumber);

            ModelState.Clear();

            switch (response.Code)
            {
                case VacancyMediatorCodes.GetVacancyQuestionsViewModel.FailedValidation:
                    response.ValidationResult.AddToModelStateWithSeverity(ModelState, string.Empty);
                    return View(response.ViewModel);

                case VacancyMediatorCodes.GetVacancyQuestionsViewModel.Ok:
                    return View(response.ViewModel);

                default:
                    throw new InvalidMediatorCodeException(response.Code);
            }
        }

        [HttpPost]
        public ActionResult Questions(VacancyQuestionsViewModel viewModel)
        {
            var response = _vacancyMediator.UpdateVacancy(viewModel);

            ModelState.Clear();

            switch (response.Code)
            {
                case VacancyMediatorCodes.UpdateVacancy.FailedValidation:
                    response.ValidationResult.AddToModelState(ModelState, string.Empty);
                    return View(response.ViewModel);

                case VacancyMediatorCodes.UpdateVacancy.Ok:
                    return RedirectToRoute(ManagementRouteNames.ReviewVacancy,
                        new
                        {
                            vacancyReferenceNumber = response.ViewModel.VacancyReferenceNumber
                        });

                default:
                    throw new InvalidMediatorCodeException(response.Code);
            }
        }

        [MultipleFormActionsButton(SubmitButtonActionName = "VacancyQAAction")]
        [HttpPost]
        public ActionResult Approve(long vacancyReferenceNumber)
        {
            var response = _vacancyMediator.ApproveVacancy(vacancyReferenceNumber);

            switch (response.Code)
            {
                case VacancyMediatorCodes.ApproveVacancy.NoAvailableVacancies:
                    return RedirectToRoute(ManagementRouteNames.Dashboard);
                case VacancyMediatorCodes.ApproveVacancy.Ok:
                    return RedirectToRoute(ManagementRouteNames.ReviewVacancy, new { vacancyReferenceNumber =  response.ViewModel.VacancyReferenceNumber});
                default:
                    return RedirectToRoute(ManagementRouteNames.Dashboard);
            }
        }

        [MultipleFormActionsButton(SubmitButtonActionName = "VacancyQAAction")]
        [HttpPost]
        public ActionResult Reject(long vacancyReferenceNumber)
        {
            var response = _vacancyMediator.RejectVacancy(vacancyReferenceNumber);

            switch (response.Code)
            {
                case VacancyMediatorCodes.RejectVacancy.NoAvailableVacancies:
                    return RedirectToRoute(ManagementRouteNames.Dashboard);
                case VacancyMediatorCodes.RejectVacancy.Ok:
                    return RedirectToRoute(ManagementRouteNames.ReviewVacancy, new { vacancyReferenceNumber = response.ViewModel.VacancyReferenceNumber });
                default:
                    return RedirectToRoute(ManagementRouteNames.Dashboard);
            }
        }
    }
}