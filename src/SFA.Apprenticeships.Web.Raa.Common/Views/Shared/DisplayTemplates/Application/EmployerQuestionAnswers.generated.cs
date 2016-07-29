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

namespace SFA.Apprenticeships.Web.Raa.Common.Views.Shared.DisplayTemplates.Application
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
    using SFA.Apprenticeships.Web.Raa.Common;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/DisplayTemplates/Application/EmployerQuestionAnswers.cshtml")]
    public partial class EmployerQuestionAnswers : System.Web.Mvc.WebViewPage<SFA.Apprenticeships.Web.Raa.Common.ViewModels.Application.ApplicationViewModel>
    {
        public EmployerQuestionAnswers()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\DisplayTemplates\Application\EmployerQuestionAnswers.cshtml"
 if (Model != null && (!string.IsNullOrWhiteSpace(Model.Vacancy.FirstQuestion) || !string.IsNullOrWhiteSpace(Model.Vacancy.SecondQuestion)))
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"text\"");

WriteLiteral(">\r\n");

            
            #line 6 "..\..\Views\Shared\DisplayTemplates\Application\EmployerQuestionAnswers.cshtml"
        
            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\Shared\DisplayTemplates\Application\EmployerQuestionAnswers.cshtml"
         if (!string.IsNullOrWhiteSpace(Model.Vacancy.FirstQuestion))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <p");

WriteAttribute("class", Tuple.Create(" class=\"", 396), Tuple.Create("\"", 480)
, Tuple.Create(Tuple.Create("", 404), Tuple.Create("form-label", 404), true)
, Tuple.Create(Tuple.Create(" ", 414), Tuple.Create("text", 415), true)
            
            #line 9 "..\..\Views\Shared\DisplayTemplates\Application\EmployerQuestionAnswers.cshtml"
, Tuple.Create(Tuple.Create(" ", 419), Tuple.Create<System.Object, System.Int32>(Model.Vacancy.FirstQuestion.GetPreserveFormattingCssClass()
            
            #line default
            #line hidden
, 420), false)
);

WriteLiteral(">");

            
            #line 9 "..\..\Views\Shared\DisplayTemplates\Application\EmployerQuestionAnswers.cshtml"
                                                                                                   Write(Html.Raw(Model.Vacancy.FirstQuestion));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                <span");

WriteLiteral(" class=\"form-prepopped prewrap\"");

WriteLiteral(">");

            
            #line 10 "..\..\Views\Shared\DisplayTemplates\Application\EmployerQuestionAnswers.cshtml"
                                                Write(Html.Raw(Model.VacancyQuestionAnswers.FirstQuestionAnswer ?? "-"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </div>\r\n");

            
            #line 12 "..\..\Views\Shared\DisplayTemplates\Application\EmployerQuestionAnswers.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 13 "..\..\Views\Shared\DisplayTemplates\Application\EmployerQuestionAnswers.cshtml"
         if (!string.IsNullOrWhiteSpace(Model.Vacancy.SecondQuestion))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <p");

WriteAttribute("class", Tuple.Create(" class=\"", 824), Tuple.Create("\"", 909)
, Tuple.Create(Tuple.Create("", 832), Tuple.Create("form-label", 832), true)
, Tuple.Create(Tuple.Create(" ", 842), Tuple.Create("text", 843), true)
            
            #line 16 "..\..\Views\Shared\DisplayTemplates\Application\EmployerQuestionAnswers.cshtml"
, Tuple.Create(Tuple.Create(" ", 847), Tuple.Create<System.Object, System.Int32>(Model.Vacancy.SecondQuestion.GetPreserveFormattingCssClass()
            
            #line default
            #line hidden
, 848), false)
);

WriteLiteral(">");

            
            #line 16 "..\..\Views\Shared\DisplayTemplates\Application\EmployerQuestionAnswers.cshtml"
                                                                                                    Write(Html.Raw(Model.Vacancy.SecondQuestion));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                <span");

WriteLiteral(" class=\"form-prepopped prewrap\"");

WriteLiteral(">");

            
            #line 17 "..\..\Views\Shared\DisplayTemplates\Application\EmployerQuestionAnswers.cshtml"
                                                Write(Html.Raw(Model.VacancyQuestionAnswers.SecondQuestionAnswer ?? "-"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </div>\r\n");

            
            #line 19 "..\..\Views\Shared\DisplayTemplates\Application\EmployerQuestionAnswers.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n");

            
            #line 21 "..\..\Views\Shared\DisplayTemplates\Application\EmployerQuestionAnswers.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
