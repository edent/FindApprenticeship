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
    using SFA.Apprenticeships.Web.Candidate;
    
    #line 1 "..\..\Views\Shared\_Layout.cshtml"
    using SFA.Apprenticeships.Web.Candidate.Attributes;
    
    #line default
    #line hidden
    using SFA.Apprenticeships.Web.Candidate.Constants;
    using SFA.Apprenticeships.Web.Candidate.Constants.ViewModels;
    
    #line 2 "..\..\Views\Shared\_Layout.cshtml"
    using SFA.Apprenticeships.Web.Candidate.Controllers;
    
    #line default
    #line hidden
    using SFA.Apprenticeships.Web.Candidate.Helpers;
    using SFA.Apprenticeships.Web.Candidate.ViewModels;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Candidate;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Locations;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Login;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Register;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.VacancySearch;
    using SFA.Apprenticeships.Web.Common.Constants;
    
    #line 3 "..\..\Views\Shared\_Layout.cshtml"
    using SFA.Apprenticeships.Web.Common.Framework;
    
    #line default
    #line hidden
    using SFA.Apprenticeships.Web.Common.Models.Common;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Layout.cshtml")]
    public partial class Layout : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Layout()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<!DOCTYPE html>\r\n<!--[if lt IE 7]><html class=\"no-js lt-ie9 lt-ie8 lt-ie7\"><![e" +
"ndif]-->\r\n<!--[if IE 7]><html class=\"no-js lt-ie9 lt-ie8\"><![endif]-->\r\n<!--[if " +
"IE 8]><html class=\"no-js lt-ie9\"><![endif]-->\r\n<!--[if gt IE 8]><!-->\r\n<html");

WriteLiteral(" lang=\"en-GB\"");

WriteLiteral(" class=\"no-js not-ie8\"");

WriteLiteral(">\r\n<!--<![endif]-->\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(">\r\n    <title>");

            
            #line 15 "..\..\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <meta");

WriteLiteral(" name=\"description\"");

WriteLiteral(" content=\"We’ve introduced a new way to find and apply for an apprenticeship in E" +
"ngland.\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"format-detection\"");

WriteLiteral(" content=\"telephone=no\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"format-detection\"");

WriteLiteral(" content=\"date=no\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"format-detection\"");

WriteLiteral(" content=\"address=no\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"DCSext.Authenticated\"");

WriteAttribute("content", Tuple.Create(" content=\"", 980), Tuple.Create("\"", 1031)
            
            #line 21 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 990), Tuple.Create<System.Object, System.Int32>(Request.IsAuthenticated ? "Yes" : "No"
            
            #line default
            #line hidden
, 990), false)
);

WriteLiteral(" />\r\n");

            
            #line 22 "..\..\Views\Shared\_Layout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Shared\_Layout.cshtml"
     if (ViewBag.ShouldRobotsIndexPage)
    {

            
            #line default
            #line hidden
WriteLiteral("        <meta");

WriteLiteral(" name=\"ROBOTS\"");

WriteLiteral(" content=\"NOFOLLOW\"");

WriteLiteral(">\r\n");

            
            #line 25 "..\..\Views\Shared\_Layout.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <meta");

WriteLiteral(" name=\"ROBOTS\"");

WriteLiteral(" content=\"NOFOLLOW,NOINDEX\"");

WriteLiteral(">\r\n");

            
            #line 29 "..\..\Views\Shared\_Layout.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 30 "..\..\Views\Shared\_Layout.cshtml"
Write(RenderSection("metatags", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <!--[if gt IE 8]><!-->");

            
            #line 31 "..\..\Views\Shared\_Layout.cshtml"
                     Write(Styles.Render(Url.CdnContent("css/main-1.13.2.css", "~/Content/_assets")));

            
            #line default
            #line hidden
WriteLiteral("<!--<![endif]-->\r\n    <!--[if lte IE 8]>");

            
            #line 32 "..\..\Views\Shared\_Layout.cshtml"
                 Write(Styles.Render(Url.CdnContent("css/main-ie8-1.13.2.css", "~/Content/_assets")));

            
            #line default
            #line hidden
WriteLiteral("<![endif]-->\r\n    <!--[if lte IE 8]>");

            
            #line 33 "..\..\Views\Shared\_Layout.cshtml"
                 Write(Styles.Render(Url.CdnContent("css/fonts-ie8.css", "~/Content/_assets")));

            
            #line default
            #line hidden
WriteLiteral("<![endif]-->\r\n    <!--[if gte IE 9]><!-->");

            
            #line 34 "..\..\Views\Shared\_Layout.cshtml"
                      Write(Styles.Render(Url.CdnContent("css/fonts.css", "~/Content/_assets")));

            
            #line default
            #line hidden
WriteLiteral("<!--<![endif]-->\r\n    <link");

WriteLiteral(" rel=\"shortcut icon\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1743), Tuple.Create("\"", 1805)
            
            #line 35 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 1750), Tuple.Create<System.Object, System.Int32>(Url.CdnContent("img/favicon.ico", "~/Content/_assets")
            
            #line default
            #line hidden
, 1750), false)
);

