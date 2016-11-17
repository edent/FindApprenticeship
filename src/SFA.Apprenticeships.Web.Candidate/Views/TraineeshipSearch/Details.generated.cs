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

namespace SFA.Apprenticeships.Web.Candidate.Views.TraineeshipSearch
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
    using SFA.Apprenticeships.Web.Common.Views.Shared.DisplayTemplates;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/TraineeshipSearch/Details.cshtml")]
    public partial class Details : System.Web.Mvc.WebViewPage<TraineeshipVacancyDetailViewModel>
    {
        public Details()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\TraineeshipSearch\Details.cshtml"
  
    ViewBag.Title = Model.Title + " - Find a traineeship";
    Layout = "~/Views/Shared/_Layout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

DefineSection("metatags", () => {

WriteLiteral("\r\n    <meta");

WriteLiteral(" name=\"DCSext.Days2Close\"");

WriteAttribute("content", Tuple.Create(" content=\"", 214), Tuple.Create("\"", 319)
            
            #line 9 "..\..\Views\TraineeshipSearch\Details.cshtml"
, Tuple.Create(Tuple.Create("", 224), Tuple.Create<System.Object, System.Int32>((DateTime.SpecifyKind(Model.ClosingDate, DateTimeKind.Utc).Date - DateTime.UtcNow.Date).Days
            
            #line default
            #line hidden
, 224), false)
);

WriteLiteral("/>\r\n");

});

WriteLiteral("\r\n<div itemscope");

WriteLiteral(" itemtype=\"http://schema.org/JobPosting\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"hgroup text\"");

WriteLiteral(">\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(" id=\"vacancy-title\"");

WriteLiteral(" itemprop=\"title\"");

WriteLiteral(">");

            
            #line 16 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                          Write(HtmlExtensions.EscapeHtmlEncoding(Html, Model.Title));

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n                <p");

WriteLiteral(" class=\"subtitle\"");

WriteLiteral(" id=\"vacancy-subtitle-employer-name\"");

WriteLiteral(" itemprop=\"hiringOrganization\"");

WriteLiteral(">");

            
            #line 17 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                                                 Write(Model.EmployerName);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"column-one-third\"");

WriteLiteral(">\r\n");

            
            #line 21 "..\..\Views\TraineeshipSearch\Details.cshtml"
            
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\TraineeshipSearch\Details.cshtml"
             if (ViewBag.SearchReturnUrl != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 920), Tuple.Create("\"", 951)
            
            #line 23 "..\..\Views\TraineeshipSearch\Details.cshtml"
, Tuple.Create(Tuple.Create("", 927), Tuple.Create<System.Object, System.Int32>(ViewBag.SearchReturnUrl
            
            #line default
            #line hidden
, 927), false)
);

WriteLiteral(" title=\"Return to search results\"");

WriteLiteral(" class=\"page-link\"");

WriteLiteral(" id=\"lnk-return-search-results\"");

WriteLiteral(">Return to search results</a>\r\n");

            
            #line 24 "..\..\Views\TraineeshipSearch\Details.cshtml"
            }
            else
            {
                
            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\TraineeshipSearch\Details.cshtml"
           Write(Html.RouteLink("Find a traineeship", CandidateRouteNames.TraineeshipSearch, null, new { @id = "lnk-find-traineeship", @class = "page-link" }));

            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                                                                                                              
            }

            
            #line default
            #line hidden
WriteLiteral("            <p");

WriteLiteral(" class=\"page-link hide-nojs\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" class=\"print-trigger\"");

WriteLiteral(" href=\"\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-print\"");

