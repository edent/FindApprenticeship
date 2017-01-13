﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SFA.Apprenticeships.Web.Raa.Common.Views.Shared.DisplayTemplates.Vacancy
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 5 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
    using HtmlExtensions = SFA.Apprenticeships.Web.Common.Framework.HtmlExtensions;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
    using SFA.Apprenticeships.Domain.Entities.Raa.Vacancies;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
    using SFA.Apprenticeships.Infrastructure.Presentation;
    
    #line default
    #line hidden
    using SFA.Apprenticeships.Web.Common.Constants;
    using SFA.Apprenticeships.Web.Common.Framework;
    using SFA.Apprenticeships.Web.Common.Models.Common;
    using SFA.Apprenticeships.Web.Raa.Common;
    
    #line 3 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
    using SFA.Apprenticeships.Web.Raa.Common.Extensions;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
    using SFA.Apprenticeships.Web.Raa.Common.ViewModels.Vacancy;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/DisplayTemplates/Vacancy/_VacancyDetails.cshtml")]
    public partial class VacancyDetails : System.Web.Mvc.WebViewPage<VacancyViewModel>
    {
        public VacancyDetails()
        {
        }
        public override void Execute()
        {
            
            #line 8 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
  
    var editableItemClass = ViewData["editableItemClass"];
    var editableApprenticeshipLevel = string.IsNullOrWhiteSpace(Model.StandardName);
    var editableApprenticeshipLevelClass = (!Model.IsEditable || !editableApprenticeshipLevel) ? "" : "editable-item";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<section");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(" id=\"vacancy-info\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"column-full\"");

WriteLiteral(">\r\n        \r\n");

            
            #line 17 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
         if (Model.VacancyType == VacancyType.Traineeship)
        {

            
            #line default
            #line hidden
WriteLiteral("            <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Traineeship details</h2>\r\n");

            
            #line 20 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Apprenticeship summary</h2>\r\n");

            
            #line 24 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n    <div");

WriteLiteral(" class=\"column-one-third\"");

WriteLiteral(">\r\n        <ul");

WriteLiteral(" class=\"list\"");

WriteLiteral(">\r\n");

            
            #line 28 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
            
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
             if (Model.VacancyType == VacancyType.Traineeship)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" class=\"sfa-if-first\"");

WriteLiteral(">\r\n                    <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(">Training provider</h3>\r\n                    <p");

WriteLiteral(" id=\"vacancy-provider-name\"");

WriteLiteral(">");

            
            #line 32 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                                             Write(Model.ProviderSite.TradingName);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </li>\r\n");

            
            #line 34 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteAttribute("class", Tuple.Create(" class=\"", 1347), Tuple.Create("\"", 1373)
            
            #line 35 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
, Tuple.Create(Tuple.Create("", 1355), Tuple.Create<System.Object, System.Int32>(editableItemClass
            
            #line default
            #line hidden
, 1355), false)
);

WriteLiteral(">\r\n                    <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(">\r\n                        Traineeship sector\r\n");

WriteLiteral("                        ");

            
            #line 38 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                   Write(Html.Partial(CommentViewModel.PartialIconView, Html.GetCommentViewModel(Model, m => m.TrainingDetailsViewModel.SectorCodeName, Model.TrainingDetailsViewModel.SectorCodeNameComment, Model.TrainingDetailsLink)));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </h3>\r\n                    <p");

WriteLiteral(" id=\"traineeship-sector\"");

WriteLiteral(">");

            
            #line 40 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                                          Write(Html.DisplayFor(m => m.SectorName));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

WriteLiteral("                    ");

            
            #line 41 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
               Write(Html.Partial(EditLinkViewModel.PartialView, Html.GetEditLinkViewModel(Model, m => m.TrainingDetailsViewModel.SectorCodeName, Model.TrainingDetailsLink, Model.TrainingDetailsViewModel.SectorCodeNameComment)));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n");

            
            #line 43 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 45 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
       Write(Html.Partial("DisplayTemplates/Vacancy/_WorkingWeekAndWage", Model, new ViewDataDictionary { { "editableItemClass", editableItemClass } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n            <li");

WriteAttribute("class", Tuple.Create(" class=\"", 2258), Tuple.Create("\"", 2284)
            
            #line 47 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
, Tuple.Create(Tuple.Create("", 2266), Tuple.Create<System.Object, System.Int32>(editableItemClass
            
            #line default
            #line hidden
, 2266), false)
);

WriteLiteral(">\r\n                <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(">\r\n");

            
            #line 49 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                     if (Model.VacancyType == VacancyType.Traineeship)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <span>Expected duration</span>\r\n");

            
            #line 52 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <span>Expected apprenticeship duration</span>\r\n");

            
            #line 56 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 57 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
               Write(Html.Partial(ValidationResultViewModel.PartialView, Html.GetValidationResultViewModel(Model, m => m.FurtherVacancyDetailsViewModel.Duration, ViewData.ModelState, Model.SummaryLink, Model.FurtherVacancyDetailsViewModel.DurationComment)));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h3>\r\n                <p");

WriteLiteral(" id=\"vacancy-expected-duration\"");

WriteLiteral(">");

            
            #line 59 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                                             Write(Model.FurtherVacancyDetailsViewModel.DurationTypeDisplayText);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

WriteLiteral("                ");

            
            #line 60 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
           Write(Html.Partial(EditLinkViewModel.PartialView, Html.GetEditLinkViewModel(Model, m => m.FurtherVacancyDetailsViewModel.Duration, Model.SummaryLink, Model.FurtherVacancyDetailsViewModel.DurationComment)));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n\r\n            <li");

WriteAttribute("class", Tuple.Create(" class=\"", 3300), Tuple.Create("\"", 3326)
            
            #line 63 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
, Tuple.Create(Tuple.Create("", 3308), Tuple.Create<System.Object, System.Int32>(editableItemClass
            
            #line default
            #line hidden
, 3308), false)
);

WriteLiteral(">\r\n                <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(">\r\n                    Possible start date\r\n");

WriteLiteral("                    ");

            
            #line 66 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
               Write(Html.Partial(ValidationResultViewModel.PartialView, Html.GetValidationResultViewModel(Model, m => m.FurtherVacancyDetailsViewModel.VacancyDatesViewModel.PossibleStartDate, ViewData.ModelState, Model.SummaryLink, Model.FurtherVacancyDetailsViewModel.VacancyDatesViewModel.PossibleStartDateComment)));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h3>\r\n                <p");

WriteLiteral(" id=\"vacancy-start-date\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 69 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
               Write(Html.DisplayFor(m => Model.FurtherVacancyDetailsViewModel.VacancyDatesViewModel.PossibleStartDate.Date));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </p>\r\n");

WriteLiteral("                ");

            
            #line 71 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
           Write(Html.Partial(EditLinkViewModel.PartialView, Html.GetEditLinkViewModel(Model, m => m.FurtherVacancyDetailsViewModel.VacancyDatesViewModel.PossibleStartDate, Model.SummaryLink, Model.FurtherVacancyDetailsViewModel.VacancyDatesViewModel.PossibleStartDateComment)));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n\r\n");

            
            #line 74 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
            
            
            #line default
            #line hidden
            
            #line 74 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
             if (Model.VacancyType == VacancyType.Apprenticeship)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteAttribute("class", Tuple.Create(" class=\"", 4352), Tuple.Create("\"", 4393)
            
            #line 76 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
, Tuple.Create(Tuple.Create("", 4360), Tuple.Create<System.Object, System.Int32>(editableApprenticeshipLevelClass
            
            #line default
            #line hidden
, 4360), false)
);

WriteLiteral(">\r\n                    <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(">\r\n                        Apprenticeship level\r\n");

WriteLiteral("                        ");

            
            #line 79 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                   Write(Html.Partial(CommentViewModel.PartialIconView, Html.GetCommentViewModel(Model, m => m.TrainingDetailsViewModel.ApprenticeshipLevel, Model.TrainingDetailsViewModel.ApprenticeshipLevelComment, Model.TrainingDetailsLink)));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </h3>\r\n                    <p");

WriteLiteral(" id=\"vacancy-type\"");

WriteLiteral(" itemprop=\"employmentType\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 82 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                   Write(Html.DisplayFor(m => m.TrainingDetailsViewModel.ApprenticeshipLevel));

            
            #line default
            #line hidden
WriteLiteral(" Level Apprenticeship\r\n                    </p>\r\n");

            
            #line 84 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 84 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                     if (editableApprenticeshipLevel)
                {
                        
            
            #line default
            #line hidden
            
            #line 86 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                   Write(Html.Partial(EditLinkViewModel.PartialView, Html.GetEditLinkViewModel(Model, m => m.TrainingDetailsViewModel.ApprenticeshipLevel, Model.TrainingDetailsLink, Model.TrainingDetailsViewModel.ApprenticeshipLevelComment)));

            
            #line default
            #line hidden
            
            #line 86 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                                                                                                                                                                                                                                                 
                    }

            
            #line default
            #line hidden
WriteLiteral("                </li>\r\n");

            
            #line 89 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <li>\r\n                <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(">Reference number</h3>\r\n");

            
            #line 92 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                
            
            #line default
            #line hidden
            
            #line 92 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                 if (Model.NewVacancyViewModel.LocationAddresses != null && Model.NewVacancyViewModel.LocationAddresses.Count > 1)
            {

            
            #line default
            #line hidden
WriteLiteral("                    <p>Will be generated on approval</p>\r\n");

            
            #line 95 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <p");

WriteLiteral(" id=\"vacancy-reference-id\"");

WriteLiteral(">");

            
            #line 98 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                                            Write(Model.VacancyReferenceNumber.GetVacancyReference());

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 99 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </li>\r\n");

            
            #line 101 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
            
            
            #line default
            #line hidden
            
            #line 101 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
             if (Model.IsSingleLocation || Model.IsNationwideLocation)
            {
                if (!Model.IsManageReviewerView && Model.IsNationwideLocation)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteAttribute("class", Tuple.Create(" class=\"", 6053), Tuple.Create("\"", 6079)
            
            #line 105 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
, Tuple.Create(Tuple.Create("", 6061), Tuple.Create<System.Object, System.Int32>(editableItemClass
            
            #line default
            #line hidden
, 6061), false)
);

WriteLiteral(">\r\n                        <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(">Positions</h3>\r\n                        <p");

WriteLiteral(" id=\"vacancy-reference-id\"");

WriteLiteral(">");

            
            #line 107 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                                                Write(Model.NewVacancyViewModel.NumberOfPositions);

            
            #line default
            #line hidden
WriteLiteral(" available</p>\r\n");

WriteLiteral("                        ");

            
            #line 108 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                   Write(Html.Partial(EditLinkViewModel.PartialView, Html.GetEditLinkViewModel(Model, m => m.NewVacancyViewModel.NumberOfPositions, Model.EmployerLink, Model.NewVacancyViewModel.NumberOfPositionsComment)));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </li>\r\n");

            
            #line 110 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                }
            }
            else
            {
                if (Model.NewVacancyViewModel.LocationAddresses != null && Model.NewVacancyViewModel.LocationAddresses.Count == 1)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteAttribute("class", Tuple.Create(" class=\"", 6752), Tuple.Create("\"", 6778)
            
            #line 116 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
, Tuple.Create(Tuple.Create("", 6760), Tuple.Create<System.Object, System.Int32>(editableItemClass
            
            #line default
            #line hidden
, 6760), false)
);

WriteLiteral(">\r\n                        <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(">Positions</h3>\r\n                        <p");

WriteLiteral(" id=\"vacancy-reference-id\"");

WriteLiteral(">");

            
            #line 118 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                                                Write(Model.NewVacancyViewModel.LocationAddresses.First().NumberOfPositions);

            
            #line default
            #line hidden
WriteLiteral(" available</p>\r\n");

WriteLiteral("                        ");

            
            #line 119 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                   Write(Html.Partial(EditLinkViewModel.PartialView, Html.GetEditLinkViewModel(Model, m => m.NewVacancyViewModel.LocationAddresses.First().NumberOfPositions, Model.EmployerLink, Model.NewVacancyViewModel.NumberOfPositionsComment)));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </li>\r\n");

            
            #line 121 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 124 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
            
            
            #line default
            #line hidden
            
            #line 124 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
             if (Model.VacancyType == VacancyType.Traineeship)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteAttribute("class", Tuple.Create(" class=\"", 7396), Tuple.Create("\"", 7422)
            
            #line 126 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
, Tuple.Create(Tuple.Create("", 7404), Tuple.Create<System.Object, System.Int32>(editableItemClass
            
            #line default
            #line hidden
, 7404), false)
);

WriteLiteral(">\r\n                    <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(">\r\n                        Contact details\r\n");

WriteLiteral("                        ");

            
            #line 129 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                   Write(Html.Partial(CommentViewModel.PartialIconView, Html.GetCommentViewModel(Model, m => m.TrainingDetailsViewModel.ContactName, Model.TrainingDetailsViewModel.ContactDetailsComment, Model.TrainingDetailsLink)));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </h3>\r\n");

            
            #line 131 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 131 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                     if (string.IsNullOrEmpty(Model.TrainingDetailsViewModel.ContactName) && string.IsNullOrEmpty(Model.TrainingDetailsViewModel.ContactNumber) && string.IsNullOrEmpty(Model.TrainingDetailsViewModel.ContactEmail))
                {

            
            #line default
            #line hidden
WriteLiteral("                        <span>None specified. This message will not appear on the" +
" vacancy when it goes live</span>\r\n");

            
            #line 134 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <p");

WriteLiteral(" class=\"sfa-small-bottom-margin\"");

WriteLiteral(">");

            
            #line 137 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                                                      Write(Model.TrainingDetailsViewModel.ContactName);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

WriteLiteral("                        <p");

WriteLiteral(" class=\"sfa-small-bottom-margin\"");

WriteLiteral(">");

            
            #line 138 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                                                      Write(Model.TrainingDetailsViewModel.ContactNumber);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

WriteLiteral("                        <p");

WriteLiteral(" class=\"sfa-small-bottom-margin\"");

WriteLiteral(">");

            
            #line 139 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                                                      Write(Model.TrainingDetailsViewModel.ContactEmail);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 140 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 141 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
               Write(Html.Partial(EditLinkViewModel.PartialView, Html.GetEditLinkViewModel(Model, m => m.TrainingDetailsViewModel.ContactName, Model.TrainingDetailsLink, Model.TrainingDetailsViewModel.ContactDetailsComment)));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n");

            
            #line 143 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n    </div>\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <div");

WriteAttribute("class", Tuple.Create(" class=\"", 8910), Tuple.Create("\"", 8949)
            
            #line 147 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
, Tuple.Create(Tuple.Create("", 8918), Tuple.Create<System.Object, System.Int32>(editableItemClass
            
            #line default
            #line hidden
, 8918), false)
, Tuple.Create(Tuple.Create(" ", 8936), Tuple.Create("sfa-if-first", 8937), true)
);

WriteLiteral(" itemprop=\"responsibilities\"");

WriteLiteral(">\r\n");

            
            #line 148 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                
            
            #line default
            #line hidden
            
            #line 148 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                 if (!Model.IsCandidateView)
            {

            
            #line default
            #line hidden
WriteLiteral("            <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(" id=\"long-description-header\"");

WriteLiteral(">\r\n");

            
            #line 151 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                
            
            #line default
            #line hidden
            
            #line 151 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                 if (Model.VacancyType == VacancyType.Traineeship)
                    {

            
            #line default
            #line hidden
WriteLiteral("                    <span>Work placement</span>\r\n");

            
            #line 154 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                    <span>Vacancy description</span>\r\n");

            
            #line 158 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 159 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
           Write(Html.Partial(CommentViewModel.PartialIconView, Html.GetCommentViewModel(Model, m => m.FurtherVacancyDetailsViewModel.LongDescription, Model.FurtherVacancyDetailsViewModel.LongDescriptionComment, Model.SummaryLink)));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </h3>\r\n");

            
            #line 161 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" id=\"vacancy-full-descrpition\"");

WriteAttribute("class", Tuple.Create(" class=\"", 9717), Tuple.Create("\"", 9836)
, Tuple.Create(Tuple.Create("", 9725), Tuple.Create("sfa-text-editor-generated", 9725), true)
            
            #line 162 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
   , Tuple.Create(Tuple.Create(" ", 9750), Tuple.Create<System.Object, System.Int32>(Model.FurtherVacancyDetailsViewModel.LongDescription.GetPreserveFormattingCssClass()
            
            #line default
            #line hidden
, 9751), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 163 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                Write(SFA.Apprenticeships.Web.Common.Framework.HtmlExtensions.EscapeHtmlEncoding(Html, Model.FurtherVacancyDetailsViewModel.LongDescription));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");

WriteLiteral("                ");

            
            #line 165 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
           Write(Html.Partial(EditLinkViewModel.PartialView, Html.GetEditLinkViewModel(Model, m => m.FurtherVacancyDetailsViewModel.LongDescription, Model.SummaryLink, Model.FurtherVacancyDetailsViewModel.LongDescriptionComment)));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 167 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
            
            
            #line default
            #line hidden
            
            #line 167 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
             if (Model.VacancyType == VacancyType.Traineeship)
        {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteAttribute("class", Tuple.Create(" class=\"", 10361), Tuple.Create("\"", 10387)
            
            #line 169 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
, Tuple.Create(Tuple.Create("", 10369), Tuple.Create<System.Object, System.Int32>(editableItemClass
            
            #line default
            #line hidden
, 10369), false)
);

WriteLiteral(">\r\n            <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(">\r\n                Training to be provided\r\n");

WriteLiteral("                ");

            
            #line 172 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
           Write(Html.Partial(CommentViewModel.PartialIconView, Html.GetCommentViewModel(Model, m => m.TrainingDetailsViewModel.TrainingProvided, Model.TrainingDetailsViewModel.TrainingProvidedComment, Model.TrainingDetailsLink)));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </h3>\r\n            <div");

WriteLiteral(" id=\"vacancy-training-to-be-provided\"");

WriteAttribute("class", Tuple.Create(" class=\"", 10775), Tuple.Create("\"", 10889)
, Tuple.Create(Tuple.Create("", 10783), Tuple.Create("sfa-text-editor-generated", 10783), true)
            
            #line 174 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
     , Tuple.Create(Tuple.Create(" ", 10808), Tuple.Create<System.Object, System.Int32>(Model.TrainingDetailsViewModel.TrainingProvided.GetPreserveFormattingCssClass()
            
            #line default
            #line hidden
, 10809), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 175 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
            Write(SFA.Apprenticeships.Web.Common.Framework.HtmlExtensions.EscapeHtmlEncoding(Html, Model.TrainingDetailsViewModel.TrainingProvided));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

WriteLiteral("            ");

            
            #line 177 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
       Write(Html.Partial(EditLinkViewModel.PartialView, Html.GetEditLinkViewModel(Model, m => m.TrainingDetailsViewModel.TrainingProvided, Model.TrainingDetailsLink, Model.TrainingDetailsViewModel.TrainingProvidedComment)));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteAttribute("class", Tuple.Create(" class=\"", 11316), Tuple.Create("\"", 11342)
            
            #line 179 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
, Tuple.Create(Tuple.Create("", 11324), Tuple.Create<System.Object, System.Int32>(editableItemClass
            
            #line default
            #line hidden
, 11324), false)
);

WriteLiteral(">\r\n            <div>\r\n                <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(">\r\n                    Future prospects\r\n");

WriteLiteral("                    ");

            
            #line 183 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
               Write(Html.Partial(CommentViewModel.PartialIconView, Html.GetCommentViewModel(Model, m => m.VacancyRequirementsProspectsViewModel.FutureProspects, Model.VacancyRequirementsProspectsViewModel.FutureProspectsComment, Model.RequirementsProspectsLink)));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h3>\r\n                <div");

WriteLiteral(" id=\"vacancy-future-prospects\"");

WriteLiteral(" itemprop=\"incentives\"");

WriteAttribute("class", Tuple.Create(" class=\"", 11807), Tuple.Create("\"", 11933)
, Tuple.Create(Tuple.Create("", 11815), Tuple.Create("sfa-text-editor-generated", 11815), true)
            
            #line 185 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                        , Tuple.Create(Tuple.Create(" ", 11840), Tuple.Create<System.Object, System.Int32>(Model.VacancyRequirementsProspectsViewModel.FutureProspects.GetPreserveFormattingCssClass()
            
            #line default
            #line hidden
, 11841), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 186 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
                Write(SFA.Apprenticeships.Web.Common.Framework.HtmlExtensions.EscapeHtmlEncoding(Html, Model.VacancyRequirementsProspectsViewModel.FutureProspects));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");

WriteLiteral("                ");

            
            #line 188 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
           Write(Html.Partial(EditLinkViewModel.PartialView, Html.GetEditLinkViewModel(Model, m => m.VacancyRequirementsProspectsViewModel.FutureProspects, Model.RequirementsProspectsLink, Model.VacancyRequirementsProspectsViewModel.FutureProspectsComment)));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

            
            #line 191 "..\..\Views\Shared\DisplayTemplates\Vacancy\_VacancyDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n</section>\r\n<hr");

WriteLiteral(" class=\"sfa-no-bottom-margin\"");

WriteLiteral(" />");

        }
    }
}
#pragma warning restore 1591
