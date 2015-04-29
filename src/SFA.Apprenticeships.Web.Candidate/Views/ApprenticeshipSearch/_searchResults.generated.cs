﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SFA.Apprenticeships.Web.Candidate.Views.ApprenticeshipSearch
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
    
    #line 1 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
    using SFA.Apprenticeships.Domain.Entities.Vacancies.Apprenticeships;
    
    #line default
    #line hidden
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ApprenticeshipSearch/_searchResults.cshtml")]
    public partial class searchResults : System.Web.Mvc.WebViewPage<ApprenticeshipSearchResponseViewModel>
    {
        public searchResults()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 5 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
 if (Model.TotalLocalHits > 0 || Model.TotalNationalHits > 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <fieldset>\r\n        <legend");

WriteLiteral(" class=\"visuallyhidden\"");

WriteLiteral(">Search items</legend>\r\n        <div");

WriteLiteral(" class=\"grid-wrapper med-btm-margin\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"font-xsmall grid grid-1-3\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"width-all-1-3 hide-js inl-block\"");

WriteLiteral("></div>\r\n                <div");

WriteLiteral(" class=\"inner-block-padr hide-nojs\"");

WriteLiteral(">\r\n                    <details");

WriteLiteral(" class=\"no-btm-margin small-top-padding\"");

WriteLiteral(">\r\n                        <summary >More/less detail</summary>\r\n                " +
"        <div");

WriteLiteral(" class=\"detail-content\"");

WriteLiteral(" id=\"chooseDetails\"");

WriteLiteral(">\r\n                            <ul");

WriteLiteral(" class=\"list-text list-checkradio\"");

WriteLiteral(">\r\n");

            
            #line 17 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                 if (Model.VacancySearch.SearchMode == ApprenticeshipSearchMode.Category)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <li>\r\n                                       " +
" <input ");

            
            #line 20 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                 if (Model.VacancySearch.DisplaySubCategory) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" checked=\"checked\" ");

WriteLiteral(" ");

            
            #line 20 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                                }
            
            #line default
            #line hidden
WriteLiteral(" type=\"checkbox\" id=\"DisplaySubCategory\">\r\n                                      " +
"  <label");

WriteLiteral(" for=\"DisplaySubCategory\"");

WriteLiteral(">Sub-category</label>\r\n                                    </li>\r\n");

            
            #line 23 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                                <li>\r\n                                    <input " +
"");

            
            #line 25 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                             if (Model.VacancySearch.DisplayDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" checked=\"checked\" ");

WriteLiteral(" ");

            
            #line 25 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                            }
            
            #line default
            #line hidden
WriteLiteral(" type=\"checkbox\" id=\"DisplayDescription\">\r\n                                    <l" +
"abel");

WriteLiteral(" for=\"DisplayDescription\"");

WriteLiteral(">Description</label>\r\n                                </li>\r\n                    " +
"            <li>\r\n                                    <input ");

            
            #line 29 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                             if (Model.VacancySearch.DisplayDistance) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" checked=\"checked\" ");

WriteLiteral(" ");

            
            #line 29 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                         }
            
            #line default
            #line hidden
WriteLiteral(" type=\"checkbox\" id=\"DisplayDistance\">\r\n                                    <labe" +
"l");

WriteLiteral(" for=\"DisplayDistance\"");

WriteLiteral(">Distance</label>\r\n                                </li>\r\n                       " +
"         <li>\r\n                                    <input ");

            
            #line 33 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                             if (Model.VacancySearch.DisplayClosingDate) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" checked=\"checked\" ");

WriteLiteral(" ");

            
            #line 33 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                            }
            
            #line default
            #line hidden
WriteLiteral(" type=\"checkbox\" id=\"DisplayClosingDate\">\r\n                                    <l" +
"abel");

WriteLiteral(" for=\"DisplayClosingDate\"");

WriteLiteral(">Closing date</label>\r\n                                </li>\r\n                   " +
"             <li>\r\n                                    <input ");

            
            #line 37 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                             if (Model.VacancySearch.DisplayStartDate) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" checked=\"checked\" ");