WriteLiteral("></i>Print this page</a>\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n");

            
            #line 35 "..\..\Views\TraineeshipSearch\Details.cshtml"
    
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\TraineeshipSearch\Details.cshtml"
     if (!Model.HasError())
    {

            
            #line default
            #line hidden
WriteLiteral("        <section");

WriteLiteral(" class=\" grid-row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"inner-block-padr\"");

WriteLiteral(">\r\n                    <p");

WriteAttribute("class", Tuple.Create(" class=\"", 1666), Tuple.Create("\"", 1724)
            
            #line 40 "..\..\Views\TraineeshipSearch\Details.cshtml"
, Tuple.Create(Tuple.Create("", 1674), Tuple.Create<System.Object, System.Int32>(Model.Description.GetPreserveFormattingCssClass()
            
            #line default
            #line hidden
, 1674), false)
);

WriteLiteral(">");

            
            #line 40 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                              Write(SFA.Apprenticeships.Web.Common.Framework.HtmlExtensions.EscapeHtmlEncoding(Html, Model.Description));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"column-one-third\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 44 "..\..\Views\TraineeshipSearch\Details.cshtml"
           Write(Html.Partial("_Apply", Model, new ViewDataDictionary() { new KeyValuePair<string, object>("AnalyticsButtonPosition", "Top") }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </section>\r\n");

WriteLiteral("        <section");

WriteLiteral(" class=\"section-border grid-row\"");

WriteLiteral(">\r\n            <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Traineeship details</h2>\r\n            <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"inner-block-padr\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" id=\"vacancy-full-descrpition\"");

WriteAttribute("class", Tuple.Create(" class=\"", 2367), Tuple.Create("\"", 2429)
            
            #line 51 "..\..\Views\TraineeshipSearch\Details.cshtml"
, Tuple.Create(Tuple.Create("", 2375), Tuple.Create<System.Object, System.Int32>(Model.FullDescription.GetPreserveFormattingCssClass()
            
            #line default
            #line hidden
, 2375), false)
);

WriteLiteral(">");

            
            #line 51 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                                                                Write(SFA.Apprenticeships.Web.Common.Framework.HtmlExtensions.EscapeHtmlEncoding(Html, Model.FullDescription));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                    <h3");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">Training to be provided</h3>\r\n                    <p");

WriteAttribute("class", Tuple.Create(" class=\"", 2642), Tuple.Create("\"", 2709)
            
            #line 53 "..\..\Views\TraineeshipSearch\Details.cshtml"
, Tuple.Create(Tuple.Create("", 2650), Tuple.Create<System.Object, System.Int32>(Model.TrainingToBeProvided.GetPreserveFormattingCssClass()
            
            #line default
            #line hidden
, 2650), false)
);

WriteLiteral(">");

            
            #line 53 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                                       Write(SFA.Apprenticeships.Web.Common.Framework.HtmlExtensions.EscapeHtmlEncoding(Html, Model.TrainingToBeProvided));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"column-one-third\"");

WriteLiteral(">\r\n");

            
            #line 57 "..\..\Views\TraineeshipSearch\Details.cshtml"
                
            
            #line default
            #line hidden
            
            #line 57 "..\..\Views\TraineeshipSearch\Details.cshtml"
                 if (!Model.IsEmployerAnonymous)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <h3");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">Training provider</h3>\r\n");

WriteLiteral("                            <p>");

            
            #line 60 "..\..\Views\TraineeshipSearch\Details.cshtml"
                          Write(Model.RecruitmentAgency);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 61 "..\..\Views\TraineeshipSearch\Details.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <h3");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">Training provider</h3>\r\n");

WriteLiteral("                    <p>");

            
            #line 65 "..\..\Views\TraineeshipSearch\Details.cshtml"
                  Write(Model.ProviderName);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 66 "..\..\Views\TraineeshipSearch\Details.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                \r\n\r\n                <h3");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">Contact</h3>\r\n                <p>");

            
            #line 70 "..\..\Views\TraineeshipSearch\Details.cshtml"
              Write(Model.Contact);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                <h3");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">Traineeship duration</h3>\r\n                <p");

WriteLiteral(" id=\"vacancy-expected-duration\"");

WriteLiteral(">");

            
            #line 72 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                              Write(string.IsNullOrWhiteSpace(@Model.ExpectedDuration) ? "Not specified" : @Model.ExpectedDuration);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                <h3");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">Possible start date</h3>\r\n                <p");

