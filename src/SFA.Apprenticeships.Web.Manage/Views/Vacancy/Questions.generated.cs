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
    using SFA.Apprenticeships.Infrastructure.Presentation;
    using SFA.Apprenticeships.Web.Common.Constants;
    using SFA.Apprenticeships.Web.Common.Framework;
    using SFA.Apprenticeships.Web.Common.Models.Common;
    using SFA.Apprenticeships.Web.Manage;
    
    #line 2 "..\..\Views\Vacancy\Questions.cshtml"
    using SFA.Apprenticeships.Web.Manage.Constants;
    
    #line default
    #line hidden
    using SFA.Apprenticeships.Web.Raa.Common.Views.Shared.DisplayTemplates;
    using SFA.Apprenticeships.Web.Raa.Common.Views.Shared.EditorTemplates;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Vacancy/Questions.cshtml")]
    public partial class Questions : System.Web.Mvc.WebViewPage<SFA.Apprenticeships.Web.Raa.Common.ViewModels.Vacancy.VacancyQuestionsViewModel>
    {
        public Questions()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Vacancy\Questions.cshtml"
  
    ViewBag.Title = "Recruit an Apprentice - Enter vacancy question";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n    Questions for candidates\r\n</h1>\r\n\r\n");

            
            #line 11 "..\..\Views\Vacancy\Questions.cshtml"
 using (Html.BeginRouteForm(ManagementRouteNames.Questions, FormMethod.Post))
{
    
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Vacancy\Questions.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Vacancy\Questions.cshtml"
                            
    
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Vacancy\Questions.cshtml"
Write(Html.Partial("ValidationSummary", ViewData.ModelState));

            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Vacancy\Questions.cshtml"
                                                           

    
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Vacancy\Questions.cshtml"
Write(Html.HiddenFor(m => m.VacancyReferenceNumber));

            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Vacancy\Questions.cshtml"
                                                  


            
            #line default
            #line hidden
WriteLiteral("    <section>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 20 "..\..\Views\Vacancy\Questions.cshtml"
       Write(Html.FormTextAreaFor(m => m.FirstQuestion, controlHtmlAttributes: new { @class = "width-all-1-1 form-textarea-medium", type = "text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 21 "..\..\Views\Vacancy\Questions.cshtml"
       Write(Html.EditorFor(m => m.FirstQuestionComment, "Comment"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 22 "..\..\Views\Vacancy\Questions.cshtml"
       Write(Html.FormTextAreaFor(m => m.SecondQuestion, controlHtmlAttributes: new { @class = "width-all-1-1 form-textarea-medium", type = "text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 23 "..\..\Views\Vacancy\Questions.cshtml"
       Write(Html.EditorFor(m => m.SecondQuestionComment, "Comment"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </section>\r\n");

WriteLiteral("    <div");

WriteLiteral(" class=\"grid grid-1-2\"");

WriteLiteral(">\r\n        <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Save</button>\r\n");

WriteLiteral("        ");

            
            #line 28 "..\..\Views\Vacancy\Questions.cshtml"
   Write(Html.RouteLink("Cancel", ManagementRouteNames.ReviewVacancy, new { vacancyReferenceNumber = Model.VacancyReferenceNumber }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 30 "..\..\Views\Vacancy\Questions.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