WriteLiteral(" type=\"image/x-icon\"");

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon-precomposed\"");

WriteLiteral(" sizes=\"152x152\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1889), Tuple.Create("\"", 1968)
            
            #line 36 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 1896), Tuple.Create<System.Object, System.Int32>(Url.CdnContent("img/apple-touch-icon-152x152.png", "~/Content/_assets")
            
            #line default
            #line hidden
, 1896), false)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon-precomposed\"");

WriteLiteral(" sizes=\"120x120\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2032), Tuple.Create("\"", 2111)
            
            #line 37 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 2039), Tuple.Create<System.Object, System.Int32>(Url.CdnContent("img/apple-touch-icon-120x120.png", "~/Content/_assets")
            
            #line default
            #line hidden
, 2039), false)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon-precomposed\"");

WriteLiteral(" sizes=\"76x76\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2173), Tuple.Create("\"", 2250)
            
            #line 38 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 2180), Tuple.Create<System.Object, System.Int32>(Url.CdnContent("img/apple-touch-icon-76x76.png", "~/Content/_assets")
            
            #line default
            #line hidden
, 2180), false)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon-precomposed\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2298), Tuple.Create("\"", 2375)
            
            #line 39 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 2305), Tuple.Create<System.Object, System.Int32>(Url.CdnContent("img/apple-touch-icon-60x60.png", "~/Content/_assets")
            
            #line default
            #line hidden
, 2305), false)
);

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 40 "..\..\Views\Shared\_Layout.cshtml"
Write(Styles.Render(Url.CdnContent("css/font-awesome/css/font-awesome.min.css", "~/Content/_assets")));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 41 "..\..\Views\Shared\_Layout.cshtml"
Write(Html.Partial("_Scripts"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</head>\r\n<body>\r\n");

            
            #line 44 "..\..\Views\Shared\_Layout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\Shared\_Layout.cshtml"
     if (ViewBag.ShowEuCookieDirective == true)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"global-cookie-message\"");

WriteLiteral(" class=\"cookie-banner\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"content-container\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"copy-16\"");

WriteLiteral(">GOV.UK uses cookies to make the site simpler. <a");

WriteAttribute("href", Tuple.Create(" href=\'", 2793), Tuple.Create("\'", 2842)
            
            #line 48 "..\..\Views\Shared\_Layout.cshtml"
             , Tuple.Create(Tuple.Create("", 2800), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(CandidateRouteNames.Privacy)
            
            #line default
            #line hidden
, 2800), false)
);

WriteLiteral(">Find out more about cookies</a></span>\r\n            </div>\r\n        </div>\r\n");

            
            #line 51 "..\..\Views\Shared\_Layout.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 53 "..\..\Views\Shared\_Layout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 53 "..\..\Views\Shared\_Layout.cshtml"
     if (!string.IsNullOrEmpty(ViewBag.PlannedOutageMessage))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"planned-outage-message\"");

WriteLiteral(" class=\"maintenance-banner\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"content-container\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"font-xsmall maintenance-content\"");

WriteLiteral(">\r\n                    <div>");

            
            #line 58 "..\..\Views\Shared\_Layout.cshtml"
                    Write(Html.Raw(ViewBag.PlannedOutageMessage));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3284), Tuple.Create("\"", 3374)
            
            #line 59 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 3291), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(RouteNames.DismissPlannedOutageMessage, new { isJavascript = false })
            
            #line default
            #line hidden
, 3291), false)
);

WriteLiteral(" class=\"maintenance-close\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" id=\"dismiss-planned-outage-message\"");

WriteLiteral(" class=\"icon-black fa fa-times-circle\"");

