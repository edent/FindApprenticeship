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
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using SFA.Apprenticeships.Web.Common.Constants;
    using SFA.Apprenticeships.Web.Common.Framework;
    using SFA.Apprenticeships.Web.Common.Models.Common;
    using SFA.Apprenticeships.Web.Raa.Common.Views.Shared.DisplayTemplates;
    using SFA.Apprenticeships.Web.Raa.Common.Views.Shared.EditorTemplates;
    using SFA.Apprenticeships.Web.Recruit;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/VacancyPosting/_comment.cshtml")]
    public partial class comment : System.Web.Mvc.WebViewPage<SFA.Apprenticeships.Web.Raa.Common.ViewModels.Vacancy.CommentViewModel>
    {
        public comment()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n\r\n");

            
            #line 15 "..\..\Views\VacancyPosting\_comment.cshtml"
 if (Model.HasComment)
{

            
            #line default
            #line hidden
WriteLiteral("    <details");

WriteLiteral(" class=\"open\"");

WriteLiteral(" open>\r\n        <summary>");

            
            #line 18 "..\..\Views\VacancyPosting\_comment.cshtml"
            Write(Model.CommentLabel);

            
            #line default
            #line hidden
WriteLiteral("</summary>\r\n        <div");

WriteLiteral(" class=\"detail-content qa-comment\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"blocklabel-single-container preserve-formatting\"");

WriteLiteral(">");

            
            #line 20 "..\..\Views\VacancyPosting\_comment.cshtml"
                                                                    Write(Model.Comment);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        </div>\r\n    </details>\r\n");

            
            #line 23 "..\..\Views\VacancyPosting\_comment.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
