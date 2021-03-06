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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/DisplayTemplates/Application/Education.cshtml")]
    public partial class Education : System.Web.Mvc.WebViewPage<SFA.Apprenticeships.Web.Raa.Common.ViewModels.Application.EducationViewModel>
    {
        public Education()
        {
        }
        public override void Execute()
        {
WriteLiteral("<fieldset");

WriteLiteral(" class=\"fieldset-with-border\"");

WriteLiteral(">\r\n    <legend");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">\r\n        Education\r\n    </legend>\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" for=\"school-name\"");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Name of most recent school/college</label>\r\n        <span");

WriteLiteral(" class=\"form-prepopped\"");

WriteLiteral(" id=\"school-name\"");

WriteLiteral(">");

            
            #line 9 "..\..\Views\Shared\DisplayTemplates\Application\Education.cshtml"
                                                  Write(Model == null ? "-" : Model.Institution ?? "-");

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"inline-fixed\"");

WriteLiteral(">\r\n        <p");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Years attended</p>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"school-from\"");

WriteLiteral(" class=\"form-hint\"");

WriteLiteral(">Started</label>\r\n            <span");

WriteLiteral(" class=\"form-prepopped\"");

WriteLiteral(" id=\"school-from\"");

WriteLiteral(">");

            
            #line 15 "..\..\Views\Shared\DisplayTemplates\Application\Education.cshtml"
                                                      Write(Model == null ? "-" : Model.FromYear == 0 ? "-" : Model.FromYear.ToString());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"school-to\"");

WriteLiteral(" class=\"form-hint\"");

WriteLiteral(">Finished</label>\r\n            <span");

WriteLiteral(" class=\"form-prepopped\"");

WriteLiteral(" id=\"school-to\"");

WriteLiteral(">");

            
            #line 19 "..\..\Views\Shared\DisplayTemplates\Application\Education.cshtml"
                                                    Write(Model == null ? "-" : Model.ToYear == 0 ? "-" : Model.ToYear.ToString());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n</fieldset>");

        }
    }
}
#pragma warning restore 1591
