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

namespace SFA.Apprenticeships.Web.Recruit.Views.Shared
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
    
    #line 1 "..\..\Views\Shared\ValidationSummary.cshtml"
    using SFA.Apprenticeships.Web.Common.Validators;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\ValidationSummary.cshtml"
    using SFA.Apprenticeships.Web.Common.Validators.Extensions;
    
    #line default
    #line hidden
    using SFA.Apprenticeships.Web.Raa.Common.Views.Shared.DisplayTemplates;
    using SFA.Apprenticeships.Web.Raa.Common.Views.Shared.EditorTemplates;
    using SFA.Apprenticeships.Web.Recruit;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/ValidationSummary.cshtml")]
    public partial class ValidationSummary : System.Web.Mvc.WebViewPage<ModelStateDictionary>
    {
        public ValidationSummary()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" id=\"validation-summary-errors\"");

WriteAttribute("class", Tuple.Create(" class=\'", 177), Tuple.Create("\'", 283)
            
            #line 5 "..\..\Views\Shared\ValidationSummary.cshtml"
, Tuple.Create(Tuple.Create("", 185), Tuple.Create<System.Object, System.Int32>(Model.HasErrors() ? "validation-summary-errors" : "validation-summary-valid"
            
            #line default
            #line hidden
, 185), false)
, Tuple.Create(Tuple.Create(" ", 264), Tuple.Create("panel", 265), true)
, Tuple.Create(Tuple.Create(" ", 270), Tuple.Create("panel-danger", 271), true)
);

WriteLiteral(" data-valmsg-summary=\"true\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n        <ul>\r\n");

            
            #line 8 "..\..\Views\Shared\ValidationSummary.cshtml"
            
            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\Shared\ValidationSummary.cshtml"
             foreach (var modelKey in Model.Keys)
            {
                var modelState = Model[modelKey];

                var elementId = ViewData.TemplateInfo.GetFullHtmlFieldId(modelKey);
                foreach (var modelError in modelState.Errors)
                {
                    if (modelError.GetType() == typeof (ModelError))
                    {
                        if (elementId == string.Empty)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>");

            
            #line 19 "..\..\Views\Shared\ValidationSummary.cshtml"
                           Write(modelError.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 20 "..\..\Views\Shared\ValidationSummary.cshtml"
                        }
                        else
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1001), Tuple.Create("\"", 1032)
, Tuple.Create(Tuple.Create("", 1008), Tuple.Create("#", 1008), true)
            
            #line 23 "..\..\Views\Shared\ValidationSummary.cshtml"
, Tuple.Create(Tuple.Create("", 1009), Tuple.Create<System.Object, System.Int32>(@elementId.ToLower()
            
            #line default
            #line hidden
, 1009), false)
);

WriteLiteral(">");

            
            #line 23 "..\..\Views\Shared\ValidationSummary.cshtml"
                                                              Write(modelError.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 24 "..\..\Views\Shared\ValidationSummary.cshtml"
                        }
                    }
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n    </div>\r\n</div>\r\n\r\n");

            
            #line 32 "..\..\Views\Shared\ValidationSummary.cshtml"
  
    var hasWarnings = Model.HasWarnings();

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" id=\"validation-summary-warnings\"");

WriteAttribute("class", Tuple.Create(" class=\'", 1280), Tuple.Create("\'", 1383)
            
            #line 36 "..\..\Views\Shared\ValidationSummary.cshtml"
, Tuple.Create(Tuple.Create("", 1288), Tuple.Create<System.Object, System.Int32>(hasWarnings ? "validation-summary-warnings" : "validation-summary-valid"
            
            #line default
            #line hidden
, 1288), false)
, Tuple.Create(Tuple.Create(" ", 1363), Tuple.Create("panel", 1364), true)
, Tuple.Create(Tuple.Create(" ", 1369), Tuple.Create("panel-warning", 1370), true)
);

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n        <ul>\r\n");

            
            #line 39 "..\..\Views\Shared\ValidationSummary.cshtml"
            
            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\Shared\ValidationSummary.cshtml"
             foreach (var modelKey in Model.Keys)
            {
                var modelState = Model[modelKey];
                var elementId = ViewData.TemplateInfo.GetFullHtmlFieldId(modelKey);

                var anyError = modelState.Errors.Any(modelError => modelError.GetType() == typeof (ModelError));
                foreach (var modelError in modelState.Errors)
                {
                    if (modelError.GetType() == typeof (ModelWarning) && !anyError)
                    {
                        if (elementId == string.Empty)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>");

            
            #line 51 "..\..\Views\Shared\ValidationSummary.cshtml"
                           Write(modelError.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 52 "..\..\Views\Shared\ValidationSummary.cshtml"
                        }
                        else
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2203), Tuple.Create("\"", 2234)
, Tuple.Create(Tuple.Create("", 2210), Tuple.Create("#", 2210), true)
            
            #line 55 "..\..\Views\Shared\ValidationSummary.cshtml"
, Tuple.Create(Tuple.Create("", 2211), Tuple.Create<System.Object, System.Int32>(@elementId.ToLower()
            
            #line default
            #line hidden
, 2211), false)
);

WriteLiteral(">");

            
            #line 55 "..\..\Views\Shared\ValidationSummary.cshtml"
                                                              Write(modelError.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 56 "..\..\Views\Shared\ValidationSummary.cshtml"
                        }
                    }
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n");

WriteLiteral("        ");

            
            #line 61 "..\..\Views\Shared\ValidationSummary.cshtml"
   Write(Html.Hidden("acceptWarnings", @hasWarnings));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
