﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
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
 if (Model.TotalHits == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <p");

WriteLiteral(" id=\"search-no-results-title\"");

WriteLiteral(">There are currently no traineeships that match your search.</p>\r\n");

WriteLiteral("    <p>Try a different location, or expanding your search to 40 miles</p>\r\n");

            
            #line 7 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
}
else
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

            
            #line 15 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
           Write(Html.DropDownList("sortType", Model.SortTypes, new {@id = "sort-results"}));

            
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

            
            #line 23 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <ul");

WriteLiteral(" class=\"search-results\"");

WriteLiteral(">\r\n");

            
            #line 25 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
        
            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
         if (Model.Vacancies != null)
        {
            var itemPosition = 1 + (Model.PageSize * Model.PrevPage);
            foreach (var vacancy in Model.Vacancies)
            {
                var webTrendItemPositionTracker = "Webtrends.multiTrack({ element: this, argsa: ['DCS.dcsuri', '/traineeships/results/itemposition/" + vacancy.Id + "', 'WT.dl', '99', 'WT.ti', 'Traineeships Search – Item Position Clicked', 'DCSext.ipos', '" + itemPosition + "'] })";

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" class=\"search-results__item section-border\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"hgroup-medium\"");

WriteLiteral(">\r\n                        <h2");

WriteLiteral(" class=\"heading-medium vacancy-title-link\"");

WriteLiteral(">");

            
            #line 33 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
                                                                 Write(Html.ActionLink(@vacancy.Title, "DetailsWithDistance", new { id = vacancy.Id, distance = vacancy.DistanceAsString }, new { @class = "vacancy-link", data_vacancy_id = vacancy.Id, onclick = webTrendItemPositionTracker, data_lat = vacancy.Location.Latitude, data_lon = vacancy.Location.Longitude }));

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                        <p");

WriteAttribute("id", Tuple.Create(" id=\"", 1955), Tuple.Create("\"", 1983)
, Tuple.Create(Tuple.Create("", 1960), Tuple.Create("posted-date-", 1960), true)
            
            #line 34 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1972), Tuple.Create<System.Object, System.Int32>(vacancy.Id
            
            #line default
            #line hidden
, 1972), false)
);

WriteLiteral(" class=\"subtitle\"");

WriteLiteral(">");

            
            #line 34 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
                                                                    Write(vacancy.EmployerName);

            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"font-xsmall\"");

WriteLiteral("> (Added ");

            
            #line 34 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
                                                                                                                           Write(vacancy.PostedDate.ToFriendlyDaysAgo());

            
            #line default
            #line hidden
WriteLiteral(")</span></p>\r\n                    </div>\r\n                    <p>\r\n");

WriteLiteral("                        ");

            
            #line 37 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
                   Write(vacancy.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 38 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
                         if (vacancy.NumberOfPositions > 1)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <span");

WriteLiteral(" class=\"font-xsmall inl-block\"");

WriteLiteral(">(");

            
            #line 40 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
                                                            Write(vacancy.NumberOfPositions);

            
            #line default
            #line hidden
WriteLiteral(" positions available)</span>\r\n");

            
            #line 41 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </p>\r\n                    <div");

WriteLiteral(" class=\"grid-wrapper\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"grid grid-2-3\"");

WriteLiteral(">\r\n                            <ul");

WriteLiteral(" class=\"list-text no-btm-margin\"");

WriteLiteral(">\r\n                                <li>\r\n                                    <b>D" +
"istance:</b> <span");

WriteLiteral(" class=\"distance-value\"");

WriteLiteral(">");

            
            #line 47 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
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
"     </li>\r\n                                <li><b>Closing date:</b> <span");

WriteLiteral(" class=\"closing-date-value\"");

WriteLiteral(" data-date=\"");

            
            #line 59 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
                                                                                                Write(vacancy.ClosingDate.ToString("u"));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">");

            
            #line 59 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
                                                                                                                                    Write(vacancy.ClosingDate.ToFriendlyClosingWeek());

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n                                <li><b>Possible start date:</b> <sp" +
"an");

WriteLiteral(" class=\"start-date-value\"");

WriteLiteral(">");

            
            #line 60 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
                                                                                          Write(Html.DisplayFor(m => vacancy.StartDate, "Date"));

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n                            </ul>\r\n                        </div>\r\n" +
"                        <div");

WriteLiteral(" class=\"hide-tablet\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" style=\"margin-left: 0;\"");

WriteLiteral(" class=\"summary-style fake-link mob-map-trigger map-closed\"");

WriteLiteral(">Show/hide map</span>\r\n                        </div>\r\n                        <d" +
"iv");

WriteLiteral(" class=\"grid grid-1-3 map-container hide-nojs small-btm-margin toggle-content--mo" +
"b\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4395), Tuple.Create("\"", 4505)
, Tuple.Create(Tuple.Create("", 4402), Tuple.Create("https://www.google.com/maps/dir/LocationLatLon/\'", 4402), true)
            
            #line 67 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
     , Tuple.Create(Tuple.Create("", 4450), Tuple.Create<System.Object, System.Int32>(vacancy.Location.Latitude
            
            #line default
            #line hidden
, 4450), false)
, Tuple.Create(Tuple.Create("", 4476), Tuple.Create(",", 4476), true)
            
            #line 67 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
                                , Tuple.Create(Tuple.Create("", 4477), Tuple.Create<System.Object, System.Int32>(vacancy.Location.Longitude
            
            #line default
            #line hidden
, 4477), false)
, Tuple.Create(Tuple.Create("", 4504), Tuple.Create("\'", 4504), true)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" rel=\"external\"");

WriteLiteral(" class=\"map-links fake-link font-xxsmall view-googlemaps\"");

WriteLiteral(">Open map</a>\r\n                            <div");

WriteLiteral(" class=\"map\"");

WriteLiteral("></div>\r\n                        </div>\r\n                    </div>\r\n            " +
"    </li>\r\n");

            
            #line 72 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
                itemPosition++;
            }
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n");

            
            #line 76 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"

    Html.RenderPartial("_pagination", Model);

    if (Model.TotalHits > 5)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"results-per-page\"");

WriteLiteral(" class=\"heading-small inline\"");

WriteLiteral(">Display results</label>\r\n");

WriteLiteral("            ");

            
            #line 83 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
       Write(Html.DropDownList("resultsPerPage", Model.ResultsPerPageSelectList, new { @id = "results-per-page" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <noscript>\r\n                <button");

WriteLiteral(" class=\"button show-nojs\"");

WriteLiteral(" name=\"ChangeResultsPerPageAction\"");

WriteLiteral(" value=\"ResultsPerPage\"");

WriteLiteral(">View</button>\r\n            </noscript>\r\n        </div>\r\n");

            
            #line 88 "..\..\Views\TraineeshipSearch\_searchResults.cshtml"
    }
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