WriteLiteral("></i>\r\n                    </a>\r\n                </div>\r\n            </div>\r\n    " +
"    </div>\r\n");

            
            #line 65 "..\..\Views\Shared\_Layout.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

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

WriteAttribute("src", Tuple.Create(" src=\"", 4020), Tuple.Create("\"", 4095)
            
            #line 76 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 4026), Tuple.Create<System.Object, System.Int32>(Url.CdnContent("img/gov.uk_logotype_crown.png", "~/Content/_assets")
            
            #line default
            #line hidden
, 4026), false)
);

WriteLiteral(" alt=\"Crown\"");

WriteLiteral(">\r\n                    GOV.UK\r\n                </a>\r\n            </div>\r\n        " +
"    ");

WriteLiteral("\r\n");

            
            #line 81 "..\..\Views\Shared\_Layout.cshtml"
            
            
            #line default
            #line hidden
            
            #line 81 "..\..\Views\Shared\_Layout.cshtml"
             if (ViewBag.UserJourney == UserJourney.Apprenticeship)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"global-header__nav\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" id=\"global-header-title\"");

WriteLiteral(" class=\"global-header__title\"");

WriteLiteral("><a");

WriteLiteral(" id=\"headerLinkFAA\"");

WriteAttribute("href", Tuple.Create(" href=\"", 4466), Tuple.Create("\"", 4528)
            
            #line 84 "..\..\Views\Shared\_Layout.cshtml"
                           , Tuple.Create(Tuple.Create("", 4473), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(CandidateRouteNames.ApprenticeshipSearch)
            
            #line default
            #line hidden
, 4473), false)
);

WriteLiteral(">Find an apprenticeship</a></div>\r\n                </div>\r\n");

            
            #line 86 "..\..\Views\Shared\_Layout.cshtml"
            }
            else if (ViewBag.UserJourney == UserJourney.Traineeship)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"global-header__nav\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" id=\"global-header-title\"");

WriteLiteral(" class=\"global-header__title\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 4819), Tuple.Create("\"", 4878)
            
            #line 90 "..\..\Views\Shared\_Layout.cshtml"
        , Tuple.Create(Tuple.Create("", 4826), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(CandidateRouteNames.TraineeshipSearch)
            
            #line default
            #line hidden
, 4826), false)
);

WriteLiteral(">Find a traineeship</a></div>\r\n                </div>\r\n");

            
            #line 92 "..\..\Views\Shared\_Layout.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </header>\r\n    <div");

WriteLiteral(" class=\"content-container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"fixed-container\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"banner-container\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"phase-notice gov-border grid-wrapper\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"grid grid-1-2\"");

WriteLiteral(">\r\n                        &nbsp;\r\n                    </div>\r\n                  " +
"  <div");

WriteLiteral(" class=\"grid grid-1-2\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 103 "..\..\Views\Shared\_Layout.cshtml"
                   Write(Html.Partial("_LoginPartial"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n       " +
" </div>\r\n        <main");

WriteLiteral(" role=\"main\"");

WriteLiteral(" id=\"main\"");

WriteLiteral(">\r\n");

            
            #line 109 "..\..\Views\Shared\_Layout.cshtml"
            
            
            #line default
            #line hidden
            
            #line 109 "..\..\Views\Shared\_Layout.cshtml"
              
                var controller = ViewContext.Controller as CandidateControllerBase;

                if (controller != null)
                {
                    var infoMessage = controller.UserData.Pop(UserMessageConstants.InfoMessage);
                    var successMessage = controller.UserData.Pop(UserMessageConstants.SuccessMessage);
                    var warningMessage = controller.UserData.Pop(UserMessageConstants.WarningMessage);
                    var errorMessage = controller.UserData.Pop(UserMessageConstants.ErrorMessage);

                    if (infoMessage != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" class=\"panel-info\"");

WriteLiteral(">\r\n                            <p");

WriteLiteral(" id=\"InfoMessageText\"");

WriteLiteral(">");

            
            #line 122 "..\..\Views\Shared\_Layout.cshtml"
                                               Write(Html.Raw(infoMessage));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                        </div>\r\n");

            
            #line 124 "..\..\Views\Shared\_Layout.cshtml"
                    }
                    if (successMessage != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" class=\"panel-success\"");

WriteLiteral(">\r\n                            <p");

WriteLiteral(" id=\"SuccessMessageText\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-check\"");

WriteLiteral("></i>");

            
            #line 128 "..\..\Views\Shared\_Layout.cshtml"
                                                                             Write(Html.Raw(successMessage));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                        </div>\r\n");

            
            #line 130 "..\..\Views\Shared\_Layout.cshtml"
                    }
                    if (warningMessage != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" class=\"panel-warning\"");

WriteLiteral(">\r\n                            <p");

WriteLiteral(" id=\"WarningMessageText\"");

WriteLiteral(">");

            
            #line 134 "..\..\Views\Shared\_Layout.cshtml"
                                                  Write(Html.Raw(warningMessage));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                        </div>\r\n");

            
            #line 136 "..\..\Views\Shared\_Layout.cshtml"
                    }
                    if (errorMessage != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" class=\"panel-danger\"");

