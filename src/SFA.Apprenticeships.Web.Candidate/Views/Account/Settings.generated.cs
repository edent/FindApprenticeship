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

namespace SFA.Apprenticeships.Web.Candidate.Views.Account
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
    
    #line 1 "..\..\Views\Account\Settings.cshtml"
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Account;
    
    #line default
    #line hidden
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Candidate;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Locations;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Login;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Register;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.VacancySearch;
    using SFA.Apprenticeships.Web.Common.Constants;
    using SFA.Apprenticeships.Web.Common.Framework;
    using SFA.Apprenticeships.Web.Common.Models.Common;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Settings.cshtml")]
    public partial class Settings : System.Web.Mvc.WebViewPage<SettingsViewModel>
    {
        public Settings()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 5 "..\..\Views\Account\Settings.cshtml"
  
    ViewBag.Title = "Settings - Find an apprenticeship";
    Layout = "~/Views/Shared/_Layout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"grid-wrapper\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"grid grid-1-2\"");

WriteLiteral(">\r\n        <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">Settings</h1>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"grid grid-1-2\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 14 "..\..\Views\Account\Settings.cshtml"
   Write(Html.RouteLink("Find an apprenticeship", CandidateRouteNames.ApprenticeshipSearch, null, new { id = "find-apprenticeship-link", @class = "page-link small-btm-margin" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 16 "..\..\Views\Account\Settings.cshtml"
        
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Account\Settings.cshtml"
         if (Model.TraineeshipFeature.ShowTraineeshipsLink)
        {
            
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Account\Settings.cshtml"
       Write(Html.RouteLink("Find a traineeship", CandidateRouteNames.TraineeshipSearch, null, new { id = "find-traineeship-link", @class = "page-link small-btm-margin" }));

            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Account\Settings.cshtml"
                                                                                                                                                                           
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n\r\n");

            
            #line 23 "..\..\Views\Account\Settings.cshtml"
 using (Html.BeginRouteForm(CandidateRouteNames.Settings, FormMethod.Post))
{
    
            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Account\Settings.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Account\Settings.cshtml"
                            
    
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Account\Settings.cshtml"
Write(Html.Partial("ValidationSummary", ViewData.ModelState));

            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Account\Settings.cshtml"
                                                           


            
            #line default
            #line hidden
WriteLiteral("    <fieldset>\r\n\r\n");

            
            #line 30 "..\..\Views\Account\Settings.cshtml"
        
            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\Account\Settings.cshtml"
          
            var yourAccountTabClass = Model.Mode == SettingsViewModel.SettingsMode.YourAccount ? " active" : "";
            var savedSearchesTabClass = Model.Mode == SettingsViewModel.SettingsMode.SavedSearches ? " active" : "";
        
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        <nav");

WriteLiteral(" class=\"tabbed-nav\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 36 "..\..\Views\Account\Settings.cshtml"
       Write(Html.RouteLink("Your account", CandidateRouteNames.Settings, null, new { @id = "your-account-tab-control", @class = "tabbed-tab no-js" + yourAccountTabClass, tab = "#tab1" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 37 "..\..\Views\Account\Settings.cshtml"
       Write(Html.RouteLink("Saved searches", CandidateRouteNames.SavedSearchesSettings, null, new { @id = "saved-searches-tab-control", @class = "tabbed-tab no-js" + savedSearchesTabClass, tab = "#tab2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </nav>\r\n\r\n");

WriteLiteral("        ");

            
            #line 40 "..\..\Views\Account\Settings.cshtml"
   Write(Html.HiddenFor(m => m.Mode));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        <div");

WriteAttribute("class", Tuple.Create(" class=\"", 1767), Tuple.Create("\"", 1810)
, Tuple.Create(Tuple.Create("", 1775), Tuple.Create("tabbed-content", 1775), true)
            
            #line 42 "..\..\Views\Account\Settings.cshtml"
, Tuple.Create(Tuple.Create(" ", 1789), Tuple.Create<System.Object, System.Int32>(yourAccountTabClass
            
            #line default
            #line hidden
, 1790), false)
);

WriteLiteral(">\r\n\r\n            <legend");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Personal details</legend>\r\n\r\n            <div");

WriteLiteral(" class=\"panel-indent\"");

WriteLiteral(">\r\n                <p");

WriteLiteral(" class=\"text\"");

WriteLiteral(">Any changes you make will be seen on draft or new applications. Submitted applic" +
"ations will continue to show your old details.</p>\r\n            </div>\r\n\r\n");

WriteLiteral("            ");

            
            #line 50 "..\..\Views\Account\Settings.cshtml"
       Write(Html.FormTextFor(m => m.Firstname, containerHtmlAttributes: new { @class = "form-group-compound" }, controlHtmlAttributes: new { type = "text", autocorrect = "off" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 51 "..\..\Views\Account\Settings.cshtml"
       Write(Html.FormTextFor(m => m.Lastname, controlHtmlAttributes: new { type = "text", autocorrect = "off" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 52 "..\..\Views\Account\Settings.cshtml"
       Write(Html.EditorFor(r => r.DateOfBirth));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 53 "..\..\Views\Account\Settings.cshtml"
       Write(Html.EditorFor(a => a.Address, new { AnalyticsDSCUri = "/settings/findaddress" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 54 "..\..\Views\Account\Settings.cshtml"
       Write(Html.FormTextFor(m => m.PhoneNumber, controlHtmlAttributes: new { @class = "form-control", type = "tel" }, verified: Model.VerifiedMobile));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <p");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Email</p>\r\n                <span");

WriteLiteral(" class=\"form-prepopped\"");

WriteLiteral(" id=\"settings-username\"");

WriteLiteral(">");

            
            #line 58 "..\..\Views\Account\Settings.cshtml"
                                                               Write(Model.Username);

            
            #line default
            #line hidden
WriteLiteral("</span><a");

WriteLiteral(" id=\"settings-change-username\"");

WriteLiteral(" class=\"inl-block\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2936), Tuple.Create("\"", 2980)
            
            #line 58 "..\..\Views\Account\Settings.cshtml"
                                                                   , Tuple.Create(Tuple.Create("", 2943), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(RouteNames.UpdateEmail)
            
            #line default
            #line hidden
, 2943), false)
);

WriteLiteral(">Change email address</a>\r\n            </div>\r\n\r\n");

            
            #line 61 "..\..\Views\Account\Settings.cshtml"
            
            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\Account\Settings.cshtml"
             if (!string.IsNullOrWhiteSpace(Model.PendingUsername))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Pending Email Update</p>\r\n                    <span");

WriteLiteral(" class=\"form-prepopped\"");

WriteLiteral(" id=\"settings-pending-username\"");

WriteLiteral(">");

            
            #line 65 "..\..\Views\Account\Settings.cshtml"
                                                                           Write(Model.PendingUsername);

            
            #line default
            #line hidden
WriteLiteral("</span><a");

WriteLiteral(" id=\"settings-confirm-username\"");

WriteLiteral(" class=\"inl-block\"");

WriteAttribute("href", Tuple.Create(" href=\"", 3384), Tuple.Create("\"", 3435)
            
            #line 65 "..\..\Views\Account\Settings.cshtml"
                                                                                       , Tuple.Create(Tuple.Create("", 3391), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(RouteNames.VerifyUpdatedEmail)
            
            #line default
            #line hidden
, 3391), false)
);

WriteLiteral(">Verify new email address</a>\r\n                </div>\r\n");

            
            #line 67 "..\..\Views\Account\Settings.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" id=\"accountSettings2\"");

WriteLiteral(">\r\n\r\n                <h3");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">How we contact you</h3>\r\n                <div");

WriteLiteral(" class=\"text para-btm-margin\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">\r\n                        Choose to be notified by <i");

WriteLiteral(" class=\"fa fa-envelope-o\"");

WriteLiteral("></i>email or<i");

WriteLiteral(" class=\"icon-sms\"");

WriteLiteral("></i>text when:\r\n                    </p>\r\n                    <div");

WriteLiteral(" class=\"display-table\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"display-table__row va-bottom\"");

WriteLiteral(">\r\n                            <a");

WriteLiteral(" id=\"emailToggle\"");

WriteLiteral(" href=\"\"");

WriteLiteral(" title=\"Email notifications\"");

WriteLiteral(" class=\"display-table__cell ta-center font-black\"");

WriteLiteral(">\r\n                                <span");

WriteLiteral(" class=\"notification-pulltop\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-envelope-o no-right-margin\"");

WriteLiteral("></i></span>\r\n                            </a>\r\n                            <a");

WriteLiteral(" id=\"textToggle\"");

WriteLiteral(" href=\"\"");

WriteLiteral(" title=\"Text notifications\"");

WriteLiteral(" class=\"display-table__cell ta-center\"");

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"icon-sms\"");

WriteLiteral("></i>\r\n                            </a>\r\n                            <span");

WriteLiteral(" class=\"display-table__cell ta-left\"");

WriteLiteral(">\r\n                            </span>\r\n                        </div>\r\n         " +
"               <div");

WriteLiteral(" class=\"display-table__row\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"display-table__cell ta-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 89 "..\..\Views\Account\Settings.cshtml"
                           Write(Html.FormUnvalidatedCheckBoxFor(m => m.EnableApplicationStatusChangeAlertsViaEmail,
                                    controlHtmlAttributes: new { @class = "no-margins email-input" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n                            <span");

WriteLiteral(" class=\"display-table__cell ta-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 93 "..\..\Views\Account\Settings.cshtml"
                           Write(Html.FormUnvalidatedCheckBoxFor(m => m.EnableApplicationStatusChangeAlertsViaText,
                                    labelHtmlAttributes: new { @class = "display-table__cell ta-left" },
                                    controlHtmlAttributes: new { @class = "no-margins text-input" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n                        </div>\r\n          " +
"              <div");

WriteLiteral(" class=\"display-table__row\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"display-table__cell ta-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 100 "..\..\Views\Account\Settings.cshtml"
                           Write(Html.FormUnvalidatedCheckBoxFor(m => m.EnableExpiringApplicationAlertsViaEmail,
                                    controlHtmlAttributes: new { @class = "no-margins email-input" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n                            <span");

WriteLiteral(" class=\"display-table__cell ta-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 104 "..\..\Views\Account\Settings.cshtml"
                           Write(Html.FormUnvalidatedCheckBoxFor(m => m.EnableExpiringApplicationAlertsViaText,
                                    labelHtmlAttributes: new { @class = "display-table__cell ta-left" },
                                    controlHtmlAttributes: new { @class = "no-margins text-input" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n                        </div>\r\n          " +
"              <div");

WriteLiteral(" class=\"display-table__row\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"display-table__cell ta-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 111 "..\..\Views\Account\Settings.cshtml"
                           Write(Html.FormUnvalidatedCheckBoxFor(m => m.EnableMarketingViaEmail,
                                    controlHtmlAttributes: new { @class = "no-margins email-input" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n                            <span");

WriteLiteral(" class=\"display-table__cell ta-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 115 "..\..\Views\Account\Settings.cshtml"
                           Write(Html.FormUnvalidatedCheckBoxFor(m => m.EnableMarketingViaText,
                                labelHtmlAttributes: new { @class = "display-table__cell ta-left" },
                                controlHtmlAttributes: new { @class = "no-margins text-input" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n                        </div>\r\n          " +
"          </div>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" id=\"update-details-button\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Save settings</button>\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteAttribute("class", Tuple.Create(" class=\"", 7404), Tuple.Create("\"", 7449)
, Tuple.Create(Tuple.Create("", 7412), Tuple.Create("tabbed-content", 7412), true)
            
            #line 128 "..\..\Views\Account\Settings.cshtml"
, Tuple.Create(Tuple.Create(" ", 7426), Tuple.Create<System.Object, System.Int32>(savedSearchesTabClass
            
            #line default
            #line hidden
, 7427), false)
);

WriteLiteral(">\r\n            <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(" id=\"savedSearchHeading\"");

WriteLiteral(">Saved searches</h2>\r\n            <div");

WriteLiteral(" class=\"form-group form-group-compound\"");

WriteLiteral(">\r\n                <p");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Receive notifications?</p>\r\n                <span");

WriteLiteral(" class=\"form-hint text\"");

WriteLiteral(">If you don\'t select an option you won\'t receive notifications</span>\r\n");

WriteLiteral("                ");

            
            #line 133 "..\..\Views\Account\Settings.cshtml"
           Write(Html.FormUnvalidatedCheckBoxFor(m => m.EnableSavedSearchAlertsViaEmail, labelHtmlAttributes: new { @class = "block-label allowSavedComms" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 134 "..\..\Views\Account\Settings.cshtml"
                
            
            #line default
            #line hidden
            
            #line 134 "..\..\Views\Account\Settings.cshtml"
                 if (Model.SmsEnabled)
                {
                    
            
            #line default
            #line hidden
            
            #line 136 "..\..\Views\Account\Settings.cshtml"
               Write(Html.FormUnvalidatedCheckBoxFor(m => m.EnableSavedSearchAlertsViaText, labelHtmlAttributes: new { @class = "block-label allowSavedComms" }));

            
            #line default
            #line hidden
            
            #line 136 "..\..\Views\Account\Settings.cshtml"
                                                                                                                                                                
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(" id=\"savedSearch\"");

WriteLiteral(">\r\n");

            
            #line 141 "..\..\Views\Account\Settings.cshtml"
                
            
            #line default
            #line hidden
            
            #line 141 "..\..\Views\Account\Settings.cshtml"
                  
                    var noSavedSearchesTextStyle = (Model.SavedSearches != null && Model.SavedSearches.Count > 0) ? "style=\"display: none\"" : "";
                
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                <p");

WriteLiteral(" class=\"savedInitalText text\"");

WriteLiteral(" id=\"noSavedSearchesText\"");

WriteLiteral(" ");

            
            #line 145 "..\..\Views\Account\Settings.cshtml"
                                                                    Write(Html.Raw(noSavedSearchesTextStyle));

            
            #line default
            #line hidden
WriteLiteral(">\r\n                    You currently don\'t have any active saved searches. If you" +
" <a");

WriteAttribute("href", Tuple.Create(" href=\"", 8633), Tuple.Create("\"", 8695)
            
            #line 146 "..\..\Views\Account\Settings.cshtml"
        , Tuple.Create(Tuple.Create("", 8640), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(CandidateRouteNames.ApprenticeshipSearch)
            
            #line default
            #line hidden
, 8640), false)
);

WriteLiteral(">set up a saved search</a> we can alert you when we find a suitable apprenticeshi" +
"p.\r\n                </p>\r\n\r\n");

            
            #line 149 "..\..\Views\Account\Settings.cshtml"
                
            
            #line default
            #line hidden
            
            #line 149 "..\..\Views\Account\Settings.cshtml"
                 if (Model.SavedSearches != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" id=\"savedSearches\"");

WriteLiteral(" class=\"toggle-content text\"");

WriteLiteral(" style=\"display: block;\"");

WriteLiteral(">\r\n");

            
            #line 152 "..\..\Views\Account\Settings.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 152 "..\..\Views\Account\Settings.cshtml"
                         for (var i = 0; i < Model.SavedSearches.Count; i++)
                        {
                            var index = i;
                            var savedSearch = Model.SavedSearches[i];
                            var checkedListItemClass = savedSearch.AlertsEnabled ? "class=\"selected\"" : "";


            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"para-btm-margin saved-search\"");

WriteAttribute("id", Tuple.Create(" id=\"", 9375), Tuple.Create("\"", 9395)
            
            #line 158 "..\..\Views\Account\Settings.cshtml"
, Tuple.Create(Tuple.Create("", 9380), Tuple.Create<System.Object, System.Int32>(savedSearch.Id
            
            #line default
            #line hidden
, 9380), false)
);

WriteLiteral(">\r\n                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 9433), Tuple.Create("\"", 9478)
            
            #line 159 "..\..\Views\Account\Settings.cshtml"
, Tuple.Create(Tuple.Create("", 9440), Tuple.Create<System.Object, System.Int32>(Html.Raw(savedSearch.SearchUrl.Value)
            
            #line default
            #line hidden
, 9440), false)
);

WriteLiteral(" title=\"Run search\"");

WriteLiteral(">");

            
            #line 159 "..\..\Views\Account\Settings.cshtml"
                                                                                               Write(savedSearch.Name);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 160 "..\..\Views\Account\Settings.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 160 "..\..\Views\Account\Settings.cshtml"
                                 if (savedSearch.DateProcessed.HasValue)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <span");

WriteLiteral(" class=\"inl-block font-xsmall\"");

WriteLiteral(">(Last alert: ");

            
            #line 162 "..\..\Views\Account\Settings.cshtml"
                                                                                Write(savedSearch.DateProcessed.Value.ToFriendlyDaysAgo());

            
            #line default
            #line hidden
WriteLiteral(")</span>\r\n");

            
            #line 163 "..\..\Views\Account\Settings.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                                <ul");

WriteLiteral(" class=\"list-text\"");

WriteLiteral(">\r\n");

            
            #line 165 "..\..\Views\Account\Settings.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 165 "..\..\Views\Account\Settings.cshtml"
                                     if (!string.IsNullOrEmpty(savedSearch.SubCategoriesFullNames))
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <li><b>Sub-categories:</b> ");

            
            #line 167 "..\..\Views\Account\Settings.cshtml"
                                                              Write(savedSearch.SubCategoriesFullNames);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 168 "..\..\Views\Account\Settings.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                    ");

            
            #line 169 "..\..\Views\Account\Settings.cshtml"
                                     if (savedSearch.ApprenticeshipLevel != "All")
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <li><b>Apprenticeship level:</b> ");

            
            #line 171 "..\..\Views\Account\Settings.cshtml"
                                                                    Write(savedSearch.ApprenticeshipLevel);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 172 "..\..\Views\Account\Settings.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                    <li ");

            
            #line 173 "..\..\Views\Account\Settings.cshtml"
                                   Write(Html.Raw(checkedListItemClass));

            
            #line default
            #line hidden
WriteLiteral(">\r\n");

WriteLiteral("                                        ");

            
            #line 174 "..\..\Views\Account\Settings.cshtml"
                                   Write(Html.HiddenFor(m => m.SavedSearches[index].Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                        ");

            
            #line 175 "..\..\Views\Account\Settings.cshtml"
                                   Write(Html.FormUnvalidatedCheckBoxFor(m => m.SavedSearches[index].AlertsEnabled, controlHtmlAttributes: new { @class = "no-left-margin" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </li>\r\n                                    " +
"<li>\r\n                                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 10896), Tuple.Create("\"", 10984)
            
            #line 178 "..\..\Views\Account\Settings.cshtml"
, Tuple.Create(Tuple.Create("", 10903), Tuple.Create<System.Object, System.Int32>(Url.Action("DeleteSavedSearch", new {id = savedSearch.Id, isJavascript = false})
            
            #line default
            #line hidden
, 10903), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 10985), Tuple.Create("\"", 11005)
            
            #line 178 "..\..\Views\Account\Settings.cshtml"
                                                       , Tuple.Create(Tuple.Create("", 10990), Tuple.Create<System.Object, System.Int32>(savedSearch.Id
            
            #line default
            #line hidden
, 10990), false)
);

WriteLiteral(" class=\"link-unimp icon-black delete-saved-search-link\"");

WriteLiteral(">\r\n                                            <i");

WriteLiteral(" class=\"fa fa-times-circle\"");

WriteLiteral("></i>Delete saved search\r\n                                        </a>\r\n         " +
"                           </li>\r\n                                </ul>\r\n       " +
"                     </div>\r\n");

            
            #line 184 "..\..\Views\Account\Settings.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n");

            
            #line 186 "..\..\Views\Account\Settings.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" id=\"update-details-button\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Save settings</button>\r\n                </div>\r\n            </div>\r\n        </di" +
"v>\r\n    </fieldset>\r\n");

            
            #line 194 "..\..\Views\Account\Settings.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n            $(\"#find-addresses\").address" +
"Lookup({\r\n                url: \'");

            
            #line 201 "..\..\Views\Account\Settings.cshtml"
                 Write(Url.Action("Addresses", "Location"));

            
            #line default
            #line hidden
WriteLiteral("\',\r\n                selectlist: \'#address-select\'\r\n            });\r\n\r\n           " +
" $(\".delete-saved-search-link\").on(\'click\', function () {\r\n                var $" +
"this = $(this),\r\n                    $href = $this.attr(\'href\').replace(\"isJavas" +
"cript=False\", \"isJavascript=true\").replace(\"isJavascript=false\", \"isJavascript=t" +
"rue\"),\r\n                    $id = $this.attr(\'id\');\r\n\r\n                $.ajax({\r" +
"\n                    url: $href,\r\n                    complete: function (result" +
") {\r\n\r\n                        if (result.status == 200) {\r\n                    " +
"        $(\"#\" + $id).hide();\r\n\r\n                            if ($(\".saved-search" +
":visible\").length == 0) {\r\n                                $(\"#noSavedSearchesTe" +
"xt\").show();\r\n                            }\r\n                        }\r\n        " +
"            }\r\n                });\r\n\r\n                return false;\r\n           " +
" });\r\n\r\n            function disableCommsChecks() {\r\n                if (!$(\'#Al" +
"lowEmailComms\').is(\':checked\') && !$(\'#AllowSmsComms\').is(\':checked\')) {\r\n      " +
"              $(\'#notificationPrefs\').find(\'input[type=\"checkbox\"]\').parent().ad" +
"dClass(\'disabled\');\r\n                } else {\r\n                    $(\'#notificat" +
"ionPrefs\').find(\'input[type=\"checkbox\"]\').parent().removeClass(\'disabled\');\r\n   " +
"             }\r\n            }\r\n\r\n            function disableSavedCommsChecks() " +
"{\r\n                if (!$(\'#EnableSavedSearchAlertsViaEmail\').is(\':checked\') && " +
"!$(\'#EnableSavedSearchAlertsViaText\').is(\':checked\')) {\r\n                    $(\'" +
"#savedSearches\').find(\'input[type=\"checkbox\"]\').parent().addClass(\'disabled\');\r\n" +
"                } else {\r\n                    $(\'#savedSearches\').find(\'input[ty" +
"pe=\"checkbox\"]\').parent().removeClass(\'disabled\');\r\n                }\r\n         " +
"   }\r\n\r\n            $(\'.allowCommsCheck\').on(\'click\', function () {\r\n           " +
"     disableCommsChecks();\r\n            });\r\n\r\n            $(\'.allowSavedComms\')" +
".on(\'click\', function () {\r\n                disableSavedCommsChecks();\r\n        " +
"    });\r\n\r\n            disableCommsChecks();\r\n            disableSavedCommsCheck" +
"s();\r\n        });\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591
