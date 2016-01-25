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

namespace SFA.Apprenticeships.Web.Candidate.Views.Shared
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_ErrorLayout.cshtml")]
    public partial class ErrorLayout : System.Web.Mvc.WebViewPage<dynamic>
    {
        public ErrorLayout()
        {
        }
        public override void Execute()
        {
WriteLiteral("<!DOCTYPE html>\r\n<!--[if lt IE 7]><html class=\"no-js lt-ie9 lt-ie8 lt-ie7\"><![end" +
"if]-->\r\n<!--[if IE 7]><html class=\"no-js lt-ie9 lt-ie8\"><![endif]-->\r\n<!--[if IE" +
" 8]><html class=\"no-js lt-ie9\"><![endif]-->\r\n<!--[if gt IE 8]><!-->\r\n<html");

WriteLiteral(" lang=\"en-GB\"");

WriteLiteral(" class=\"not-ie8\"");

WriteLiteral(">\r\n<!--<![endif]-->\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(">\r\n    <title>");

            
            #line 11 "..\..\Views\Shared\_ErrorLayout.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"ROBOTS\"");

WriteLiteral(" content=\"NOINDEX, NOFOLLOW\"");

WriteLiteral(">\r\n    <!--[if gt IE 8]><!-->");

            
            #line 14 "..\..\Views\Shared\_ErrorLayout.cshtml"
                     Write(Styles.Render("~/bundles/not-ie8"));

            
            #line default
            #line hidden
WriteLiteral("<!--<![endif]-->\r\n    <!--[if lte IE 8]>");

            
            #line 15 "..\..\Views\Shared\_ErrorLayout.cshtml"
                 Write(Styles.Render("~/bundles/ie8"));

            
            #line default
            #line hidden
WriteLiteral("<![endif]-->\r\n    <link");

WriteLiteral(" rel=\"shortcut icon\"");

WriteAttribute("href", Tuple.Create(" href=\"", 718), Tuple.Create("\"", 753)
            
            #line 16 "..\..\Views\Shared\_ErrorLayout.cshtml"
, Tuple.Create(Tuple.Create("", 725), Tuple.Create<System.Object, System.Int32>(Url.CdnImage("favicon.ico")
            
            #line default
            #line hidden
, 725), false)
);

WriteLiteral(" type=\"image/x-icon\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 17 "..\..\Views\Shared\_ErrorLayout.cshtml"
Write(Styles.Render("~/bundles/font-awesome"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 18 "..\..\Views\Shared\_ErrorLayout.cshtml"
Write(Html.Partial("_Scripts"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</head>\r\n<body>\r\n    <div");

WriteLiteral(" class=\"skiplink-container\"");

WriteLiteral(">\r\n        <div>\r\n            <a");

WriteLiteral(" href=\"#main\"");

WriteLiteral(" class=\"skiplink\"");

WriteLiteral(">Skip to main content</a>\r\n        </div>\r\n    </div>\r\n    <header");

WriteLiteral(" role=\"banner\"");

WriteLiteral(" class=\"global-header\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"global-header__wrapper\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"global-header__logo\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" href=\"http://gov.uk\"");

WriteLiteral(" title=\"Go to the GOV.UK homepage\"");

WriteLiteral(" class=\"govuk-logo\"");

WriteLiteral(">\r\n                    <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1285), Tuple.Create("\"", 1333)
            
            #line 30 "..\..\Views\Shared\_ErrorLayout.cshtml"
, Tuple.Create(Tuple.Create("", 1291), Tuple.Create<System.Object, System.Int32>(Url.CdnImage("gov.uk_logotype_crown.png")
            
            #line default
            #line hidden
, 1291), false)
);

WriteLiteral(" alt=\"Crown\"");

WriteLiteral(">\r\n                    GOV.UK\r\n                </a>\r\n            </div>\r\n        " +
"    <div");

WriteLiteral(" class=\"global-header__nav\"");

WriteLiteral(">\r\n                <h2");

WriteLiteral(" class=\"global-header__title beta\"");

WriteLiteral(">");

            
            #line 35 "..\..\Views\Shared\_ErrorLayout.cshtml"
                                                 Write(ViewBag.UserJourneyMainCaption);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n            </div>\r\n        </div>\r\n    </header>\r\n    <div");

WriteLiteral(" class=\"content-container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"phase-notice gov-border\"");

WriteLiteral(">\r\n  \r\n        </div>\r\n        <main");

WriteLiteral(" role=\"main\"");

WriteLiteral(" id=\"main\"");

WriteLiteral(">\r\n            <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">");

            
            #line 44 "..\..\Views\Shared\_ErrorLayout.cshtml"
                                  Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n            <div");

WriteLiteral(" class=\"text\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 46 "..\..\Views\Shared\_ErrorLayout.cshtml"
           Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </main>\r\n    </div>\r\n\r\n    <footer");

WriteLiteral(" class=\"gov-border\"");

WriteLiteral(" role=\"contentinfo\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"footer__wrapper\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"footer__meta\"");

WriteLiteral(">\r\n                <ul");

WriteLiteral(" class=\"footer__nav\"");

WriteLiteral(" role=\"navigation\"");

WriteLiteral(">\r\n                    <li");

WriteLiteral(" class=\"footer__link\"");

WriteLiteral("><a");

WriteLiteral(" href=\"/helpdesk\"");

WriteLiteral(">Helpdesk</a></li>\r\n                    <li");

WriteLiteral(" class=\"footer__link\"");

WriteLiteral("><a");

WriteLiteral(" href=\"/privacy\"");

WriteLiteral(">Privacy and cookies</a></li>\r\n                    <li");

WriteLiteral(" class=\"footer__link\"");

WriteLiteral("><a");

WriteLiteral(" href=\"/terms\"");

WriteLiteral(">Terms and conditions</a></li>\r\n                    <li");

WriteLiteral(" class=\"footer__link\"");

WriteLiteral(">Built by the <a");

WriteLiteral(" href=\"http://gov.uk/sfa\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">Skills Funding Agency</a></li>\r\n                    <li");

WriteLiteral(" class=\"footer__ogl\"");

WriteLiteral("><a");

WriteLiteral(" href=\"http://www.nationalarchives.gov.uk/doc/open-government-licence/version/2\"");

WriteLiteral(" class=\"ir ogl-logo\"");

WriteLiteral(">OGL</a>All content is available under the <a");

WriteLiteral(" href=\"http://www.nationalarchives.gov.uk/doc/open-government-licence/version/2\"");

WriteLiteral(">Open Government Licence v2.0</a>, except where otherwise stated</li>\r\n          " +
"      </ul>\r\n                <a");

WriteLiteral(" class=\"footer__copyright\"");

WriteLiteral(" href=\"http://www.nationalarchives.gov.uk/information-management/our-services/cro" +
"wn-copyright.htm\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">\r\n                    <img");

WriteAttribute("src", Tuple.Create(" src=\"", 3070), Tuple.Create("\"", 3111)
            
            #line 62 "..\..\Views\Shared\_ErrorLayout.cshtml"
, Tuple.Create(Tuple.Create("", 3076), Tuple.Create<System.Object, System.Int32>(Url.CdnImage("govuk-crest-2x.png")
            
            #line default
            #line hidden
, 3076), false)
);

WriteLiteral(" width=\"125\"");

WriteLiteral(" height=\"102\"");

WriteLiteral(" alt=\"Crown copyright logo\"");

WriteLiteral(">\r\n                    <p>&copy; Crown copyright</p>\r\n                </a>\r\n     " +
"       </div>\r\n        </div>\r\n    </footer>\r\n\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591