WriteLiteral(">\r\n                            <p");

WriteLiteral(" id=\"ErrorMessageText\"");

WriteLiteral(">");

            
            #line 140 "..\..\Views\Shared\_Layout.cshtml"
                                                Write(Html.Raw(errorMessage));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                        </div>\r\n");

            
            #line 142 "..\..\Views\Shared\_Layout.cshtml"
                    }
                }
            
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 145 "..\..\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </main>\r\n");

            
            #line 147 "..\..\Views\Shared\_Layout.cshtml"
        
            
            #line default
            #line hidden
            
            #line 147 "..\..\Views\Shared\_Layout.cshtml"
         if (ViewBag.EnableWebTrends == true)
        {

            
            #line default
            #line hidden
WriteLiteral("            <noscript>\r\n                <img");

WriteLiteral(" alt=\"dcsimg\"");

WriteLiteral(" id=\"dcsimg\"");

WriteLiteral(" width=\"1\"");

WriteLiteral(" height=\"1\"");

WriteAttribute("src", Tuple.Create(" src=\"", 7429), Tuple.Create("\"", 7591)
, Tuple.Create(Tuple.Create("", 7435), Tuple.Create("//stats.matraxis.net/", 7435), true)
            
            #line 150 "..\..\Views\Shared\_Layout.cshtml"
             , Tuple.Create(Tuple.Create("", 7456), Tuple.Create<System.Object, System.Int32>(ViewBag.WebTrendsDscId
            
            #line default
            #line hidden
, 7456), false)
, Tuple.Create(Tuple.Create("", 7479), Tuple.Create("/njs.gif?dcsuri=/nojavascript&amp;WT.js=No&amp;WT.tv=10.4.11&amp;WT.dl=0&amp;dcss" +
"ip=", 7479), true)
            
            #line 150 "..\..\Views\Shared\_Layout.cshtml"
                                                                                                                        , Tuple.Create(Tuple.Create("", 7563), Tuple.Create<System.Object, System.Int32>(ViewBag.WebTrendsDomainName
            
            #line default
            #line hidden
, 7563), false)
);

WriteLiteral(" />\r\n            </noscript>\r\n");

            
            #line 152 "..\..\Views\Shared\_Layout.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n\r\n    <footer");

WriteLiteral(" class=\"gov-border\"");

WriteLiteral(" role=\"contentinfo\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"footer__wrapper\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"footer__meta\"");

WriteLiteral(">\r\n                <ul");

WriteLiteral(" class=\"footer__nav\"");

WriteLiteral(">\r\n                    <li");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" class=\"footer__link bold-medium\"");

WriteAttribute("href", Tuple.Create(" href=\'", 7930), Tuple.Create("\'", 7980)
            
            #line 160 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 7937), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(CandidateRouteNames.Helpdesk)
            
            #line default
            #line hidden
, 7937), false)
);

WriteLiteral(">Contact us</a>\r\n                        <a");

WriteLiteral(" class=\"footer__link bold-medium\"");

WriteAttribute("href", Tuple.Create(" href=\'", 8057), Tuple.Create("\'", 8107)
            
            #line 161 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 8064), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(CandidateRouteNames.Feedback)
            
            #line default
            #line hidden
, 8064), false)
);

WriteLiteral(">Give feedback</a>\r\n                    </li>\r\n                    <li");

WriteLiteral(" class=\"footer__link\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\'", 8202), Tuple.Create("\'", 8251)
            
            #line 163 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 8209), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(CandidateRouteNames.Privacy)
            
            #line default
            #line hidden
, 8209), false)
);

WriteLiteral(">Privacy and cookies</a></li>\r\n                    <li");

