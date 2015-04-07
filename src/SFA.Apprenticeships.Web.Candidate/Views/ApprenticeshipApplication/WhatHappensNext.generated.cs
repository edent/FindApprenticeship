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

namespace SFA.Apprenticeships.Web.Candidate.Views.ApprenticeshipApplication
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ApprenticeshipApplication/WhatHappensNext.cshtml")]
    public partial class WhatHappensNext : System.Web.Mvc.WebViewPage<SFA.Apprenticeships.Web.Candidate.ViewModels.Applications.WhatHappensNextViewModel>
    {
        public WhatHappensNext()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\ApprenticeshipApplication\WhatHappensNext.cshtml"
  
    ViewBag.Title = "Apprenticeship application submitted - Find an apprenticeship";
    Layout = "~/Views/Shared/_Layout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"progress-indicator progress-indicator-horizontal\"");

WriteLiteral(">\r\n    <ul>\r\n        <li>1. Application form</li>\r\n        <li>2. Check your appl" +
"ication</li>\r\n        <li");

WriteLiteral(" class=\"active\"");

WriteLiteral(">3. Submitted</li>\r\n    </ul>\r\n</div>\r\n<div");

WriteLiteral(" class=\"success-banner\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">\r\n    <h1");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-check\"");

WriteLiteral("></i>Apprenticeship application submitted</h1>\r\n    <div>\r\n        You\'ve applied" +
" for:\r\n        <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">");

            
            #line 17 "..\..\Views\ApprenticeshipApplication\WhatHappensNext.cshtml"
                              Write(Html.DisplayFor(m => m.VacancyTitle));

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 17 "..\..\Views\ApprenticeshipApplication\WhatHappensNext.cshtml"
                                                                      Write(Html.DisplayFor(m => m.VacancyReference));

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n    </div>\r\n</div>\r\n");

            
            #line 20 "..\..\Views\ApprenticeshipApplication\WhatHappensNext.cshtml"
 if (Model.SentEmail)
{

            
            #line default
            #line hidden
WriteLiteral("    <section");

WriteLiteral(" class=\"section-border\"");

WriteLiteral(">\r\n        <p>\r\n            <i");

WriteLiteral(" class=\"fa fa-envelope-o\"");

WriteLiteral("></i>We\'ve sent you an email confirming your application\r\n        </p>\r\n    </sec" +
"tion>\r\n");

            
            #line 27 "..\..\Views\ApprenticeshipApplication\WhatHappensNext.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <section");

WriteLiteral(" class=\"section-border\"");

WriteLiteral(">\r\n        <p");

WriteLiteral(" class=\"text\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"fa fa-envelope-o\"");

WriteLiteral("></i>If you\'d like to receive email confirmation of applications, you can turn no" +
"tifications on in the <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1224), Tuple.Create("\"", 1274)
            
            #line 32 "..\..\Views\ApprenticeshipApplication\WhatHappensNext.cshtml"
                                                                       , Tuple.Create(Tuple.Create("", 1231), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(CandidateRouteNames.Settings)
            
            #line default
            #line hidden
, 1231), false)
);

WriteLiteral(">settings</a> section in your account.\r\n        </p>\r\n    </section>\r\n");

            
            #line 35 "..\..\Views\ApprenticeshipApplication\WhatHappensNext.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">What happens next</h2>\r\n<div");

WriteLiteral(" class=\"text form-group\"");

WriteLiteral(">\r\n    <p>\r\n        You’ll be contacted if you’ve been shortlisted for an intervi" +
"ew. If you\r\n        haven’t been successful the training provider will let you k" +
"now and\r\n        give you feedback.\r\n    </p>\r\n    <p>\r\n        You can also <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1669), Tuple.Create("\"", 1725)
            
            #line 45 "..\..\Views\ApprenticeshipApplication\WhatHappensNext.cshtml"
, Tuple.Create(Tuple.Create("", 1676), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(CandidateRouteNames.MyApplications)
            
            #line default
            #line hidden
, 1676), false)
);

WriteLiteral(">track the progress of your application</a> at any time.</p>\r\n    <p>\r\n        If" +
" you need to contact us about your application, don’t forget to quote\r\n        t" +
"he reference number.\r\n    </p>\r\n    <p>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1938), Tuple.Create("\"", 1963)
            
            #line 51 "..\..\Views\ApprenticeshipApplication\WhatHappensNext.cshtml"
, Tuple.Create(Tuple.Create("", 1945), Tuple.Create<System.Object, System.Int32>(Model.FeedbackUrl
            
            #line default
            #line hidden
, 1945), false)
);

WriteLiteral(" rel=\"external\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">What did you think of the service?</a>\r\n    </p>\r\n    <p>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2065), Tuple.Create("\"", 2144)
            
            #line 54 "..\..\Views\ApprenticeshipApplication\WhatHappensNext.cshtml"
, Tuple.Create(Tuple.Create("", 2072), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(RouteNames.SignOut, new { returnUrl = Model.FeedbackUrl })
            
            #line default
            #line hidden
, 2072), false)
);

WriteLiteral(">Finished with this service. Sign out and give feedback</a>\r\n    </p>\r\n</div>\r\n<d" +
"iv");

WriteLiteral(" class=\"form-group form-group-compound get-started\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" role=\"button\"");

WriteLiteral(" class=\"button\"");

WriteAttribute("href", Tuple.Create(" href=\'", 2317), Tuple.Create("\'", 2379)
            
            #line 58 "..\..\Views\ApprenticeshipApplication\WhatHappensNext.cshtml"
, Tuple.Create(Tuple.Create("", 2324), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(CandidateRouteNames.ApprenticeshipSearch)
            
            #line default
            #line hidden
, 2324), false)
);

WriteLiteral(">Find an apprenticeship</a>\r\n</div>\r\n<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

            
            #line 61 "..\..\Views\ApprenticeshipApplication\WhatHappensNext.cshtml"
    
            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\ApprenticeshipApplication\WhatHappensNext.cshtml"
     if (ViewBag.SearchReturnUrl != null)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" class=\"text\"");

WriteLiteral(">\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2533), Tuple.Create("\"", 2564)
            
            #line 64 "..\..\Views\ApprenticeshipApplication\WhatHappensNext.cshtml"
, Tuple.Create(Tuple.Create("", 2540), Tuple.Create<System.Object, System.Int32>(ViewBag.SearchReturnUrl
            
            #line default
            #line hidden
, 2540), false)
);

WriteLiteral(" title=\"Return to search results\"");

WriteLiteral(" id=\"lnk-return-search-results\"");

WriteLiteral(">Return to search results</a>\r\n        </p>\r\n");

            
            #line 66 "..\..\Views\ApprenticeshipApplication\WhatHappensNext.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