WriteLiteral(" id=\"vacancy-start-date\"");

WriteLiteral(">");

            
            #line 74 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                      Write(Html.DisplayFor(m => Model.StartDate));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                <h3");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">Date posted</h3>\r\n                <p");

WriteLiteral(" id=\"vacancy-posted-date\"");

WriteLiteral(">");

            
            #line 76 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                       Write(Model.PostedDate.ToFriendlyDaysAgo());

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 77 "..\..\Views\TraineeshipSearch\Details.cshtml"
                
            
            #line default
            #line hidden
            
            #line 77 "..\..\Views\TraineeshipSearch\Details.cshtml"
                 if (Model.Distance != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <h3");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">Distance</h3>\r\n");

WriteLiteral("                            <p");

WriteLiteral(" id=\"vacancy-distance\"");

WriteLiteral(">");

            
            #line 80 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                Write(Model.Distance);

            
            #line default
            #line hidden
WriteLiteral(" miles</p>\r\n");

            
            #line 81 "..\..\Views\TraineeshipSearch\Details.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n                <h3");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">Reference number</h3>\r\n                <p");

WriteLiteral(" id=\"vacancy-reference-id\"");

WriteLiteral(">");

            
            #line 84 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                        Write(Model.VacancyReference);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n\r\n                <h3");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">Positions</h3>\r\n                <p");

WriteLiteral(" id=\"number-of-positions\"");

WriteLiteral(">");

            
            #line 87 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                       Write(Model.NumberOfPositions);

            
            #line default
            #line hidden
WriteLiteral(" available</p>\r\n\r\n            </div>\r\n        </section>\r\n");

WriteLiteral("        <section");

WriteLiteral(" class=\"section-border grid-row\"");

WriteLiteral(" id=\"vacancy-info\"");

WriteLiteral(">\r\n            <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Employer</h2>\r\n            <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"column-one-half\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"inner-block-padr\"");

WriteLiteral(">\r\n                        <p");

WriteLiteral(" id=\"vacancy-employer-name\"");

WriteAttribute("class", Tuple.Create(" class=\"", 4787), Tuple.Create("\"", 4857)
            
            #line 96 "..\..\Views\TraineeshipSearch\Details.cshtml"
, Tuple.Create(Tuple.Create("", 4795), Tuple.Create<System.Object, System.Int32>(Model.IsWellFormedEmployerWebsiteUrl ? "no-btm-margin" : ""
            
            #line default
            #line hidden
, 4795), false)
);

WriteLiteral(">");

            
            #line 96 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                                                                        Write(Model.EmployerName);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 97 "..\..\Views\TraineeshipSearch\Details.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 97 "..\..\Views\TraineeshipSearch\Details.cshtml"
                         if (Model.IsWellFormedEmployerWebsiteUrl)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <p><a");

WriteLiteral(" itemprop=\"url\"");

WriteAttribute("href", Tuple.Create(" href=\"", 5027), Tuple.Create("\"", 5056)
            
            #line 99 "..\..\Views\TraineeshipSearch\Details.cshtml"
, Tuple.Create(Tuple.Create("", 5034), Tuple.Create<System.Object, System.Int32>(Model.EmployerWebsite
            
            #line default
            #line hidden
, 5034), false)
);

WriteLiteral(" id=\"vacancy-employer-website\"");

WriteLiteral(" target=\"_blank\"");

WriteAttribute("title", Tuple.Create(" title=\"", 5103), Tuple.Create("\"", 5138)
            
            #line 99 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                    , Tuple.Create(Tuple.Create("", 5111), Tuple.Create<System.Object, System.Int32>(Model.EmployerName
            
            #line default
            #line hidden
, 5111), false)
, Tuple.Create(Tuple.Create(" ", 5130), Tuple.Create("Website", 5131), true)
);

WriteLiteral(" rel=\"external\"");

WriteLiteral(">");

            
            #line 99 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                                                                                                                           Write(Model.EmployerWebsite);

            
            #line default
            #line hidden
