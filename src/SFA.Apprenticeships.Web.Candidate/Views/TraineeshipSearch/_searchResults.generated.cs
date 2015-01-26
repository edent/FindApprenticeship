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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/TraineeshipSearch/_searchResults.cshtml")]
    public partial class searchResults : System.Web.Mvc.WebViewPage<TraineeshipSearchResponseViewModel>
    {
        public searchResults()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
 if (Model.TotalHits > 0 )
{

            
            #line default
            #line hidden
WriteLiteral("    <fieldset>\r\n        <legend");

WriteLiteral(" class=\"visuallyhidden\"");

WriteLiteral(">Search items</legend>\r\n        <div");

WriteLiteral(" class=\"float-right-wrap\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"form-group form-group-compound\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" for=\"sort-results\"");

WriteLiteral(" class=\"heading-medium inline\"");

WriteLiteral(">Sort results</label>\r\n");

WriteLiteral("                ");

            
            #line 10 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
           Write(Html.DropDownList("sortType", Model.SortTypes, new { @id = "sort-results" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <noscript>\r\n                    <button");

WriteLiteral(" class=\"button show-nojs\"");

WriteLiteral(" name=\"SearchAction\"");

WriteLiteral(" value=\"Sort\"");

WriteLiteral(">Sort</button>\r\n                </noscript>\r\n                <input");

WriteLiteral(" id=\"SearchAction\"");

WriteLiteral(" name=\"SearchAction\"");

WriteLiteral(" value=\"Search\"");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n    </fieldset>\r\n");

            
            #line 18 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<ul");

WriteLiteral(" class=\"search-results\"");

WriteLiteral(">\r\n");

            
            #line 20 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
    
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
     if (Model.Vacancies != null)
    {
        var itemPosition = 1 + (Model.PageSize * Model.PrevPage);
        foreach (var vacancy in Model.Vacancies)
        {
            var webTrendItemPositionTracker = "Webtrends.multiTrack({ element: this, argsa: ['DCS.dcsuri', '/traineeships/results/itemposition/" + vacancy.Id + "', 'WT.dl', '99', 'WT.ti', 'Traineeships Search – Item Position Clicked', 'DCSext.ipos', '" + itemPosition + "'] })";

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"search-results__item section-border\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"hgroup-medium\"");

WriteLiteral(">\r\n                    <h2");

WriteLiteral(" class=\"heading-medium vacancy-title-link\"");

WriteLiteral(">");

            
            #line 28 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
                                                             Write(Html.ActionLink(@vacancy.Title, "DetailsWithDistance", new { id = vacancy.Id, distance = vacancy.DistanceAsString }, new { @class = "vacancy-link", data_vacancy_id = vacancy.Id, onclick = webTrendItemPositionTracker, data_lat = vacancy.Location.Latitude, data_lon = vacancy.Location.Longitude }));

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                    <p");

WriteLiteral(" class=\"subtitle\"");

WriteLiteral(">");

            
            #line 29 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
                                   Write(vacancy.EmployerName);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </div>\r\n                <p>");

            
            #line 31 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
              Write(vacancy.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                <ul");

WriteLiteral(" class=\"list-text no-btm-margin\"");

WriteLiteral(">\r\n                    <li><b>Distance:</b> <span");

WriteLiteral(" class=\"distance-value\"");

WriteLiteral(">");

            
            #line 33 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
                                                                 Write(vacancy.DistanceAsString);

            
            #line default
            #line hidden
WriteLiteral("</span> miles</li>\r\n                    <li><b>Closing date:</b> <span");

WriteLiteral(" class=\"closing-date-value\"");

WriteLiteral(" data-date=\"");

            
            #line 34 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
                                                                                    Write(vacancy.ClosingDate.ToString("u"));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">");

            
            #line 34 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
                                                                                                                        Write(vacancy.ClosingDate.ToFriendlyClosingWeek());

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n                    <li><b>Planned start date:</b> <span");

WriteLiteral(" class=\"start-date-value\"");

WriteLiteral(">");

            
            #line 35 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
                                                                             Write(Html.DisplayFor(m => vacancy.StartDate, "Date"));

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n                </ul>\r\n            </li>\r\n");

            
            #line 38 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
            itemPosition++;
        }
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>\r\n\r\n");

            
            #line 43 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
   Html.RenderPartial("_pagination", Model); 
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 45 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
 if (Model.TotalHits > 5)
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

            
            #line 49 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
Write(Html.DropDownList("resultsPerPage", Model.ResultsPerPageSelectList, new { @id = "results-per-page" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <noscript>\r\n        <button");

WriteLiteral(" class=\"button show-nojs\"");

WriteLiteral(" name=\"ChangeResultsPerPageAction\"");

WriteLiteral(" value=\"ResultsPerPage\"");

WriteLiteral(">View</button>\r\n    </noscript>\r\n</div>\r\n");

            
            #line 54 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
