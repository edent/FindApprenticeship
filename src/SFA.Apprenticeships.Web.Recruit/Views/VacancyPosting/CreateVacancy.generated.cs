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

namespace SFA.Apprenticeships.Web.Recruit.Views.VacancyPosting
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
    
    #line 2 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
    using SFA.Apprenticeships.Domain.Entities.Vacancies.Apprenticeships;
    
    #line default
    #line hidden
    using SFA.Apprenticeships.Web.Common.Constants;
    using SFA.Apprenticeships.Web.Common.Framework;
    using SFA.Apprenticeships.Web.Common.Models.Common;
    using SFA.Apprenticeships.Web.Recruit;
    
    #line 3 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
    using SFA.Apprenticeships.Web.Recruit.Constants;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/VacancyPosting/CreateVacancy.cshtml")]
    public partial class CreateVacancy : System.Web.Mvc.WebViewPage<SFA.Apprenticeships.Web.Recruit.ViewModels.Vacancy.NewVacancyViewModel>
    {
        public CreateVacancy()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
  
    ViewBag.Title = "Recruit an Apprentice - Select framework and level";

    const string selected = "selected";

    var isApplicationThroughRAAYes = !Model.OfflineVacancy ? selected : null;
    var isApplicationThroughRAANo = Model.OfflineVacancy ? selected : null;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n    Select framework and level\r\n</h1>\r\n\r\n");

            
            #line 17 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
 using (Html.BeginRouteForm(RecruitmentRouteNames.CreateVacancy, FormMethod.Post))
{
    
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
                            
    
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
Write(Html.Partial("ValidationSummary", ViewData.ModelState));

            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
                                                           

    
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
Write(Html.FormTextAreaFor(m => m.Title, controlHtmlAttributes: new { type = "text", size = 12, @class = "width-all-1-1 form-textarea-small" }));

            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
                                                                                                                                              


            
            #line default
            #line hidden
WriteLiteral("    <!--TODO: Why is 4000 characters remaining appearing?-->\r\n");

            
            #line 25 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
    
            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
Write(Html.FormTextAreaFor(m => m.ShortDescription, controlHtmlAttributes: new { type = "text", size = 12, @class = "width-all-1-1 form-textarea-medium" }));

            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
                                                                                                                                                          


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" for=\"FrameworkCodeName\"");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Apprenticeship framework</label>\r\n        <select");

WriteAttribute("id", Tuple.Create(" id=\"", 1237), Tuple.Create("\"", 1287)
            
            #line 29 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
, Tuple.Create(Tuple.Create("", 1242), Tuple.Create<System.Object, System.Int32>(Html.IdFor(model => model.FrameworkCodeName)
            
            #line default
            #line hidden
, 1242), false)
);

WriteAttribute("name", Tuple.Create(" name=\"", 1288), Tuple.Create("\"", 1334)
            
            #line 29 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
, Tuple.Create(Tuple.Create("", 1295), Tuple.Create<System.Object, System.Int32>(Html.NameFor(m => m.FrameworkCodeName)
            
            #line default
            #line hidden
, 1295), false)
);

WriteLiteral(" class=\"para-btm-margin chosen-select\"");

WriteLiteral(" style=\"min-width: 50%;\"");

WriteLiteral(">\r\n");

            
            #line 30 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
            
            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
             if (!string.IsNullOrWhiteSpace(Model.FrameworkCodeName))
            {
                var matchingFramework =
                    Model
                    .SectorsAndFrameworks
                    .First(sector => sector.Frameworks.Exists(f => f.CodeName == Model.FrameworkCodeName))
                    .Frameworks
                    .First(framework => framework.CodeName == Model.FrameworkCodeName);

            
            #line default
            #line hidden
WriteLiteral("                <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1850), Tuple.Create("\"", 1885)
            
            #line 38 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
, Tuple.Create(Tuple.Create("", 1858), Tuple.Create<System.Object, System.Int32>(matchingFramework.CodeName
            
            #line default
            #line hidden
, 1858), false)
);

WriteLiteral(">");

            
            #line 38 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
                                                       Write(matchingFramework.FullName);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 39 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <option");

WriteLiteral(" value=\"\"");

WriteLiteral(" selected>Choose from the list of frameworks</option>\r\n");

            
            #line 43 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 44 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
             foreach (var sector in Model.SectorsAndFrameworks)
            {

            
            #line default
            #line hidden
WriteLiteral("                <optgroup");

WriteAttribute("label", Tuple.Create(" label=\"", 2180), Tuple.Create("\"", 2204)
            
            #line 46 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
, Tuple.Create(Tuple.Create("", 2188), Tuple.Create<System.Object, System.Int32>(sector.FullName
            
            #line default
            #line hidden
, 2188), false)
);

WriteLiteral(">\r\n");

            
            #line 47 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 47 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
                     foreach (var framework in sector.Frameworks)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <option");

WriteAttribute("value", Tuple.Create(" value=\"", 2329), Tuple.Create("\"", 2356)
            
            #line 49 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
, Tuple.Create(Tuple.Create("", 2337), Tuple.Create<System.Object, System.Int32>(framework.CodeName
            
            #line default
            #line hidden
, 2337), false)
);

WriteLiteral(">");

            
            #line 49 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
                                                       Write(framework.FullName);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 50 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </optgroup>\r\n");

            
            #line 52 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </select>\r\n    </div>\r\n");

            
            #line 55 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Apprenticeship level</label>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group small-btm-margin clearfix\"");

WriteLiteral(">\r\n            ");

WriteLiteral("\r\n            <label");

WriteLiteral(" for=\"apprenticeship-level-intermediate\"");

WriteLiteral(" class=\"block-label\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 62 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
           Write(Html.RadioButtonFor(model => model.ApprenticeshipLevel, ApprenticeshipLevel.Intermediate, new { id = "apprenticeship-level-intermediate", aria_labelledby = "apprenticeship-level-label" }));

            
            #line default
            #line hidden
WriteLiteral(" Intermediate\r\n            </label>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group small-btm-margin clearfix\"");

WriteLiteral(">\r\n            ");

WriteLiteral("\r\n            <label");

WriteLiteral(" for=\"apprenticeship-level-advanced\"");

WriteLiteral(" class=\"block-label\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 69 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
           Write(Html.RadioButtonFor(model => model.ApprenticeshipLevel, ApprenticeshipLevel.Advanced, new {id = "apprenticeship-level-advanced", aria_labelledby = "apprenticeship-level-label"}));

            
            #line default
            #line hidden
WriteLiteral(" Advanced\r\n            </label>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group small-btm-margin clearfix\"");

WriteLiteral(">\r\n            ");

WriteLiteral("\r\n            <label");

WriteLiteral(" for=\"apprenticeship-level-higher\"");

WriteLiteral(" class=\"block-label\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 76 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
           Write(Html.RadioButtonFor(model => model.ApprenticeshipLevel, ApprenticeshipLevel.Higher, new {id = "apprenticeship-level-higher", aria_labelledby = "apprenticeship-level-label"}));

            
            #line default
            #line hidden
WriteLiteral(" Higher\r\n            </label>\r\n        </div>\r\n    </div>\r\n");

WriteLiteral("    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"blocklabel-single-container\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"form-group inline clearfix blocklabel-single hide-nojs\"");

WriteLiteral(">\r\n                <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(">Manage application method</h3>\r\n                <p>\r\n                    Will th" +
"is vacancy be managed through the recruit an apprentice\r\n                    sit" +
"e?\r\n                </p>\r\n                ");

WriteLiteral("\r\n                <label");

WriteLiteral(" for=\"apprenticeship-online-vacancy\"");

WriteLiteral(" class=\"block-label\"");

WriteLiteral(" data-target=\"online-panel\"");

WriteLiteral(" ");

            
            #line 89 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
                                                                                                     Write(isApplicationThroughRAAYes);

            
            #line default
            #line hidden
WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 90 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
               Write(Html.RadioButtonFor(model => model.OfflineVacancy, false, new {id = "apprenticeship-online-vacancy", aria_labelledby = "apprenticeship-vacancy-management-type-label"}));

            
            #line default
            #line hidden
WriteLiteral(" Yes\r\n                </label>\r\n\r\n                ");

WriteLiteral("\r\n                <label");

WriteLiteral(" for=\"apprenticeship-offline-vacancy\"");

WriteLiteral(" class=\"block-label\"");

WriteLiteral(" data-target=\"offline-panel\"");

WriteLiteral(" ");

            
            #line 94 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
                                                                                                       Write(isApplicationThroughRAANo);

            
            #line default
            #line hidden
WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 95 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
               Write(Html.RadioButtonFor(model => model.OfflineVacancy, true, new {id = "apprenticeship-offline-vacancy", aria_labelledby = "apprenticeship-vacancy-management-type-label", aria_controls="offline-panel"}));

            
            #line default
            #line hidden
WriteLiteral(" No\r\n                </label>\r\n            </div>\r\n            <div");

WriteLiteral(" id=\"offline-panel\"");

WriteLiteral(" class=\"toggle-content panel-indent blocklabel-content\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    ");

WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 101 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
               Write(Html.FormTextFor(m => m.OfflineApplicationUrl, controlHtmlAttributes: new {@class = "width-all-1-2", type = "text", size = 12, id = "apprenticeship-offline-application-url"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    ");

WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 105 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
               Write(Html.FormTextAreaFor(m => m.OfflineApplicationInstructions, controlHtmlAttributes: new {type = "text", size = 12, @class = "width-all-1-1 form-textarea-medium", id = "apprenticheship-offline-application-instructions"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <br/>\r\n                </div>\r\n            </div>\r\n        " +
"</div>\r\n    </div>\r\n");

            
            #line 111 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"

    
            
            #line default
            #line hidden
            
            #line 112 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
Write(Html.HiddenFor(model => model.VacancyReferenceNumber));

            
            #line default
            #line hidden
            
            #line 112 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
                                                          
    
            
            #line default
            #line hidden
            
            #line 113 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
Write(Html.HiddenFor(model => model.Ukprn));

            
            #line default
            #line hidden
            
            #line 113 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
                                         
    
            
            #line default
            #line hidden
            
            #line 114 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
Write(Html.HiddenFor(model => model.ProviderSiteEmployerLink.ProviderSiteErn));

            
            #line default
            #line hidden
            
            #line 114 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
                                                                            
    
            
            #line default
            #line hidden
            
            #line 115 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
Write(Html.HiddenFor(model => model.ProviderSiteEmployerLink.Employer.Ern));

            
            #line default
            #line hidden
            
            #line 115 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
                                                                         ;


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" name=\"CreateVacancy\"");

WriteLiteral(" value=\"CreateVacancy\"");

WriteLiteral(">Save and continue</button>\r\n        <button");

WriteLiteral(" id=\"createVacancyAndExit\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button-link\"");

WriteLiteral(" name=\"CreateVacancy\"");

WriteLiteral(" value=\"CreateVacancyAndExit\"");

WriteLiteral(">Save and exit</button>\r\n    </div>\r\n");

            
            #line 121 "..\..\Views\VacancyPosting\CreateVacancy.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
