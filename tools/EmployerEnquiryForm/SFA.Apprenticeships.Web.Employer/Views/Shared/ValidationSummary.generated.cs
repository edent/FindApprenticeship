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

namespace ASP
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
    using SFA.Apprenticeships.Web.Employer;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/ValidationSummary.cshtml")]
    public partial class _Views_Shared_ValidationSummary_cshtml : System.Web.Mvc.WebViewPage<ModelStateDictionary>
    {
        public _Views_Shared_ValidationSummary_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" id=\"validation-summary\"");

WriteAttribute("class", Tuple.Create(" class=\'", 59), Tuple.Create("\'", 180)
            
            #line 3 "..\..\Views\Shared\ValidationSummary.cshtml"
, Tuple.Create(Tuple.Create("", 67), Tuple.Create<System.Object, System.Int32>(Html.ViewData.ModelState.IsValid ? "validation-summary-valid" : "validation-summary-errors"
            
            #line default
            #line hidden
, 67), false)
, Tuple.Create(Tuple.Create(" ", 161), Tuple.Create("panel", 162), true)
, Tuple.Create(Tuple.Create(" ", 167), Tuple.Create("panel-danger", 168), true)
);

WriteLiteral(" data-valmsg-summary=\"true\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n        <ul>\r\n");

            
            #line 6 "..\..\Views\Shared\ValidationSummary.cshtml"
            
            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\Shared\ValidationSummary.cshtml"
             foreach (var modelKey in Model.Keys)
            {
                var modelState = Model[modelKey];
                var elementId = ViewData.TemplateInfo.GetFullHtmlFieldId(modelKey);
                foreach (var modelError in modelState.Errors)
                {
                    if (elementId == string.Empty)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <li>");

            
            #line 14 "..\..\Views\Shared\ValidationSummary.cshtml"
                       Write(modelError.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 15 "..\..\Views\Shared\ValidationSummary.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 775), Tuple.Create("\"", 806)
, Tuple.Create(Tuple.Create("", 782), Tuple.Create("#", 782), true)
            
            #line 18 "..\..\Views\Shared\ValidationSummary.cshtml"
, Tuple.Create(Tuple.Create("", 783), Tuple.Create<System.Object, System.Int32>(@elementId.ToLower()
            
            #line default
            #line hidden
, 783), false)
);

WriteLiteral(">");

            
            #line 18 "..\..\Views\Shared\ValidationSummary.cshtml"
                                                          Write(modelError.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 19 "..\..\Views\Shared\ValidationSummary.cshtml"
                    }
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
