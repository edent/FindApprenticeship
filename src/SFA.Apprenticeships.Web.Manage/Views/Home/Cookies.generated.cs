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

namespace SFA.Apprenticeships.Web.Manage.Views.Home
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
    using SFA.Apprenticeships.Web.Raa.Common.Views.Shared.DisplayTemplates;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/Cookies.cshtml")]
    public partial class Cookies : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Cookies()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Home\Cookies.cshtml"
  
    ViewBag.Title = "Agency home";
    ViewBag.ShowEuCookieDirective = false;

    Layout = "~/Views/Shared/_Layout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div>\r\n    <h1");

WriteLiteral(" id=\"h1header\"");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">Enable cookies</h1>\r\n\r\n    <p>You can’t currently access the service because you" +
"r cookies have been disabled.</p>\r\n\r\n    <p><a");

WriteLiteral(" href=\"http://www.aboutcookies.org/default.aspx?page=1\"");

WriteLiteral(" rel=\"external\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">Find out how to enable cookies</a></p>\r\n\r\n    <p>Once you’ve enabled your cookie" +
"s please refresh your browser to continue.</p>\r\n\r\n    <a");

WriteLiteral(" role=\"button\"");

WriteLiteral(" class=\"button\"");

WriteAttribute("href", Tuple.Create(" href=\"", 568), Tuple.Create("\"", 593)
            
            #line 17 "..\..\Views\Home\Cookies.cshtml"
, Tuple.Create(Tuple.Create("", 575), Tuple.Create<System.Object, System.Int32>(ViewBag.ReturnUrl
            
            #line default
            #line hidden
, 575), false)
);

WriteLiteral(">Re-check your browser settings</a>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