WriteLiteral("</a></p>\r\n");

            
            #line 100 "..\..\Views\TraineeshipSearch\Details.cshtml"
                        }
                        else
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <p>");

            
            #line 103 "..\..\Views\TraineeshipSearch\Details.cshtml"
                          Write(Model.EmployerWebsite);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 104 "..\..\Views\TraineeshipSearch\Details.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        <div itemscope");

WriteLiteral(" itemtype=\"http://schema.org/PostalAddress\"");

WriteLiteral(">\r\n                            <h3");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">Address</h3>\r\n                            <div");

WriteLiteral(" itemprop=\"address\"");

WriteLiteral(">\r\n                                <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(" itemprop=\"streetAddress\"");

WriteLiteral(">");

            
            #line 108 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                                Write(Model.VacancyAddress.AddressLine1);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(" itemprop=\"streetAddress\"");

WriteLiteral(">");

            
            #line 109 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                                Write(Model.VacancyAddress.AddressLine2);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(" itemprop=\"streetAddress\"");

WriteLiteral(">");

            
            #line 110 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                                Write(Model.VacancyAddress.AddressLine3);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(" itemprop=\"addressLocality\"");

WriteLiteral(">");

            
            #line 111 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                                  Write(Model.VacancyAddress.Town);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(" itemprop=\"addressRegion\"");

WriteLiteral(">");

            
            #line 112 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                                Write(Model.VacancyAddress.County);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                <p");

WriteLiteral(" class=\"\"");

WriteLiteral(" itemprop=\"postalCode\"");

WriteLiteral(">");

            
            #line 113 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                             Write(Model.VacancyAddress.Postcode);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n       " +
"             </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"column-one-half hide-print\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"ad-details__map\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"map-overlay\"");

WriteLiteral(" onclick=\"style.pointerEvents = \'none\'\"");

WriteLiteral("></div>\r\n                        <iframe");

WriteLiteral(" width=\"700\"");

WriteLiteral(" height=\"250\"");

WriteLiteral(" frameborder=\"0\"");

WriteLiteral(" style=\"border: 0\"");

WriteAttribute("src", Tuple.Create(" src=\"", 6690), Tuple.Create("\"", 6845)
, Tuple.Create(Tuple.Create("", 6696), Tuple.Create("https://www.google.com/maps/embed/v1/place?q=", 6696), true)
            
            #line 121 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                             , Tuple.Create(Tuple.Create("", 6741), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.VacancyAddress.Postcode)
            
            #line default
            #line hidden
, 6741), false)
, Tuple.Create(Tuple.Create("", 6781), Tuple.Create(",+United+Kingdom&amp;key=AIzaSyCusA_0x4bJEjU-_gLOFiXMSBXKZYtvHz8", 6781), true)
);

WriteLiteral("></iframe>\r\n                        <p");

WriteLiteral(" class=\"nojs-notice\"");

WriteLiteral(">You must have JavaScript enabled to view a map of the location</p>\r\n            " +
"        </div>\r\n                </div>\r\n\r\n");

            
            #line 126 "..\..\Views\TraineeshipSearch\Details.cshtml"
                
            
            #line default
            #line hidden
            
            #line 126 "..\..\Views\TraineeshipSearch\Details.cshtml"
                 if (!string.IsNullOrWhiteSpace(Model.AdditionalLocationInformation))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"grid-rowtext\"");

WriteLiteral(">\r\n                        <p></p>\r\n                        <h3");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">\r\n                            Additional location information\r\n                 " +
"       </h3>\r\n                        <p>");

            
            #line 133 "..\..\Views\TraineeshipSearch\Details.cshtml"
                       Write(SFA.Apprenticeships.Web.Common.Framework.HtmlExtensions.EscapeHtmlEncoding(Html, Model.AdditionalLocationInformation));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                    </div>\r\n");

            
            #line 135 "..\..\Views\TraineeshipSearch\Details.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </section>\r\n");

WriteLiteral("        <section");

