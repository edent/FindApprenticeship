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
       Write(Html.RouteLink("Your account", CandidateRouteNames.Settings, null, new { @id = "your-account-tab-control", @class = "tabbed-tab" + yourAccountTabClass, tab = "#tab1" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 37 "..\..\Views\Account\Settings.cshtml"
       Write(Html.RouteLink("Saved searches", CandidateRouteNames.SavedSearchesSettings, null, new { @id = "saved-searches-tab-control", @class = "tabbed-tab" + savedSearchesTabClass, tab = "#tab2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </nav>\r\n\r\n");

WriteLiteral("        ");

            
            #line 40 "..\..\Views\Account\Settings.cshtml"
   Write(Html.HiddenFor(m => m.Mode));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        <div");

WriteAttribute("class", Tuple.Create(" class=\"", 1755), Tuple.Create("\"", 1798)
, Tuple.Create(Tuple.Create("", 1763), Tuple.Create("tabbed-content", 1763), true)
            
            #line 42 "..\..\Views\Account\Settings.cshtml"
, Tuple.Create(Tuple.Create(" ", 1777), Tuple.Create<System.Object, System.Int32>(yourAccountTabClass
            
            #line default
            #line hidden
, 1778), false)
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
       Write(Html.HiddenFor(m => m.IsJavascript, new { @id = "hidden-flag-javascript" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 51 "..\..\Views\Account\Settings.cshtml"
       Write(Html.FormTextFor(m => m.Firstname, containerHtmlAttributes: new { @class = "form-group-compound" }, controlHtmlAttributes: new { type = "text", autocorrect = "off" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 52 "..\..\Views\Account\Settings.cshtml"
       Write(Html.FormTextFor(m => m.Lastname, controlHtmlAttributes: new { type = "text", autocorrect = "off" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 53 "..\..\Views\Account\Settings.cshtml"
       Write(Html.EditorFor(r => r.DateOfBirth));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 54 "..\..\Views\Account\Settings.cshtml"
       Write(Html.EditorFor(a => a.Address, new { AnalyticsDSCUri = "/settings/findaddress" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 55 "..\..\Views\Account\Settings.cshtml"
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

            
            #line 59 "..\..\Views\Account\Settings.cshtml"
                                                               Write(Model.Username);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                <a");

WriteLiteral(" id=\"settings-change-username\"");

WriteLiteral(" class=\"inl-block\"");

WriteAttribute("href", Tuple.Create(" href=\"", 3032), Tuple.Create("\"", 3076)
            
            #line 60 "..\..\Views\Account\Settings.cshtml"
, Tuple.Create(Tuple.Create("", 3039), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(RouteNames.UpdateEmail)
            
            #line default
            #line hidden
, 3039), false)
);

WriteLiteral(">Change email address</a>\r\n            </div>\r\n\r\n");

            
            #line 63 "..\..\Views\Account\Settings.cshtml"
            
            
            #line default
            #line hidden
            
            #line 63 "..\..\Views\Account\Settings.cshtml"
             if (!string.IsNullOrWhiteSpace(Model.PendingUsername))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Pending email address</p>\r\n                    <span");

WriteLiteral(" class=\"form-prepopped\"");

WriteLiteral(" id=\"settings-pending-username\"");

WriteLiteral(">");

            
            #line 67 "..\..\Views\Account\Settings.cshtml"
                                                                           Write(Model.PendingUsername);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    <a");

WriteLiteral(" id=\"settings-confirm-username\"");

WriteLiteral(" class=\"inl-block\"");

WriteAttribute("href", Tuple.Create(" href=\"", 3503), Tuple.Create("\"", 3554)
            
            #line 68 "..\..\Views\Account\Settings.cshtml"
, Tuple.Create(Tuple.Create("", 3510), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(RouteNames.VerifyUpdatedEmail)
            
            #line default
            #line hidden
, 3510), false)
);

WriteLiteral(">Verify email address</a>\r\n                </div>\r\n");

            
            #line 70 "..\..\Views\Account\Settings.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            \r\n            <details>\r\n                <summary");

WriteLiteral(" id=\"equality-diversity-summary-link\"");

WriteLiteral(">Your equality and diversity information</summary>\r\n                <div");

WriteLiteral(" class=\"detail-content\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 75 "..\..\Views\Account\Settings.cshtml"
               Write(Html.EditorFor(m => Model.MonitoringInformation, "MonitoringInformation/_gender"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 76 "..\..\Views\Account\Settings.cshtml"
               Write(Html.EditorFor(m => Model.MonitoringInformation, "MonitoringInformation/_disability"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 77 "..\..\Views\Account\Settings.cshtml"
               Write(Html.EditorFor(m => Model.MonitoringInformation, "MonitoringInformation/_ethnicity"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 78 "..\..\Views\Account\Settings.cshtml"
               Write(Html.EditorFor(m => Model.MonitoringInformation, "MonitoringInformation/_why"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </details>\r\n\r\n            <div");

WriteLiteral(" id=\"accountSettings2\"");

WriteLiteral(">\r\n                <h3");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">How we contact you</h3>\r\n                <div");

WriteLiteral(" class=\"text para-btm-margin\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">\r\n                        Choose to be notified by <i");

WriteLiteral(" class=\"fa fa-envelope-o no-right-margin\"");

WriteLiteral("></i> email or <i");

WriteLiteral(" class=\"icon-sms\"");

WriteLiteral("></i> text when:\r\n                    </p>\r\n                    <div");

WriteLiteral(" class=\"display-table\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"display-table__row va-bottom\"");

WriteLiteral(">\r\n                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" id=\"emailToggle\"");

WriteLiteral(" title=\"Email notifications\"");

WriteLiteral(" class=\"display-table__cell ta-center font-black\"");

WriteLiteral(">\r\n                                <span");

WriteLiteral(" class=\"notification-pulltop\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-envelope-o no-right-margin\"");

WriteLiteral("></i></span>\r\n                            </a>\r\n                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" id=\"textToggle\"");

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

            
            #line 101 "..\..\Views\Account\Settings.cshtml"
                           Write(Html.FormUnvalidatedCheckBoxFor(m => m.EnableApplicationStatusChangeAlertsViaEmail,
                                    controlHtmlAttributes: new { @class = "no-margins email-input", aria_labelledby = "appStatusLabel", title = "Email notifications when the status of one of your applications changes" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n                            <span");

WriteLiteral(" class=\"display-table__cell ta-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 105 "..\..\Views\Account\Settings.cshtml"
                           Write(Html.FormUnvalidatedCheckBoxFor(m => m.EnableApplicationStatusChangeAlertsViaText,
                                    controlHtmlAttributes: new { @class = "no-margins text-input", aria_labelledby = "appStatusLabel", title = "Text notifications when the status of one of your applications changes" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n                            <span");

WriteLiteral(" class=\"display-table__cell ta-left\"");

WriteLiteral(" id=\"appStatusLabel\"");

WriteLiteral(">\r\n                                the status of one of your applications changes" +
"\r\n                            </span>\r\n                        </div>\r\n         " +
"               <div");

WriteLiteral(" class=\"display-table__row\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"display-table__cell ta-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 114 "..\..\Views\Account\Settings.cshtml"
                           Write(Html.FormUnvalidatedCheckBoxFor(m => m.EnableExpiringApplicationAlertsViaEmail,
                                    controlHtmlAttributes: new { @class = "no-margins email-input", aria_labelledby = "closingDateStatusLabel", title = "Email notifications when an apprenticeship is approaching its closing date" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n                            <span");

WriteLiteral(" class=\"display-table__cell ta-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 118 "..\..\Views\Account\Settings.cshtml"
                           Write(Html.FormUnvalidatedCheckBoxFor(m => m.EnableExpiringApplicationAlertsViaText,
                                    controlHtmlAttributes: new { @class = "no-margins text-input", aria_labelledby = "closingDateStatusLabel", title = "Text notifications when an apprenticeship is approaching its closing date" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n                            <span");

WriteLiteral(" class=\"display-table__cell ta-left\"");

WriteLiteral(" id=\"closingDateStatusLabel\"");

WriteLiteral(">\r\n                                an apprenticeship is approaching its closing d" +
"ate\r\n                            </span>\r\n                        </div>\r\n      " +
"                  <div");

WriteLiteral(" class=\"display-table__row\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"display-table__cell ta-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 127 "..\..\Views\Account\Settings.cshtml"
                           Write(Html.FormUnvalidatedCheckBoxFor(m => m.EnableMarketingViaEmail,
                                    controlHtmlAttributes: new { @class = "no-margins email-input", aria_labelledby = "marketingUpdatesStatusLabel", title = "Email notifications when we send you updates on news and information" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n                            <span");

WriteLiteral(" class=\"display-table__cell ta-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 131 "..\..\Views\Account\Settings.cshtml"
                           Write(Html.FormUnvalidatedCheckBoxFor(m => m.EnableMarketingViaText,
                                    controlHtmlAttributes: new { @class = "no-margins text-input", aria_labelledby = "marketingUpdatesStatusLabel", title = "Text notifications when we send you updates on news and information" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n                            <span");

WriteLiteral(" class=\"display-table__cell ta-left\"");

WriteLiteral(" id=\"marketingUpdatesStatusLabel\"");

WriteLiteral(">\r\n                                we send you updates on news and information\r\n " +
"                           </span>\r\n                        </div>\r\n            " +
"        </div>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" id=\"update-details-button\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Save settings</button>\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteAttribute("class", Tuple.Create(" class=\"", 9293), Tuple.Create("\"", 9338)
, Tuple.Create(Tuple.Create("", 9301), Tuple.Create("tabbed-content", 9301), true)
            
            #line 146 "..\..\Views\Account\Settings.cshtml"
, Tuple.Create(Tuple.Create(" ", 9315), Tuple.Create<System.Object, System.Int32>(savedSearchesTabClass
            
            #line default
            #line hidden
, 9316), false)
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

            
            #line 151 "..\..\Views\Account\Settings.cshtml"
           Write(Html.FormUnvalidatedCheckBoxFor(m => m.EnableSavedSearchAlertsViaEmail, labelHtmlAttributes: new { @class = "block-label allowSavedComms" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 152 "..\..\Views\Account\Settings.cshtml"
                
            
            #line default
            #line hidden
            
            #line 152 "..\..\Views\Account\Settings.cshtml"
                 if (Model.SmsEnabled)
                {
                    
            
            #line default
            #line hidden
            
            #line 154 "..\..\Views\Account\Settings.cshtml"
               Write(Html.FormUnvalidatedCheckBoxFor(m => m.EnableSavedSearchAlertsViaText, labelHtmlAttributes: new { @class = "block-label allowSavedComms" }));

            
            #line default
            #line hidden
            
            #line 154 "..\..\Views\Account\Settings.cshtml"
                                                                                                                                                                
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(" id=\"savedSearch\"");

WriteLiteral(">\r\n");

            
            #line 159 "..\..\Views\Account\Settings.cshtml"
                
            
            #line default
            #line hidden
            
            #line 159 "..\..\Views\Account\Settings.cshtml"
                  
                    var noSavedSearchesTextStyle = (Model.SavedSearches != null && Model.SavedSearches.Count > 0) ? "style=\"display: none\"" : "";
                
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                <p");

WriteLiteral(" class=\"savedInitalText text\"");

WriteLiteral(" id=\"noSavedSearchesText\"");

WriteLiteral(" ");

            
            #line 163 "..\..\Views\Account\Settings.cshtml"
                                                                    Write(Html.Raw(noSavedSearchesTextStyle));

            
            #line default
            #line hidden
WriteLiteral(">\r\n                    You currently don\'t have any active saved searches. If you" +
" <a");

WriteAttribute("href", Tuple.Create(" href=\"", 10522), Tuple.Create("\"", 10584)
            
            #line 164 "..\..\Views\Account\Settings.cshtml"
       , Tuple.Create(Tuple.Create("", 10529), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(CandidateRouteNames.ApprenticeshipSearch)
            
            #line default
            #line hidden
, 10529), false)
);

WriteLiteral(">set up a saved search</a> we can alert you when we find a suitable apprenticeshi" +
"p.\r\n                </p>\r\n\r\n");

            
            #line 167 "..\..\Views\Account\Settings.cshtml"
                
            
            #line default
            #line hidden
            
            #line 167 "..\..\Views\Account\Settings.cshtml"
                 if (Model.SavedSearches != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" id=\"savedSearches\"");

WriteLiteral(" class=\"toggle-content text\"");

WriteLiteral(" style=\"display: block;\"");

WriteLiteral(">\r\n");

            
            #line 170 "..\..\Views\Account\Settings.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 170 "..\..\Views\Account\Settings.cshtml"
                         for (var i = 0; i < Model.SavedSearches.Count; i++)
                        {
                            var index = i;
                            var savedSearch = Model.SavedSearches[i];
                            var checkedListItemClass = savedSearch.AlertsEnabled ? "class=\"selected\"" : "";


            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"para-btm-margin saved-search\"");

WriteAttribute("id", Tuple.Create(" id=\"", 11268), Tuple.Create("\"", 11288)
            
            #line 176 "..\..\Views\Account\Settings.cshtml"
, Tuple.Create(Tuple.Create("", 11273), Tuple.Create<System.Object, System.Int32>(savedSearch.Id
            
            #line default
            #line hidden
, 11273), false)
);

WriteLiteral(">\r\n                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 11326), Tuple.Create("\"", 11371)
            
            #line 177 "..\..\Views\Account\Settings.cshtml"
, Tuple.Create(Tuple.Create("", 11333), Tuple.Create<System.Object, System.Int32>(Html.Raw(savedSearch.SearchUrl.Value)
            
            #line default
            #line hidden
, 11333), false)
);

WriteLiteral(" title=\"Run search\"");

WriteLiteral(">");

            
            #line 177 "..\..\Views\Account\Settings.cshtml"
                                                                                               Write(savedSearch.Name);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 178 "..\..\Views\Account\Settings.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 178 "..\..\Views\Account\Settings.cshtml"
                                 if (savedSearch.DateProcessed.HasValue)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <span");

WriteLiteral(" class=\"inl-block font-xsmall\"");

WriteLiteral(">(Last alert: ");

            
            #line 180 "..\..\Views\Account\Settings.cshtml"
                                                                                Write(savedSearch.DateProcessed.Value.ToFriendlyDaysAgo());

            
            #line default
            #line hidden
WriteLiteral(")</span>\r\n");

            
            #line 181 "..\..\Views\Account\Settings.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                                <ul");

WriteLiteral(" class=\"list-text\"");

WriteLiteral(">\r\n");

            
            #line 183 "..\..\Views\Account\Settings.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 183 "..\..\Views\Account\Settings.cshtml"
                                     if (!string.IsNullOrEmpty(savedSearch.SubCategoriesFullNames))
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <li><b>Sub-categories:</b> ");

            
            #line 185 "..\..\Views\Account\Settings.cshtml"
                                                              Write(savedSearch.SubCategoriesFullNames);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 186 "..\..\Views\Account\Settings.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                    ");

            
            #line 187 "..\..\Views\Account\Settings.cshtml"
                                     if (savedSearch.ApprenticeshipLevel != "All")
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <li><b>Apprenticeship level:</b> ");

            
            #line 189 "..\..\Views\Account\Settings.cshtml"
                                                                    Write(savedSearch.ApprenticeshipLevel);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 190 "..\..\Views\Account\Settings.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                    <li ");

            
            #line 191 "..\..\Views\Account\Settings.cshtml"
                                   Write(Html.Raw(checkedListItemClass));

            
            #line default
            #line hidden
WriteLiteral(">\r\n");

WriteLiteral("                                        ");

            
            #line 192 "..\..\Views\Account\Settings.cshtml"
                                   Write(Html.HiddenFor(m => m.SavedSearches[index].Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                        ");

            
            #line 193 "..\..\Views\Account\Settings.cshtml"
                                   Write(Html.FormUnvalidatedCheckBoxFor(m => m.SavedSearches[index].AlertsEnabled, controlHtmlAttributes: new { @class = "no-left-margin" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </li>\r\n                                    " +
"<li>\r\n                                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 12789), Tuple.Create("\"", 12877)
            
            #line 196 "..\..\Views\Account\Settings.cshtml"
, Tuple.Create(Tuple.Create("", 12796), Tuple.Create<System.Object, System.Int32>(Url.Action("DeleteSavedSearch", new {id = savedSearch.Id, isJavascript = false})
            
            #line default
            #line hidden
, 12796), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 12878), Tuple.Create("\"", 12898)
            
            #line 196 "..\..\Views\Account\Settings.cshtml"
                                                       , Tuple.Create(Tuple.Create("", 12883), Tuple.Create<System.Object, System.Int32>(savedSearch.Id
            
            #line default
            #line hidden
, 12883), false)
);

WriteLiteral(" class=\"link-unimp icon-black delete-saved-search-link\"");

WriteLiteral(">\r\n                                            <i");

WriteLiteral(" class=\"fa fa-times-circle\"");

WriteLiteral("></i>Delete saved search\r\n                                        </a>\r\n         " +
"                           </li>\r\n                                </ul>\r\n       " +
"                     </div>\r\n");

            
            #line 202 "..\..\Views\Account\Settings.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n");

            
            #line 204 "..\..\Views\Account\Settings.cshtml"
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

            
            #line 212 "..\..\Views\Account\Settings.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 216 "..\..\Views\Account\Settings.cshtml"
Write(Scripts.Render("~/bundles/nas/account"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n    <script>\r\n        $(function () {\r\n\r\n            $(\".delete-saved-searc" +
"h-link\").on(\'click\', function () {\r\n                var $this = $(this),\r\n      " +
"              $href = $this.attr(\'href\').replace(\"isJavascript=False\", \"isJavasc" +
"ript=true\").replace(\"isJavascript=false\", \"isJavascript=true\"),\r\n               " +
"     $id = $this.attr(\'id\');\r\n\r\n                $.ajax({\r\n                    ur" +
"l: $href,\r\n                    complete: function (result) {\r\n\r\n                " +
"        if (result.status == 200) {\r\n                            $(\"#\" + $id).hi" +
"de();\r\n\r\n                            if ($(\".saved-search:visible\").length == 0)" +
" {\r\n                                $(\"#noSavedSearchesText\").show();\r\n         " +
"                   }\r\n                        }\r\n                    }\r\n        " +
"        });\r\n\r\n                return false;\r\n            });\r\n\r\n            $(\'" +
"#emailToggle\').on(\'click\', function () {\r\n                var theTable = $(this)" +
".closest(\'.display-table\');\r\n\r\n                if (theTable.find(\'.email-input:c" +
"hecked\').length == 3) {\r\n                    theTable.find(\'.email-input:checked" +
"\').click();\r\n                } else {\r\n                    theTable.find(\'.email" +
"-input:not(:checked)\').click();\r\n                }\r\n\r\n                $(this).bl" +
"ur();\r\n\r\n                return false;\r\n\r\n            });\r\n\r\n            $(\'#tex" +
"tToggle\').on(\'click\', function () {\r\n                var theTable = $(this).clos" +
"est(\'.display-table\');\r\n\r\n                if (theTable.find(\'.text-input:checked" +
"\').length == 3) {\r\n                    theTable.find(\'.text-input:checked\').clic" +
"k();\r\n                } else {\r\n                    theTable.find(\'.text-input:n" +
"ot(:checked)\').click();\r\n                }\r\n\r\n                $(this).blur();\r\n\r" +
"\n                return false;\r\n\r\n            });\r\n\r\n            if ($(\'#disabil" +
"ity-support-yes\').is(\':checked\')) {\r\n                $(\'#equality-diversity-summ" +
"ary-link\').click();\r\n            }\r\n\r\n            document.getElementById(\"hidde" +
"n-flag-javascript\").value = \"True\";\r\n        });\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591
