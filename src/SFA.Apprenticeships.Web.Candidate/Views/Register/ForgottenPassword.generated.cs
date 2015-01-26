﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SFA.Apprenticeships.Web.Candidate.Views.Register
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Register/ForgottenPassword.cshtml")]
    public partial class ForgottenPassword : System.Web.Mvc.WebViewPage<ForgottenPasswordViewModel>
    {
        public ForgottenPassword()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Register\ForgottenPassword.cshtml"
  
    ViewBag.Title = "Apprenticeships - Forgotten password";
    Layout = "~/Views/Shared/_ApprenticeshipLayout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\r\n    <h1");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">If you can\'t access your account</h1>\r\n</div>\r\n\r\n");

            
            #line 12 "..\..\Views\Register\ForgottenPassword.cshtml"
 using (Html.BeginForm("ForgottenPassword", "Register", FormMethod.Post, new { @id = "forgotten-password-form" }))
{
    
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Register\ForgottenPassword.cshtml"
Write(Html.Partial("ValidationSummary", ViewData.ModelState));

            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Register\ForgottenPassword.cshtml"
                                                           


            
            #line default
            #line hidden
WriteLiteral("    <fieldset");

WriteLiteral(" class=\"inner-block-padr\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"text\"");

WriteLiteral(">\r\n            <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">If you\'ve forgotten your password</h2>\r\n            <p>\r\n                To rese" +
"t your password we need to send you a 6-character code to your\r\n                " +
"email address.\r\n            </p>\r\n        </div>\r\n        \r\n");

WriteLiteral("        ");

            
            #line 25 "..\..\Views\Register\ForgottenPassword.cshtml"
   Write(Html.FormTextFor(m => m.EmailAddress, controlHtmlAttributes: new { @class = "linked-input-master", type = "email", spellcheck = "false", autofocus = "autofocus" }, hintHtmlAttributes: new { @class = "text" }, labelText: "Enter email"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" class=\"button\"");

WriteLiteral(" id=\"forgottenpassword-button\"");

WriteLiteral(">Send code</button>\r\n        </div>\r\n    </fieldset>\r\n");

            
            #line 31 "..\..\Views\Register\ForgottenPassword.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"text\"");

WriteLiteral(">\r\n    <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">If your account is locked</h2>\r\n    <p>\r\n        If your account is locked and y" +
"ou’ve been sent a code to unlock it, you\r\n        can <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1370), Tuple.Create("\"", 1407)
            
            #line 37 "..\..\Views\Register\ForgottenPassword.cshtml"
, Tuple.Create(Tuple.Create("", 1377), Tuple.Create<System.Object, System.Int32>(Url.Action("Unlock", "Login")
            
            #line default
            #line hidden
, 1377), false)
);

WriteLiteral(">enter it</a> now.\r\n    </p>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
