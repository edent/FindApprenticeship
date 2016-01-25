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
    using SFA.Apprenticeships.Infrastructure.Presentation;
    using SFA.Apprenticeships.Web.Candidate;
    using SFA.Apprenticeships.Web.Candidate.Constants;
    using SFA.Apprenticeships.Web.Candidate.Constants.ViewModels;
    using SFA.Apprenticeships.Web.Candidate.Helpers;
    using SFA.Apprenticeships.Web.Candidate.ViewModels;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Candidate;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Login;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Register;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.VacancySearch;
    using SFA.Apprenticeships.Web.Common.Constants;
    using SFA.Apprenticeships.Web.Common.Framework;
    using SFA.Apprenticeships.Web.Common.Models.Common;
    using SFA.Apprenticeships.Web.Common.ViewModels.Locations;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Register/MonitoringInformation.cshtml")]
    public partial class MonitoringInformation : System.Web.Mvc.WebViewPage<MonitoringInformationViewModel>
    {
        public MonitoringInformation()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Register\MonitoringInformation.cshtml"
  
    ViewBag.Title = "Tell us more about you - Find an apprenticeship";
    Layout = "~/Views/Shared/_Layout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">Tell us more about you</h2>\r\n<p");

WriteLiteral(" class=\"text\"");

WriteLiteral(">\r\n    Please give us a little more information about you. This will help us to\r\n" +
"    understand how effective the service is.\r\n</p>\r\n\r\n");

            
            #line 14 "..\..\Views\Register\MonitoringInformation.cshtml"
 using (Html.BeginRouteForm(RouteNames.MonitoringInformation, FormMethod.Post))
{
    
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Register\MonitoringInformation.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Register\MonitoringInformation.cshtml"
                            
    
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Register\MonitoringInformation.cshtml"
Write(Html.Partial("ValidationSummary", ViewData.ModelState));

            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Register\MonitoringInformation.cshtml"
                                                           
    
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Register\MonitoringInformation.cshtml"
Write(Html.EditorFor(m => m, "MonitoringInformation/_gender"));

            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Register\MonitoringInformation.cshtml"
                                                            
    
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Register\MonitoringInformation.cshtml"
Write(Html.EditorFor(m => m, "MonitoringInformation/_disability"));

            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Register\MonitoringInformation.cshtml"
                                                                
    
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Register\MonitoringInformation.cshtml"
Write(Html.EditorFor(m => m, "MonitoringInformation/_ethnicity"));

            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Register\MonitoringInformation.cshtml"
                                                               
    
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\Register\MonitoringInformation.cshtml"
Write(Html.EditorFor(m => m, "MonitoringInformation/_why"));

            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\Register\MonitoringInformation.cshtml"
                                                         


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <button");

WriteLiteral(" class=\"button\"");

WriteLiteral(" id=\"save-continue-button\"");

WriteLiteral(">Save and continue</button>\r\n        <p><a");

WriteAttribute("href", Tuple.Create(" href=\"", 932), Tuple.Create("\"", 990)
            
            #line 25 "..\..\Views\Register\MonitoringInformation.cshtml"
, Tuple.Create(Tuple.Create("", 939), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(RouteNames.SkipMonitoringInformation)
            
            #line default
            #line hidden
, 939), false)
);

WriteLiteral(" id=\"skip-link\"");

WriteLiteral(" class=\"button-link\"");

WriteLiteral(" title=\"Skip telling us more\"");

WriteLiteral(">Skip</a></p>\r\n    </div>\r\n");

            
            #line 27 "..\..\Views\Register\MonitoringInformation.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
