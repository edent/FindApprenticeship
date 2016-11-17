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
    
    #line 1 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
    using SFA.Apprenticeships.Domain.Entities.Vacancies.Apprenticeships;
    
    #line default
    #line hidden
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ApprenticeshipSearch/_searchUpdate.cshtml")]
    public partial class searchUpdate : System.Web.Mvc.WebViewPage<ApprenticeshipSearchViewModel>
    {
        public searchUpdate()
        {
        }
        public override void Execute()
        {
WriteLiteral("<section");

WriteLiteral(" class=\"column-one-third\"");

WriteLiteral(">\r\n    <div>\r\n        <fieldset");

WriteLiteral(" class=\"search-filter\"");

WriteLiteral(">\r\n            <legend");

WriteLiteral(" class=\"heading-medium mob-collpanel-trigger\"");

WriteLiteral(" id=\"editSearchToggle\"");

WriteLiteral(">Edit search</legend>\r\n            <div");

WriteLiteral(" class=\"mob-collpanel toggle-content--mob\"");

WriteLiteral(" id=\"editSearchPanel\"");

WriteLiteral(">\r\n");

            
            #line 9 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                 if (Model.SearchMode == ApprenticeshipSearchMode.Category)
                {
                    
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
               Write(Html.Partial("_categoriesAndSubCategories", Model));

            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                                                                       ;
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 14 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                 if (Model.SearchMode == ApprenticeshipSearchMode.Keyword)
                {
                    
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
               Write(Html.DropDownListFor(m => m.SearchField, Model.SearchFields, new { @class = "refineSearchOption hidden width-all-3-4 small-btm-margin form-control" }));

            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                                                                                                                                                                           
                    
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
               Write(Html.FormTextFor(m => m.Keywords, hintText: "", labelHtmlAttributes: new { id = "keyword-label" }, hintHtmlAttributes: new { id = "keyword-hint" }));

            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                                                                                                                                                                        
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"para-btm-margin\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 21 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
               Write(Html.FormTextFor(m => m.Location, hintText: "", containerHtmlAttributes: new { @class = "small-btm-margin" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"geolocater inl-block hide-nojs \"");

WriteLiteral(" id=\"getLocation\"");

WriteLiteral(">Use current location</a>\r\n                </div>\r\n                \r\n\r\n");

            
            #line 26 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                  
                    var open = Model.LocationSearches.Any() ? "open " : "";
                    var hidden = Model.LocationSearches.Any() ? "" : "hidden ";
                
            
            #line default
            #line hidden
WriteLiteral("\r\n                <details ");

            
            #line 30 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                     Write(open);

            
            #line default
            #line hidden
WriteLiteral(" class=\"");

            
            #line 30 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                                    Write(open);

            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                                           Write(hidden);

            
            #line default
            #line hidden
WriteLiteral("form-group form-group-compound\" id=\"locationSuggestions\">\r\n                    <s" +
"ummary");

WriteLiteral(" tabindex=\"0\"");

WriteLiteral(" aria-describedby=\"locSuggestionsAria\"");

WriteLiteral(">Did you mean:</summary>\r\n                    <p");

WriteLiteral(" class=\"visuallyhidden\"");

WriteLiteral(" aria-live=\"polite\"");

WriteLiteral(" id=\"locSuggestionsAria\"");

WriteLiteral("></p>\r\n                    <div");

WriteLiteral(" class=\"detail-content panel-indent\"");

WriteLiteral(">\r\n                        <ul");

WriteLiteral(" id=\"location-suggestions\"");

WriteLiteral(" class=\"list-text list-max-11\"");

WriteLiteral(">\r\n");

            
            #line 35 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                             foreach (var locationSearch in Model.LocationSearches)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2193), Tuple.Create("\"", 2284)
            
            #line 37 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
, Tuple.Create(Tuple.Create("", 2200), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(CandidateRouteNames.ApprenticeshipResults, locationSearch.RouteValues)
            
            #line default
            #line hidden
, 2200), false)
);

WriteLiteral(">");

            
            #line 37 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                                                                                                                              Write(locationSearch.Location);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 38 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </ul>\r\n                    </div>\r\n                </deta" +
"ils>\r\n\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"loc-within\"");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Within</label>\r\n");

WriteLiteral("                    ");

            
            #line 45 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
               Write(Html.DropDownListFor(m => m.WithinDistance, Model.Distances, new { @id = "loc-within", @name = "WithinDistance", @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"apprenticeship-level\"");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Apprenticeship level</label>\r\n");

WriteLiteral("                    ");

            
            #line 49 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
               Write(Html.DropDownListFor(m => m.ApprenticeshipLevel, Model.ApprenticeshipLevels, new { @id = "apprenticeship-level", @name = "ApprenticeshipLevel", @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"form-group form-group-compound\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" class=\"button no-btm-margin\"");

WriteLiteral(" id=\"search-button\"");

WriteLiteral(" name=\"SearchAction\"");

WriteLiteral(" value=\"Search\"");

WriteLiteral(">Update results</button>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 55 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
               Write(Html.RouteLink("Start again", CandidateRouteNames.ApprenticeshipSearch, new { Model.SearchMode, reset = true }, new { @id = "start-again-link" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"form-group map-container hide-nojs\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" id=\"map-canvas\"");

WriteLiteral(" style=\"width: 100%; height: 250px\"");

WriteLiteral("></div>\r\n                </div>\r\n\r\n");

WriteLiteral("                ");

            
            #line 61 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
           Write(Html.HiddenFor(m => m.Latitude));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 62 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
           Write(Html.HiddenFor(m => m.Longitude));

            
            #line default
            #line hidden
WriteLiteral("\r\n                ");

WriteLiteral("\r\n                <input");

WriteLiteral(" id=\"Hash\"");

WriteLiteral(" name=\"Hash\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4087), Tuple.Create("\"", 4117)
            
            #line 64 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
, Tuple.Create(Tuple.Create("", 4095), Tuple.Create<System.Object, System.Int32>(Model.LatLonLocHash()
            
            #line default
            #line hidden
, 4095), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("                ");

            
            #line 65 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
           Write(Html.HiddenFor(m => m.SearchMode));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 66 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
           Write(Html.HiddenFor(m=> m.Category));

            
            #line default
            #line hidden
WriteLiteral("\r\n                ");

WriteLiteral("\r\n                <input");

WriteLiteral(" id=\"LocationType\"");

WriteLiteral(" name=\"LocationType\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4484), Tuple.Create("\"", 4511)
            
            #line 68 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
  , Tuple.Create(Tuple.Create("", 4492), Tuple.Create<System.Object, System.Int32>(Model.LocationType
            
            #line default
            #line hidden
, 4492), false)
);

WriteLiteral(" />\r\n            </div>\r\n        </fieldset>\r\n    </div>\r\n</section>");

        }
    }
}
#pragma warning restore 1591