WriteLiteral(" ");

            
            #line 37 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                          }
            
            #line default
            #line hidden
WriteLiteral(" type=\"checkbox\" id=\"DisplayStartDate\">\r\n                                    <lab" +
"el");

WriteLiteral(" for=\"DisplayStartDate\"");

WriteLiteral(">Possible start date</label>\r\n                                </li>\r\n            " +
"                    <li>\r\n                                    <input ");

            
            #line 41 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                             if (Model.VacancySearch.DisplayApprenticeshipLevel) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" checked=\"checked\" ");

WriteLiteral(" ");

            
            #line 41 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                                    }
            
            #line default
            #line hidden
WriteLiteral(" type=\"checkbox\" id=\"DisplayApprenticeshipLevel\">\r\n                              " +
"      <label");

WriteLiteral(" for=\"DisplayApprenticeshipLevel\"");

WriteLiteral(">Apprenticeship level</label>\r\n                                </li>\r\n           " +
"                     <li>\r\n                                    <input ");

            
            #line 45 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                             if (Model.VacancySearch.DisplayWage) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" checked=\"checked\" ");

WriteLiteral(" ");

            
            #line 45 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                     }
            
            #line default
            #line hidden
WriteLiteral(" type=\"checkbox\" id=\"DisplayWage\">\r\n                                    <label");

WriteLiteral(" for=\"DisplayWage\"");

WriteLiteral(">Wage</label>\r\n                                </li>\r\n\r\n                         " +
"   </ul>\r\n                        </div>\r\n                    </details>\r\n      " +
"          </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"grid grid-2-3 ta-right ta-left-mob\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" for=\"sort-results\"");

WriteLiteral(" class=\"heading-medium inline\"");

WriteLiteral(">Sort results</label>\r\n");

