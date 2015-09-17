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

namespace SFA.Apprenticeships.Web.Candidate.Views.TraineeshipApplication
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
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Login;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Register;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.VacancySearch;
    using SFA.Apprenticeships.Web.Common.Constants;
    using SFA.Apprenticeships.Web.Common.Framework;
    using SFA.Apprenticeships.Web.Common.Models.Common;
    using SFA.Apprenticeships.Web.Common.ViewModels.Locations;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/TraineeshipApplication/WhatHappensNext.cshtml")]
    public partial class WhatHappensNext : System.Web.Mvc.WebViewPage<SFA.Apprenticeships.Web.Candidate.ViewModels.Applications.WhatHappensNextTraineeshipViewModel>
    {
        public WhatHappensNext()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\TraineeshipApplication\WhatHappensNext.cshtml"
  
    ViewBag.Title = "Traineeship application submitted - Find a traineeship";
    Layout = "~/Views/Shared/_Layout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"success-banner\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">\r\n    <h1");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-check\"");

WriteLiteral("></i>Traineeship application submitted</h1>\r\n    <div>\r\n        You\'ve applied fo" +
"r:\r\n        <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">");

            
            #line 11 "..\..\Views\TraineeshipApplication\WhatHappensNext.cshtml"
                              Write(Html.DisplayFor(m => m.VacancyTitle));

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 11 "..\..\Views\TraineeshipApplication\WhatHappensNext.cshtml"
                                                                      Write(Html.DisplayFor(m => m.VacancyReference));

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n    </div>\r\n</div>\r\n<section");

WriteLiteral(" class=\"section-border\"");

WriteLiteral(">\r\n    <p>\r\n        <i");

WriteLiteral(" class=\"fa fa-envelope-o\"");

WriteLiteral("></i>We\'ve sent you an email confirming your application\r\n    </p>\r\n</section>\r\n<" +
"section");

WriteLiteral(" class=\"section-border\"");

WriteLiteral(">\r\n    <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">What happens next</h2>\r\n    <div");

WriteLiteral(" class=\"text form-group\"");

WriteLiteral(">\r\n        <p>\r\n            You’ll be contacted if you’re eligible for a trainees" +
"hip. You can see the applications you\'ve made by visiting <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1002), Tuple.Create("\"", 1058)
            
            #line 23 "..\..\Views\TraineeshipApplication\WhatHappensNext.cshtml"
                                                    , Tuple.Create(Tuple.Create("", 1009), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(CandidateRouteNames.MyApplications)
            
            #line default
            #line hidden
, 1009), false)
);

WriteLiteral(">my applications</a>.\r\n        </p>\r\n        <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(">Training provider</h3>\r\n        <p>");

            
            #line 26 "..\..\Views\TraineeshipApplication\WhatHappensNext.cshtml"
      Write(Model.ProviderContactInfo);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"form-group form-group-compound get-started\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" role=\"button\"");

WriteLiteral(" class=\"button\"");

WriteAttribute("href", Tuple.Create(" href=\'", 1310), Tuple.Create("\'", 1369)
            
            #line 29 "..\..\Views\TraineeshipApplication\WhatHappensNext.cshtml"
, Tuple.Create(Tuple.Create("", 1317), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(CandidateRouteNames.TraineeshipSearch)
            
            #line default
            #line hidden
, 1317), false)
);

WriteLiteral(">Find a traineeship</a>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

            
            #line 32 "..\..\Views\TraineeshipApplication\WhatHappensNext.cshtml"
        
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\TraineeshipApplication\WhatHappensNext.cshtml"
         if (ViewBag.SearchReturnUrl != null)
        {

            
            #line default
            #line hidden
WriteLiteral("            <p");

WriteLiteral(" class=\"text\"");

WriteLiteral(">\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1543), Tuple.Create("\"", 1574)
            
            #line 35 "..\..\Views\TraineeshipApplication\WhatHappensNext.cshtml"
, Tuple.Create(Tuple.Create("", 1550), Tuple.Create<System.Object, System.Int32>(ViewBag.SearchReturnUrl
            
            #line default
            #line hidden
, 1550), false)
);

WriteLiteral(" title=\"Return to search results\"");

WriteLiteral(" id=\"lnk-return-search-results\"");

WriteLiteral(">Return to search results</a>\r\n            </p>\r\n");

            
            #line 37 "..\..\Views\TraineeshipApplication\WhatHappensNext.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</section>\r\n\r\n<div");

WriteLiteral(" class=\"text form-group\"");

WriteLiteral(">\r\n    <p>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1775), Tuple.Create("\"", 1802)
            
            #line 43 "..\..\Views\TraineeshipApplication\WhatHappensNext.cshtml"
, Tuple.Create(Tuple.Create("", 1782), Tuple.Create<System.Object, System.Int32>(ViewBag.FeedbackUrl
            
            #line default
            #line hidden
, 1782), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" rel=\"external\"");

WriteLiteral(">What did you think of this service?</a>\r\n        <br>(30 second survey, this wil" +
"l open in a new tab)\r\n    </p>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
