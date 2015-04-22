﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SFA.Apprenticeships.Web.Candidate.Views.Login
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
    using SFA.Apprenticeships.Web.Candidate;
    using SFA.Apprenticeships.Web.Candidate.Constants;
    using SFA.Apprenticeships.Web.Candidate.Constants.ViewModels;
    using SFA.Apprenticeships.Web.Candidate.Helpers;
    using SFA.Apprenticeships.Web.Candidate.ViewModels;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Candidate;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Locations;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Login;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Register;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.VacancySearch;
    using SFA.Apprenticeships.Web.Common.Constants;
    using SFA.Apprenticeships.Web.Common.Framework;
    using SFA.Apprenticeships.Web.Common.Models.Common;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Login/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<LoginViewModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Login\Index.cshtml"
  
    ViewBag.Title = "Sign in or Create an account - Find an apprenticeship";
    Layout = "~/Views/Shared/_Layout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 8 "..\..\Views\Login\Index.cshtml"
Write(Html.Partial("ValidationSummary", ViewData.ModelState));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"grid-wrapper\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"grid grid-1-2\"");

WriteLiteral(">\r\n");

            
            #line 12 "..\..\Views\Login\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Login\Index.cshtml"
         using (Html.BeginRouteForm(RouteNames.SignIn, FormMethod.Post))
        {
            
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Login\Index.cshtml"
       Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Login\Index.cshtml"
                                    ;

            
            #line default
            #line hidden
WriteLiteral("            <h1");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Sign in</h1>\r\n");

WriteLiteral("            <p>\r\n                Sign in or\r\n");

WriteLiteral("                ");

            
            #line 18 "..\..\Views\Login\Index.cshtml"
           Write(Html.ActionLink("create an account", controllerName: "Register", actionName: "Index"));

            
            #line default
            #line hidden
WriteLiteral(".\r\n            </p>\r\n");

            
            #line 20 "..\..\Views\Login\Index.cshtml"

            
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\Login\Index.cshtml"
       Write(Html.FormTextFor(
                m => m.EmailAddress,
                containerHtmlAttributes: new { @class = "form-group-compound" },
                controlHtmlAttributes: new { @class = "form-control-3-4", type = "email", autofocus = "autofocus", spellcheck = "false" }));

            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Login\Index.cshtml"
                                                                                                                                          


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" id=\"password\"");

WriteLiteral("></a>\r\n");

WriteLiteral("                ");

            
            #line 28 "..\..\Views\Login\Index.cshtml"
           Write(Html.LabelFor(m => m.Password, new { @class = "form-label" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 29 "..\..\Views\Login\Index.cshtml"
           Write(Html.PasswordFor(m => m.Password, new { @class = "form-control form-control-3-4" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 30 "..\..\Views\Login\Index.cshtml"
           Write(Html.ValidationMessageFor(m => m.Password, null));

            
            #line default
            #line hidden
WriteLiteral("\r\n                \r\n                <a");

WriteLiteral(" class=\"form-hint\"");

WriteAttribute("href", Tuple.Create(" href=\'", 1299), Tuple.Create("\'", 1350)
            
            #line 32 "..\..\Views\Login\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1306), Tuple.Create<System.Object, System.Int32>(Url.Action(RouteNames.ForgottenCredentials)
            
            #line default
            #line hidden
, 1306), false)
);

WriteLiteral(">I can\'t access my account</a>\r\n            </div>\r\n");

            
            #line 34 "..\..\Views\Login\Index.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" class=\"button\"");

WriteLiteral(" id=\"sign-in-button\"");

WriteLiteral(">Sign in</button>\r\n            </div>\r\n");

            
            #line 38 "..\..\Views\Login\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n    <div");

WriteLiteral(" class=\"grid grid-1-2\"");

WriteLiteral(">\r\n        <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Create an account</h2>\r\n        <div");

WriteLiteral(" class=\"text\"");

WriteLiteral(">\r\n            <p>\r\n                This is a new service. You must create an acc" +
"ount if you’ve not used it before.\r\n");

WriteLiteral("                ");

            
            #line 45 "..\..\Views\Login\Index.cshtml"
           Write(Html.ActionLink("Create an account", "Index", "Register", null, new { id = "create-account-link" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"panel-indent\"");

WriteLiteral(">\r\n            <p>\r\n                If you’ve applied for an apprenticeship befor" +
"e you’ll only be able to access your application history using your old account." +
" <a");

WriteLiteral(" href=\"https://apprenticeshipvacancymatchingservice.lsc.gov.uk/navms/Forms/Candid" +
"ate/CandidatesLogin.aspx\"");

WriteLiteral(" rel=\"external\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">Sign in to old account</a>\r\n            </p>\r\n        </div>\r\n    </div>\r\n</div>" +
"\r\n");

        }
    }
}
#pragma warning restore 1591