WriteLiteral("                ");

            
            #line 56 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
           Write(Html.DropDownList("sortType", Model.SortTypes, new { @id = "sort-results" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <noscript>\r\n                    <button");

WriteLiteral(" style=\"float: right; margin-left: 5px;\"");

WriteLiteral(" class=\"button show-nojs\"");

WriteLiteral(" name=\"SearchAction\"");

WriteLiteral(" value=\"Sort\"");

WriteLiteral(">Sort</button>\r\n                </noscript>\r\n                <input");

WriteLiteral(" id=\"SearchAction\"");

WriteLiteral(" name=\"SearchAction\"");

WriteLiteral(" value=\"Search\"");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n    </fieldset>\r\n");

            
            #line 64 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<ul");

WriteLiteral(" class=\"search-results\"");

WriteLiteral(">\r\n");

            
            #line 66 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
    
            
            #line default
            #line hidden
            
            #line 66 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
     if (Model.Vacancies != null)
    {
        var itemPosition = 1 + (Model.PageSize * Model.PrevPage);
        foreach (var vacancy in Model.Vacancies)
        {
            var webTrendItemPositionTracker = "Webtrends.multiTrack({ element: this, argsa: ['DCS.dcsuri', '/apprenticeships/results/itemposition/" + vacancy.Id + "', 'WT.dl', '99', 'WT.ti', 'Apprenticeships Search – Item Position Clicked', 'DCSext.ipos', '" + itemPosition + "'] })";

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"search-results__item section-border\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"hgroup-medium top-align width-all-3-4\"");

WriteLiteral(">\r\n                    <h2");

WriteLiteral(" class=\"heading-medium vacancy-title-link\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 75 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                    Write(vacancy.VacancyLocationType == ApprenticeshipLocationType.NonNational ?
                            Html.ActionLink(@vacancy.Title, "DetailsWithDistance", new { id = vacancy.Id, distance = vacancy.DistanceAsString }, new { @class = "vacancy-link", data_vacancy_id = vacancy.Id, onclick = webTrendItemPositionTracker, data_lat = vacancy.Location.Latitude, data_lon = vacancy.Location.Longitude }) :
                            Html.ActionLink(@vacancy.Title, "DetailsWithDistance", new { id = vacancy.Id, distance = vacancy.DistanceAsString }, new { @class = "vacancy-link", data_vacancy_id = vacancy.Id, onclick = webTrendItemPositionTracker })
                        );

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 79 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 79 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                         if (Model.VacancySearch.SearchMode == ApprenticeshipSearchMode.Category)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <span");

WriteLiteral(" data-show=\"DisplaySubCategory\"");

WriteAttribute("class", Tuple.Create(" class=\"", 5623), Tuple.Create("\"", 5726)
, Tuple.Create(Tuple.Create("", 5631), Tuple.Create("font-small", 5631), true)
, Tuple.Create(Tuple.Create(" ", 5641), Tuple.Create("hidden-subcategory", 5642), true)
            
            #line 81 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                      , Tuple.Create(Tuple.Create(" ", 5660), Tuple.Create<System.Object, System.Int32>(Model.VacancySearch.DisplaySubCategory ? "" : "toggle-content"
            
            #line default
            #line hidden
, 5661), false)
);

WriteLiteral("> (");

            
            #line 81 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                                                                      Write(FullNameFormatter.Format(vacancy.SubCategory));

            
            #line default
            #line hidden
WriteLiteral(")</span>\r\n");

            
            #line 82 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </h2>\r\n                    <p");

WriteAttribute("id", Tuple.Create(" id=\"", 5862), Tuple.Create("\"", 5890)
, Tuple.Create(Tuple.Create("", 5867), Tuple.Create("posted-date-", 5867), true)
            
            #line 84 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
, Tuple.Create(Tuple.Create("", 5879), Tuple.Create<System.Object, System.Int32>(vacancy.Id
            
            #line default
            #line hidden
, 5879), false)
);

WriteLiteral(" class=\"subtitle\"");

WriteLiteral(">");

            
            #line 84 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                Write(vacancy.EmployerName);

            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"font-xsmall\"");

WriteLiteral("> (Added ");

            
            #line 84 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                       Write(vacancy.PostedDate.ToFriendlyDaysAgo());

            
            #line default
            #line hidden
WriteLiteral(")</span></p>\r\n                </div>\r\n");

            
            #line 86 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 86 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                 if (ViewBag.IsCandidateActivated != null && ViewBag.IsCandidateActivated)
                {
                    var applicationStatus = vacancy.CandidateApplicationStatus.HasValue
                        ? vacancy.CandidateApplicationStatus.ToString()
                        : "Unsaved";


            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"top-align ta-right width-all-1-4\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"#\"");

WriteAttribute("id", Tuple.Create(" id=\"", 6457), Tuple.Create("\"", 6491)
, Tuple.Create(Tuple.Create("", 6462), Tuple.Create("save-vacancy-link-", 6462), true)
            
            #line 93 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6480), Tuple.Create<System.Object, System.Int32>(vacancy.Id
            
            #line default
            #line hidden
, 6480), false)
);

WriteLiteral(" class=\"hidden fake-link link-unimp save-vacancy-link\"");

WriteLiteral(" data-vacancy-id=\"");

            
            #line 93 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                                         Write(vacancy.Id);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-application-status=\"");

            
            #line 93 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                                                                               Write(applicationStatus);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa\"");

WriteLiteral("></i></a>\r\n");

WriteLiteral("                        ");

            
            #line 94 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                   Write(Html.ActionLink("Resume", "Resume", "ApprenticeshipApplication", new { id = vacancy.Id }, new { @class = "hidden resume-link", @id = "resume-link-" + @vacancy.Id }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <p");

WriteAttribute("id", Tuple.Create(" id=\"", 6863), Tuple.Create("\"", 6893)
, Tuple.Create(Tuple.Create("", 6868), Tuple.Create("applied-label-", 6868), true)
            
            #line 95 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6882), Tuple.Create<System.Object, System.Int32>(vacancy.Id
            
            #line default
            #line hidden
, 6882), false)
);

WriteLiteral(" class=\"hidden applied-label\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-check\"");

WriteLiteral("></i>Applied</p>\r\n                    </div>\r\n");

            
            #line 97 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <p");

WriteLiteral(" data-show=\"DisplayDescription\"");

