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
    
    #line 2 "..\..\Views\VacancyPosting\VacancyRequirementsProspects.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 3 "..\..\Views\VacancyPosting\VacancyRequirementsProspects.cshtml"
    using SFA.Apprenticeships.Domain.Entities.Raa.Vacancies;
    
    #line default
    #line hidden
    using SFA.Apprenticeships.Infrastructure.Presentation;
    using SFA.Apprenticeships.Web.Common.Constants;
    using SFA.Apprenticeships.Web.Common.Framework;
    using SFA.Apprenticeships.Web.Common.Models.Common;
    
    #line 4 "..\..\Views\VacancyPosting\VacancyRequirementsProspects.cshtml"
    using SFA.Apprenticeships.Web.Raa.Common.ViewModels.Vacancy;
    
    #line default
    #line hidden
    using SFA.Apprenticeships.Web.Raa.Common.Views.Shared.DisplayTemplates;
    using SFA.Apprenticeships.Web.Recruit;
    
    #line 5 "..\..\Views\VacancyPosting\VacancyRequirementsProspects.cshtml"
    using SFA.Apprenticeships.Web.Recruit.Constants;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/VacancyPosting/VacancyRequirementsProspects.cshtml")]
    public partial class VacancyRequirementsProspects : System.Web.Mvc.WebViewPage<VacancyRequirementsProspectsViewModel>
    {
        public VacancyRequirementsProspects()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 7 "..\..\Views\VacancyPosting\VacancyRequirementsProspects.cshtml"
 using (Html.BeginRouteForm(RecruitmentRouteNames.VacancyRequirementsProspects, FormMethod.Post))
{
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\VacancyPosting\VacancyRequirementsProspects.cshtml"
Write(Html.HiddenFor(m => m.AutoSaveTimeoutInSeconds));

            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\VacancyPosting\VacancyRequirementsProspects.cshtml"
                                                    
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\VacancyPosting\VacancyRequirementsProspects.cshtml"
Write(Html.DisplayFor(m => m, VacancyRequirementsProspectsViewModel.PartialView));

            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\VacancyPosting\VacancyRequirementsProspects.cshtml"
                                                                               

    var saveButtonText = (Model.Status == VacancyStatus.Referred || Model.ComeFromPreview) ? "Save and return to Preview" : "Save and continue";


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"grid grid-1-2\"");

WriteLiteral(">\r\n        <button");

WriteLiteral(" id=\"VacancyRequirementsProspectsButton\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" name=\"VacancyRequirementsProspects\"");

WriteLiteral(" value=\"VacancyRequirementsProspects\"");

WriteLiteral(">");

            
            #line 15 "..\..\Views\VacancyPosting\VacancyRequirementsProspects.cshtml"
                                                                                                                                                         Write(saveButtonText);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n        <button");

WriteLiteral(" id=\"VacancyRequirementsProspectsAndExit\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button-link\"");

WriteLiteral(" name=\"VacancyRequirementsProspects\"");

WriteLiteral(" value=\"VacancyRequirementsProspectsAndExit\"");

WriteLiteral(">Save and exit</button>\r\n");

            
            #line 17 "..\..\Views\VacancyPosting\VacancyRequirementsProspects.cshtml"
        
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\VacancyPosting\VacancyRequirementsProspects.cshtml"
         if (Model.ComeFromPreview)
        {
            
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\VacancyPosting\VacancyRequirementsProspects.cshtml"
       Write(Html.RouteLink("Cancel", RecruitmentRouteNames.PreviewVacancy, new { vacancyReferenceNumber = Model.VacancyReferenceNumber }));

            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\VacancyPosting\VacancyRequirementsProspects.cshtml"
                                                                                                                                          
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n");

            
            #line 22 "..\..\Views\VacancyPosting\VacancyRequirementsProspects.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 26 "..\..\Views\VacancyPosting\VacancyRequirementsProspects.cshtml"
Write(Scripts.Render("~/bundles/autosave"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <script>\r\n        var autoSaveTimeout = ");

            
            #line 29 "..\..\Views\VacancyPosting\VacancyRequirementsProspects.cshtml"
                         Write(Html.Raw(Json.Encode(Model.AutoSaveTimeoutInSeconds)));

            
            #line default
            #line hidden
WriteLiteral(" * 1000;\r\n\r\n        $(window).on(\'load\', function() {\r\n            autoSave.initi" +
"alise({\r\n                formSelector: \"form\",\r\n                timeout: autoSav" +
"eTimeout,\r\n                postUrl: \'");

            
            #line 35 "..\..\Views\VacancyPosting\VacancyRequirementsProspects.cshtml"
                     Write(Url.RouteUrl(RecruitmentRouteNames.AutoSaveRequirementsProspects));

            
            #line default
            #line hidden
WriteLiteral("\'\r\n            });\r\n        });\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591