WriteLiteral(" class=\"section-border grid-row\"");

WriteLiteral(" id=\"course-info\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"text\"");

WriteLiteral(">\r\n                <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Desired skills and what this will lead to</h2>\r\n                <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(">Desired skills and qualities</h3>\r\n                <p");

WriteAttribute("class", Tuple.Create(" class=\"", 7880), Tuple.Create("\"", 7941)
            
            #line 142 "..\..\Views\TraineeshipSearch\Details.cshtml"
, Tuple.Create(Tuple.Create("", 7888), Tuple.Create<System.Object, System.Int32>(Model.SkillsRequired.GetPreserveFormattingCssClass()
            
            #line default
            #line hidden
, 7888), false)
);

WriteLiteral(">");

            
            #line 142 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                             Write(SFA.Apprenticeships.Web.Common.Framework.HtmlExtensions.EscapeHtmlEncoding(Html, Model.SkillsRequired));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                <p");

WriteAttribute("class", Tuple.Create(" class=\"", 8072), Tuple.Create("\"", 8136)
            
            #line 143 "..\..\Views\TraineeshipSearch\Details.cshtml"
, Tuple.Create(Tuple.Create("", 8080), Tuple.Create<System.Object, System.Int32>(Model.PersonalQualities.GetPreserveFormattingCssClass()
            
            #line default
            #line hidden
, 8080), false)
);

WriteLiteral(">");

            
            #line 143 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                                Write(SFA.Apprenticeships.Web.Common.Framework.HtmlExtensions.EscapeHtmlEncoding(Html, Model.PersonalQualities));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n\r\n");

            
            #line 145 "..\..\Views\TraineeshipSearch\Details.cshtml"
                
            
            #line default
            #line hidden
            
            #line 145 "..\..\Views\TraineeshipSearch\Details.cshtml"
                 if (!string.IsNullOrWhiteSpace(Model.FutureProspects))
        {

            
            #line default
            #line hidden
WriteLiteral("                    <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(">What this will lead to</h3>\r\n");

WriteLiteral("                    <p");

WriteLiteral(" id=\"vacancy-future-prospects\"");

WriteAttribute("class", Tuple.Create(" class=\"", 8465), Tuple.Create("\"", 8527)
            
            #line 148 "..\..\Views\TraineeshipSearch\Details.cshtml"
, Tuple.Create(Tuple.Create("", 8473), Tuple.Create<System.Object, System.Int32>(Model.FutureProspects.GetPreserveFormattingCssClass()
            
            #line default
            #line hidden
, 8473), false)
);

WriteLiteral(">");

            
            #line 148 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                                                                Write(SFA.Apprenticeships.Web.Common.Framework.HtmlExtensions.EscapeHtmlEncoding(Html, Model.FutureProspects));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 149 "..\..\Views\TraineeshipSearch\Details.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </section>\r\n");

            
            #line 152 "..\..\Views\TraineeshipSearch\Details.cshtml"

        if (!string.IsNullOrWhiteSpace(Model.OtherInformation))
        {

            
            #line default
            #line hidden
WriteLiteral("            <section");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"text\"");

WriteLiteral(">\r\n                    <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Other information</h2>\r\n                    <p");

WriteLiteral(" id=\"vacany-other-information\"");

WriteAttribute("class", Tuple.Create(" class=\"", 8976), Tuple.Create("\"", 9039)
            
            #line 158 "..\..\Views\TraineeshipSearch\Details.cshtml"
, Tuple.Create(Tuple.Create("", 8984), Tuple.Create<System.Object, System.Int32>(Model.OtherInformation.GetPreserveFormattingCssClass()
            
            #line default
            #line hidden
, 8984), false)
);

WriteLiteral(">");

            
            #line 158 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                                                                 Write(SFA.Apprenticeships.Web.Common.Framework.HtmlExtensions.EscapeHtmlEncoding(Html, Model.OtherInformation));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </div>\r\n            </section>\r\n");

            
            #line 161 "..\..\Views\TraineeshipSearch\Details.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