WriteLiteral(" ");

            
            #line 98 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                    if (!Model.VacancySearch.DisplayDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" class=\"toggle-content\" ");

WriteLiteral(" ");

            
            #line 98 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                                         }
            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 98 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                                       Write(vacancy.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                <div");

WriteLiteral(" class=\"grid-wrapper\"");

WriteLiteral(">\r\n                    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 7245), Tuple.Create("\"", 7348)
            
            #line 100 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7253), Tuple.Create<System.Object, System.Int32>(vacancy.VacancyLocationType == ApprenticeshipLocationType.NonNational ? "grid grid-2-3" : ""
            
            #line default
            #line hidden
, 7253), false)
);

WriteLiteral(">\r\n                        <ul");

WriteLiteral(" class=\"list-text no-btm-margin inner-block-padr\"");

WriteLiteral(">\r\n\r\n");

            
            #line 103 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 103 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                             if (vacancy.VacancyLocationType == ApprenticeshipLocationType.NonNational)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li");

WriteLiteral(" data-show=\"DisplayDistance\"");

WriteLiteral(" ");

            
            #line 105 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                  if (!Model.VacancySearch.DisplayDistance) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" class=\"toggle-content\" ");

WriteLiteral(" ");

            
            #line 105 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                                                    }
            
            #line default
            #line hidden
WriteLiteral(">\r\n                                    <b>Distance:</b> <span");

WriteLiteral(" class=\"distance-value\"");

WriteLiteral(">");

            
            #line 106 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                             Write(vacancy.DistanceAsString);

            
            #line default
            #line hidden
WriteLiteral("</span> miles<span");

WriteLiteral(" class=\"summary-style fake-link hide-nojs journey-trigger\"");

WriteLiteral(">Journey time</span>\r\n                                    <div");

WriteLiteral(" class=\"detail-content toggle-content hide-nojs\"");

WriteLiteral(">\r\n                                        <select");

WriteLiteral(" class=\"select-mode\"");

WriteLiteral(" name=\"\"");

WriteLiteral(">\r\n                                            <option");

WriteLiteral(" value=\"DRIVING\"");

WriteLiteral(">Driving</option>\r\n                                            <option");

WriteLiteral(" value=\"TRANSIT\"");

WriteLiteral(">Bus/Train</option>\r\n                                            <option");

WriteLiteral(" value=\"WALKING\"");

WriteLiteral(">Walking</option>\r\n                                            <option");

WriteLiteral(" value=\"BICYCLING\"");

WriteLiteral(">Cycling</option>\r\n                                        </select>\r\n\r\n         " +
"                               <span");

WriteLiteral(" class=\"journey-time\"");

WriteLiteral("></span>\r\n                                    </div>\r\n                           " +
"     </li>\r\n");

            
            #line 118 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                            <li");

WriteLiteral(" data-show=\"DisplayClosingDate\"");

WriteLiteral(" ");

            
            #line 119 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                 if (!Model.VacancySearch.DisplayClosingDate) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" class=\"toggle-content\" ");

WriteLiteral(" ");

            
            #line 119 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                                                      }
            
            #line default
            #line hidden
WriteLiteral("><b>Closing date:</b> <span");

WriteLiteral(" class=\"closing-date-value\"");

WriteLiteral(" data-date=\"");

            
            #line 119 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                                                                                                                     Write(vacancy.ClosingDate.ToString("u"));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">");

            
            #line 119 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                                                                                                                                                         Write(vacancy.ClosingDate.ToFriendlyClosingWeek());

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n                            <li");

WriteLiteral(" data-show=\"DisplayStartDate\"");

WriteLiteral(" ");

            
            #line 120 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                               if (!Model.VacancySearch.DisplayStartDate) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" class=\"toggle-content\" ");

WriteLiteral(" ");

            
            #line 120 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                                                  }
            
            #line default
            #line hidden
WriteLiteral("><b>Possible start date:</b> <span");

WriteLiteral(" class=\"start-date-value\"");

WriteLiteral(">");

            
            #line 120 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                                                                                                           Write(Html.DisplayFor(m => vacancy.StartDate, "Date"));

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n                            <li");

