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
    
    #line 2 "..\..\Views\VacancyPosting\PreviewVacancy.cshtml"
    using SFA.Apprenticeships.Domain.Entities.Vacancies.ProviderVacancies;
    
    #line default
    #line hidden
    using SFA.Apprenticeships.Web.Common.Constants;
    using SFA.Apprenticeships.Web.Common.Framework;
    using SFA.Apprenticeships.Web.Common.Models.Common;
    
    #line 3 "..\..\Views\VacancyPosting\PreviewVacancy.cshtml"
    using SFA.Apprenticeships.Web.Raa.Common.ViewModels.Vacancy;
    
    #line default
    #line hidden
    using SFA.Apprenticeships.Web.Raa.Common.Views.Shared.DisplayTemplates;
    using SFA.Apprenticeships.Web.Raa.Common.Views.Shared.EditorTemplates;
    using SFA.Apprenticeships.Web.Recruit;
    
    #line 4 "..\..\Views\VacancyPosting\PreviewVacancy.cshtml"
    using SFA.Apprenticeships.Web.Recruit.Constants;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/VacancyPosting/PreviewVacancy.cshtml")]
    public partial class PreviewVacancy : System.Web.Mvc.WebViewPage<VacancyViewModel>
    {
        public PreviewVacancy()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\VacancyPosting\PreviewVacancy.cshtml"
  
    ViewBag.Title = "Recruit an Apprentice - Preview vacancy";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 9 "..\..\Views\VacancyPosting\PreviewVacancy.cshtml"
Write(Html.Partial("ValidationSummary", ViewData.ModelState));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div>\r\n    <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n        Vacancy preview\r\n    </h1>\r\n\r\n");

WriteLiteral("    ");

            
            #line 16 "..\..\Views\VacancyPosting\PreviewVacancy.cshtml"
Write(Html.DisplayFor(m => m, VacancyViewModel.PartialView));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 18 "..\..\Views\VacancyPosting\PreviewVacancy.cshtml"
    
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\VacancyPosting\PreviewVacancy.cshtml"
     using (Html.BeginRouteForm(RecruitmentRouteNames.SubmitVacancy, FormMethod.Post))
    {
        
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\VacancyPosting\PreviewVacancy.cshtml"
   Write(Html.HiddenFor(m => m.VacancyReferenceNumber));

            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\VacancyPosting\PreviewVacancy.cshtml"
                                                      

        if (Model.Status == ProviderVacancyStatuses.RejectedByQA)
        {
            Model.ResubmitOption = false;
            
            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\VacancyPosting\PreviewVacancy.cshtml"
       Write(Html.FormCheckBoxFor(model => model.ResubmitOption, labelHtmlAttributes: new { @class = "block-label para-btm-margin" }));

            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\VacancyPosting\PreviewVacancy.cshtml"
                                                                                                                                    
        }
        else
        {
            Model.ResubmitOption = true;
            
            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\VacancyPosting\PreviewVacancy.cshtml"
       Write(Html.HiddenFor(model => model.ResubmitOption));

            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\VacancyPosting\PreviewVacancy.cshtml"
                                                         
        }


            
            #line default
            #line hidden
WriteLiteral("        <section>\r\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

            
            #line 35 "..\..\Views\VacancyPosting\PreviewVacancy.cshtml"
                
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\VacancyPosting\PreviewVacancy.cshtml"
                 if (Model.Status == ProviderVacancyStatuses.RejectedByQA)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Resubmit vacancy</button>\r\n");

            
            #line 38 "..\..\Views\VacancyPosting\PreviewVacancy.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Submit for approval</button>\r\n");

            
            #line 42 "..\..\Views\VacancyPosting\PreviewVacancy.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteLiteral(" id=\"dashboardLink\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1476), Tuple.Create("\"", 1535)
            
            #line 43 "..\..\Views\VacancyPosting\PreviewVacancy.cshtml"
, Tuple.Create(Tuple.Create("", 1483), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(RecruitmentRouteNames.RecruitmentHome)
            
            #line default
            #line hidden
, 1483), false)
);

WriteLiteral(">Save and exit</a>\r\n            </div>\r\n        </section>\r\n");

            
            #line 46 "..\..\Views\VacancyPosting\PreviewVacancy.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