WriteLiteral(" class=\"footer__link\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\'", 8330), Tuple.Create("\'", 8377)
            
            #line 164 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 8337), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(CandidateRouteNames.Terms)
            
            #line default
            #line hidden
, 8337), false)
);

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

WriteAttribute("src", Tuple.Create(" src=\"", 9094), Tuple.Create("\"", 9162)
            
            #line 169 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 9100), Tuple.Create<System.Object, System.Int32>(Url.CdnContent("img/govuk-crest-2x.png", "~/Content/_assets")
            
            #line default
            #line hidden
, 9100), false)
);

WriteLiteral(" width=\"125\"");

WriteLiteral(" height=\"102\"");

WriteLiteral(" alt=\"Crown copyright logo\"");

WriteLiteral(">\r\n                    <p>&copy; Crown copyright</p>\r\n                </a>\r\n     " +
"       </div>\r\n            <div");

WriteLiteral(" class=\"toggle-content hide-nojs show-print nobreak-print\"");

WriteLiteral(">\r\n                <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(">Contact the Skills Funding Agency helpdesk</h3>\r\n                <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">Telephone (free): 0800 015 0400</p>\r\n            </div>\r\n        </div>\r\n    </f" +
"ooter>\r\n\r\n");

            
            #line 180 "..\..\Views\Shared\_Layout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 180 "..\..\Views\Shared\_Layout.cshtml"
     if (ViewBag.ShowAbout != null && ViewBag.ShowAbout == true)
    {
        Html.RenderPartial("_about");
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <!-- Placed at the end of the document so the pages load faster -->\r\n");

WriteLiteral("    ");

            
            #line 186 "..\..\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/jquery"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 187 "..\..\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/fastclick"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 188 "..\..\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/underscore"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        if (typeof jQuery === \'undefined\') {\r\n            var e = document.cre" +
"ateElement(\"script\");\r\n\r\n            e.src = \'");

            
            #line 194 "..\..\Views\Shared\_Layout.cshtml"
                Write(Url.Content("~/Content/_assets/js/vendor/jquery-1.11.1.js"));

            
            #line default
            #line hidden
WriteLiteral(@"';
            e.type = ""text/javascript"";
            document.getElementsByTagName(""head"")[0].appendChild(e);
        }

        $(function () {
            $(""#dismiss-planned-outage-message"").click(function (event) {

                event.preventDefault();

                var request = $.ajax({
                    type: ""GET"",
                    url: '");

            
            #line 206 "..\..\Views\Shared\_Layout.cshtml"
                     Write(Url.RouteUrl(RouteNames.DismissPlannedOutageMessage, new { isJavascript = true }));

            
            #line default
            #line hidden
WriteLiteral("\'\r\n                });\r\n\r\n                request.done(function () {\r\n\r\n         " +
"           $(\"#planned-outage-message\").hide();\r\n\r\n                });\r\n        " +
"    });\r\n\r\n");

            
            #line 216 "..\..\Views\Shared\_Layout.cshtml"
            
            
            #line default
            #line hidden
            
            #line 216 "..\..\Views\Shared\_Layout.cshtml"
             if (ViewBag.SavedAndDraftCount != null)
        {

            
            #line default
            #line hidden
WriteLiteral("            ");

WriteLiteral("UpdateSavedAndDraftCount(");

            
            #line 218 "..\..\Views\Shared\_Layout.cshtml"
                                  Write(ViewBag.SavedAndDraftCount);

            
            #line default
            #line hidden
WriteLiteral(");\r\n");

            
            #line 219 "..\..\Views\Shared\_Layout.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 221 "..\..\Views\Shared\_Layout.cshtml"
            
            
            #line default
            #line hidden
            
            #line 221 "..\..\Views\Shared\_Layout.cshtml"
             if (ViewBag.ApplicationStatusChangeCount != null)
        {

            
            #line default
            #line hidden
WriteLiteral("            ");

WriteLiteral("UpdateApplicationStatusChangeCount(");

            
            #line 223 "..\..\Views\Shared\_Layout.cshtml"
                                            Write(ViewBag.ApplicationStatusChangeCount);

            
            #line default
            #line hidden
WriteLiteral(");\r\n");

            
            #line 224 "..\..\Views\Shared\_Layout.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("        });\r\n    </script>\r\n\r\n");

WriteLiteral("    ");

            
            #line 228 "..\..\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/nascript"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 229 "..\..\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/vendor"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 230 "..\..\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/nas"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 231 "..\..\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n    \r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591