WriteLiteral(" data-show=\"DisplayApprenticeshipLevel\"");

WriteLiteral(" ");

            
            #line 121 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                         if (!Model.VacancySearch.DisplayApprenticeshipLevel) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" class=\"toggle-content\" ");

WriteLiteral(" ");

            
            #line 121 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                                                                      }
            
            #line default
            #line hidden
WriteLiteral("><b>Apprenticeship level:</b> ");

            
            #line 121 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                                                                                                 Write(vacancy.ApprenticeshipLevel);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                            <li");

WriteLiteral(" data-show=\"DisplayWage\"");

WriteLiteral(" ");

            
            #line 122 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                          if (!Model.VacancySearch.DisplayWage) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" class=\"toggle-content\" ");

WriteLiteral(" ");

            
            #line 122 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                                        }
            
            #line default
            #line hidden
WriteLiteral("><b>Wage:</b> ");

            
            #line 122 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                                                                                                                                                   Write(vacancy.Wage);

            
            #line default
            #line hidden
WriteLiteral(" p/week</li>\r\n\r\n");

            
            #line 124 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 124 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                             if (vacancy.VacancyLocationType == ApprenticeshipLocationType.National)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li>This apprenticeship has multiple positions na" +
"tionwide.</li>\r\n");

            
            #line 127 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </ul>\r\n                    </div>\r\n");

            
            #line 130 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 130 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                     if (vacancy.VacancyLocationType == ApprenticeshipLocationType.NonNational)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"hide-tablet\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" style=\"margin-left: 0;\"");

WriteLiteral(" class=\"summary-style fake-link mob-map-trigger map-closed\"");

WriteLiteral(">Show/hide map</span>\r\n                        </div>\r\n");

WriteLiteral("                        <div");

WriteLiteral(" class=\"grid grid-1-3 map-container hide-nojs small-btm-margin toggle-content--mo" +
"b\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 10489), Tuple.Create("\"", 10599)
, Tuple.Create(Tuple.Create("", 10496), Tuple.Create("https://www.google.com/maps/dir/LocationLatLon/\'", 10496), true)
            
            #line 136 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
    , Tuple.Create(Tuple.Create("", 10544), Tuple.Create<System.Object, System.Int32>(vacancy.Location.Latitude
            
            #line default
            #line hidden
, 10544), false)
, Tuple.Create(Tuple.Create("", 10570), Tuple.Create(",", 10570), true)
            
            #line 136 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                               , Tuple.Create(Tuple.Create("", 10571), Tuple.Create<System.Object, System.Int32>(vacancy.Location.Longitude
            
            #line default
            #line hidden
, 10571), false)
, Tuple.Create(Tuple.Create("", 10598), Tuple.Create("\'", 10598), true)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" rel=\"external\"");

WriteLiteral(" class=\"map-links fake-link font-xxsmall view-googlemaps\"");

WriteLiteral(">Open map</a>\r\n                            <div");

WriteLiteral(" class=\"map\"");

WriteLiteral("></div>\r\n                        </div>\r\n");

            
            #line 139 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n\r\n            </li>\r\n");

            
            #line 143 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
            itemPosition++;
        }
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>\r\n\r\n");

            
            #line 148 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
   Html.RenderPartial("_pagination", Model); 
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 150 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
 if (Model.TotalLocalHits > 5 || Model.TotalNationalHits > 5)
{

            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"results-per-page\"");

WriteLiteral(" class=\"heading-small inline\"");

WriteLiteral(">Display results</label>\r\n");

WriteLiteral("    ");

            
            #line 154 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
Write(Html.DropDownList("resultsPerPage", Model.ResultsPerPageSelectList, new { @id = "results-per-page" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <noscript>\r\n        <button");

WriteLiteral(" class=\"button show-nojs\"");

WriteLiteral(" name=\"ChangeResultsPerPageAction\"");

WriteLiteral(" value=\"ResultsPerPage\"");

WriteLiteral(">View</button>\r\n    </noscript>\r\n</div>\r\n");

            
            #line 159 "..\..\Views\ApprenticeshipSearch\_searchResults.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
