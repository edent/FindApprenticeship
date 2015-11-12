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

namespace SFA.Apprenticeships.Web.Manage.Views.Vacancy
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
    using SFA.Apprenticeships.Web.Common.Constants;
    using SFA.Apprenticeships.Web.Common.Framework;
    using SFA.Apprenticeships.Web.Common.Models.Common;
    using SFA.Apprenticeships.Web.Manage;
    
    #line 2 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
    using SFA.Apprenticeships.Web.Manage.Constants;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Vacancy/RequirementsAndProspects.cshtml")]
    public partial class RequirementsAndProspects : System.Web.Mvc.WebViewPage<SFA.Apprenticeships.Web.Raa.Common.ViewModels.Vacancy.VacancyRequirementsProspectsViewModel>
    {
        public RequirementsAndProspects()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
  
    ViewBag.Title = "Recruit an Apprentice - Enter vacancy requirements and prospects";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n    Requirements and prospects\r\n</h1>\r\n\r\n");

            
            #line 11 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
 using (Html.BeginRouteForm(ManagementRouteNames.RequirementsAndProspoects, FormMethod.Post))
{
    
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
                            
    
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
Write(Html.Partial("ValidationSummary", ViewData.ModelState));

            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
                                                           

    
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
Write(Html.HiddenFor(m => m.VacancyReferenceNumber));

            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
                                                  


            
            #line default
            #line hidden
WriteLiteral("    <section>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 20 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
       Write(Html.FormTextAreaFor(m => m.DesiredSkills, controlHtmlAttributes: new { @class = "width-all-1-1 form-textarea-medium", type = "text", autofocus = "autofocus" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 21 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
       Write(Html.EditorFor(m => m.DesiredSkillsComment, "Comment"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 22 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
       Write(Html.ValidationMessageFor(m => m.DesiredSkillsComment));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 23 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
       Write(Html.FormTextAreaFor(m => m.PersonalQualities, controlHtmlAttributes: new { @class = "width-all-1-1 form-textarea-medium", type = "text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 24 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
       Write(Html.EditorFor(m => m.PersonalQualitiesComment, "Comment"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 25 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
       Write(Html.ValidationMessageFor(m => m.PersonalQualitiesComment));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 26 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
       Write(Html.FormTextAreaFor(m => m.DesiredQualifications, controlHtmlAttributes: new { @class = "width-all-1-1 form-textarea-medium", type = "text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 27 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
       Write(Html.EditorFor(m => m.DesiredQualificationsComment, "Comment"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 28 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
       Write(Html.ValidationMessageFor(m => m.DesiredQualificationsComment));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 29 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
       Write(Html.FormTextAreaFor(m => m.FutureProspects, controlHtmlAttributes: new { @class = "width-all-1-1 form-textarea-medium", type = "text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 30 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
       Write(Html.EditorFor(m => m.FutureProspectsComment, "Comment"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 31 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
       Write(Html.ValidationMessageFor(m => m.FutureProspectsComment));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 32 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
       Write(Html.FormTextAreaFor(m => m.ThingsToConsider, controlHtmlAttributes: new { @class = "width-all-1-1 form-textarea-medium", type = "text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 33 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
       Write(Html.EditorFor(m => m.ThingsToConsiderComment, "Comment"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 34 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
       Write(Html.ValidationMessageFor(m => m.ThingsToConsiderComment));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </section>\r\n");

WriteLiteral("    <div");

WriteLiteral(" class=\"grid grid-1-2\"");

WriteLiteral(">\r\n        <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" name=\"VacancyRequirementsProspects\"");

WriteLiteral(" value=\"VacancyRequirementsProspects\"");

WriteLiteral(">Save and continue</button>\r\n        <button");

WriteLiteral(" id=\"VacancyRequirementsProspectsAndExit\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button-link\"");

WriteLiteral(" name=\"VacancyRequirementsProspects\"");

WriteLiteral(" value=\"VacancyRequirementsProspectsAndExit\"");

WriteLiteral(">Save and exit</button>\r\n    </div>\r\n");

            
            #line 41 "..\..\Views\Vacancy\RequirementsAndProspects.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
