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

namespace SFA.Apprenticeships.Web.Manage.Views.Shared.EditorTemplates
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/EditorTemplates/Comment.cshtml")]
    public partial class Comment_ : System.Web.Mvc.WebViewPage<string>
    {
        public Comment_()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\EditorTemplates\Comment.cshtml"
  
    var state = string.IsNullOrWhiteSpace(Model) ? string.Empty : "open";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<style>\r\n    .qa-comment {\r\n        background: yellow;\r\n        padding: 20p" +
"x;   \r\n    }\r\n</style>\r\n<details ");

            
            #line 13 "..\..\Views\Shared\EditorTemplates\Comment.cshtml"
    Write(state);

            
            #line default
            #line hidden
WriteLiteral(">\r\n    <summary>Comment</summary>\r\n    <div");

WriteLiteral(" class=\"detail-content qa-comment\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"blocklabel-single-container\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 17 "..\..\Views\Shared\EditorTemplates\Comment.cshtml"
       Write(Html.FormTextAreaFor(m => m, controlHtmlAttributes: new { @class = "width-all-1-1 form-textarea-medium", type = "text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n</details>");

        }
    }
}
#pragma warning restore 1591
