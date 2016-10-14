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

namespace SFA.Apprenticeships.Web.Raa.Common.Views.Shared.DisplayTemplates.Vacancy
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
    
    #line 2 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
    using SFA.Apprenticeships.Domain.Entities.Raa.Vacancies;
    
    #line default
    #line hidden
    using SFA.Apprenticeships.Infrastructure.Presentation;
    using SFA.Apprenticeships.Web.Common.Constants;
    using SFA.Apprenticeships.Web.Common.Framework;
    using SFA.Apprenticeships.Web.Common.Models.Common;
    using SFA.Apprenticeships.Web.Raa.Common;
    
    #line 3 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
    using SFA.Apprenticeships.Web.Raa.Common.Constants.ViewModels;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
    using SFA.Apprenticeships.Web.Raa.Common.Extensions;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
    using SFA.Apprenticeships.Web.Raa.Common.ViewModels.Vacancy;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/DisplayTemplates/Vacancy/BasicVacancyDetails.cshtml")]
    public partial class BasicVacancyDetails : System.Web.Mvc.WebViewPage<NewVacancyViewModel>
    {
        public BasicVacancyDetails()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 7 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
  
    ViewBag.Title = "Recruit an Apprentice - Select framework and level";

    const string selected = "selected";

    var isApplicationThroughRAAYes = (Model.OfflineVacancy.HasValue && !Model.OfflineVacancy.Value) ? selected : null;
    var isApplicationThroughRAANo = (Model.OfflineVacancy.HasValue && Model.OfflineVacancy.Value) ? selected : null;


            
            #line default
            #line hidden
WriteLiteral("    <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n        Enter basic vacancy details\r\n    </h1>\r\n");

            
            #line 18 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"

    
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                            
    
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
Write(Html.HiddenFor(m => m.IsEmployerLocationMainApprenticeshipLocation));

            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                                                        
    
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
Write(Html.HiddenFor(m => m.NumberOfPositions));

            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                             
    
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
Write(Html.HiddenFor(m => m.ComeFromPreview));

            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                           
    
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
Write(Html.HiddenFor(m => m.VacancySource));

            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                         
    
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
Write(Html.Partial("ValidationSummary", ViewData.ModelState));

            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                                           

    
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
Write(Html.FormTextAreaFor(m => m.Title, controlHtmlAttributes: new {type = "text", size = 12, @class = "width-all-1-1 form-textarea-small"}));

            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                                                                                                                            
    
            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
Write(Html.EditorFor(m => m.TitleComment, "Comment", Html.GetLabelFor(m => m.TitleComment)));

            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                                                                          
    
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
Write(Html.ValidationMessageFor(m => m.TitleComment));

            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                                   

    
            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
Write(Html.FormTextAreaFor(m => m.ShortDescription, controlHtmlAttributes: new {type = "text", size = 12, @class = "width-all-1-1 form-textarea-medium"}));

            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                                                                                                                                        
    
            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
Write(Html.EditorFor(m => m.ShortDescriptionComment, "Comment", Html.GetLabelFor(m => m.ShortDescriptionComment)));

            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                                                                                                
    
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
Write(Html.ValidationMessageFor(m => m.ShortDescriptionComment));

            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                                              


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 1648), Tuple.Create("\"", 1791)
, Tuple.Create(Tuple.Create("", 1656), Tuple.Create("form-group", 1656), true)
            
            #line 34 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
, Tuple.Create(Tuple.Create(" ", 1666), Tuple.Create<System.Object, System.Int32>(SFA.Apprenticeships.Web.Common.Framework.HtmlExtensions.GetValidationCssClass(Html.GetValidationType(m => m.VacancyType))
            
            #line default
            #line hidden
, 1667), false)
);

WriteLiteral(">\r\n        <a");

WriteAttribute("name", Tuple.Create(" name=\"", 1805), Tuple.Create("\"", 1866)
            
            #line 35 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
, Tuple.Create(Tuple.Create("", 1812), Tuple.Create<System.Object, System.Int32>(Html.NameFor(m => m.VacancyType).ToString().ToLower()
            
            #line default
            #line hidden
, 1812), false)
);

WriteLiteral("></a>\r\n        <label");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Vacancy type</label>\r\n        ");

WriteLiteral("\r\n        <label");

WriteLiteral(" for=\"vacancy-type-apprenticeship\"");

WriteLiteral(" class=\"block-label\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 39 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
       Write(Html.RadioButtonFor(model => model.VacancyType, VacancyType.Apprenticeship, new { id = "vacancy-type-apprenticeship", aria_labelledby = "vacancy-type-label" }));

            
            #line default
            #line hidden
WriteLiteral(" Apprenticeship\r\n        </label>\r\n        ");

WriteLiteral("\r\n        <label");

WriteLiteral(" for=\"vacancy-type-traineeship\"");

WriteLiteral(" class=\"block-label\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 43 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
       Write(Html.RadioButtonFor(model => model.VacancyType, VacancyType.Traineeship, new { id = "vacancy-type-traineeship", aria_labelledby = "vacancy-type-label" }));

            
            #line default
            #line hidden
WriteLiteral(" Traineeship\r\n        </label>\r\n");

WriteLiteral("        ");

            
            #line 45 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
   Write(Html.ValidationMessageFor(m => m.VacancyType));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 47 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"blocklabel-single-container\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"form-group inline clearfix blocklabel-single form-group-compound\"");

WriteLiteral(">\r\n                <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(">Manage application method</h3>\r\n                <p>\r\n                    How wil" +
"l candidates apply for this vacancy?\r\n                </p>\r\n                ");

WriteLiteral("\r\n                <label");

WriteLiteral(" for=\"apprenticeship-online-vacancy\"");

WriteLiteral(" class=\"block-label\"");

WriteLiteral(" data-target=\"online-panel\"");

WriteLiteral(" ");

            
            #line 56 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                                                                                     Write(isApplicationThroughRAAYes);

            
            #line default
            #line hidden
WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 57 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
               Write(Html.RadioButtonFor(model => model.OfflineVacancy, false, new {id = "apprenticeship-online-vacancy", aria_labelledby = "apprenticeship-vacancy-management-type-label"}));

            
            #line default
            #line hidden
WriteLiteral(" Candidates will apply on this website\r\n                </label>\r\n\r\n             " +
"   ");

WriteLiteral("\r\n                <label");

WriteLiteral(" for=\"apprenticeship-offline-vacancy\"");

WriteLiteral(" class=\"block-label\"");

WriteLiteral(" data-target=\"offline-panel\"");

WriteLiteral(" ");

            
            #line 61 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                                                                                       Write(isApplicationThroughRAANo);

            
            #line default
            #line hidden
WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 62 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
               Write(Html.RadioButtonFor(model => model.OfflineVacancy, true, new {id = "apprenticeship-offline-vacancy", aria_labelledby = "apprenticeship-vacancy-management-type-label", aria_controls = "offline-panel"}));

            
            #line default
            #line hidden
WriteLiteral(" Candidates will apply through an external website\r\n                </label>\r\n");

WriteLiteral("                ");

            
            #line 64 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
           Write(Html.ValidationMessageFor(m => m.OfflineVacancy));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"hide-js\"");

WriteLiteral(">Only answer if the vacancy applications will be managed through an external webs" +
"ite:</div>\r\n            <div");

WriteLiteral(" id=\"offline-panel\"");

WriteLiteral(" class=\"toggle-content panel-indent blocklabel-content\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 4342), Tuple.Create("\"", 4495)
, Tuple.Create(Tuple.Create("", 4350), Tuple.Create("form-group", 4350), true)
            
            #line 69 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
, Tuple.Create(Tuple.Create(" ", 4360), Tuple.Create<System.Object, System.Int32>(SFA.Apprenticeships.Web.Common.Framework.HtmlExtensions.GetValidationCssClass(Html.GetValidationType(m => m.OfflineApplicationUrl))
            
            #line default
            #line hidden
, 4361), false)
);

WriteLiteral(">\r\n                        <a");

WriteAttribute("name", Tuple.Create(" name=\"", 4525), Tuple.Create("\"", 4596)
            
            #line 70 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
, Tuple.Create(Tuple.Create("", 4532), Tuple.Create<System.Object, System.Int32>(Html.NameFor(m => m.OfflineApplicationUrl).ToString().ToLower()
            
            #line default
            #line hidden
, 4532), false)
);

WriteLiteral("></a>\r\n");

WriteLiteral("                        ");

            
            #line 71 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                   Write(Html.LabelFor(m => m.OfflineApplicationUrl));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 72 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 72 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                         if (Model.IsEmployerLocationMainApprenticeshipLocation != true && Model.LocationAddresses != null && Model.LocationAddresses.Count > 1)
                        {
                            if (Model.OfflineVacancyType == OfflineVacancyType.MultiUrl)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <p");

WriteLiteral(" class=\"inline-text\"");

WriteLiteral(">Alternatively, <button");

WriteLiteral(" id=\"single-offline-application-url-button\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button-link no-autosave\"");

WriteLiteral(" name=\"CreateVacancy\"");

WriteLiteral(" value=\"SingleOfflineApplicationUrl\"");

WriteLiteral(">use the same web address for all vacancy locations</button></p>\r\n");

            
            #line 77 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <p");

WriteLiteral(" class=\"inline-text\"");

WriteLiteral(">Alternatively, you can <button");

WriteLiteral(" id=\"multiple-offline-application-urls-button\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button-link no-autosave\"");

WriteLiteral(" name=\"CreateVacancy\"");

WriteLiteral(" value=\"MultipleOfflineApplicationUrls\"");

WriteLiteral(">enter a different web address for each vacancy location</button></p>\r\n");

            
            #line 81 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                            }
                        }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 83 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                         if (Model.OfflineVacancyType == OfflineVacancyType.MultiUrl && Model.LocationAddresses != null)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <table");

WriteLiteral(" id=\"multiple-apprenticeship-offline-application-urls-table\"");

WriteLiteral(">\r\n                                <colgroup>\r\n                                  " +
"  <col");

WriteLiteral(" class=\"t30\"");

WriteLiteral(">\r\n                                    <col");

WriteLiteral(" class=\"t20\"");

WriteLiteral(">\r\n                                    <col");

WriteLiteral(" class=\"t50\"");

WriteLiteral(@">
                                </colgroup>
                                <thead>
                                    <tr>
                                        <th>Location</th>
                                        <th>Number of positions</th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody");

WriteLiteral(" id=\"location-addresses\"");

WriteLiteral(">\r\n");

            
            #line 99 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 99 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                     for (var i=0; i<Model.LocationAddresses.Count; i++)
                                    {
                                        var locationAddress = Model.LocationAddresses[i];

            
            #line default
            #line hidden
WriteLiteral("                                        <tr>\r\n                                   " +
"         <td");

WriteLiteral(" class=\"location-address\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                ");

            
            #line 104 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                           Write(locationAddress.Address.AddressLine1);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 105 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                                
            
            #line default
            #line hidden
            
            #line 105 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                                 if (!string.IsNullOrWhiteSpace(@locationAddress.Address.AddressLine2))
                                                {

            
            #line default
            #line hidden
WriteLiteral("                                                    <br />");

            
            #line 107 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                                          
            
            #line default
            #line hidden
            
            #line 107 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                                     Write(locationAddress.Address.AddressLine2);

            
            #line default
            #line hidden
            
            #line 107 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                                                                               
                                                }

            
            #line default
            #line hidden
WriteLiteral("                                                <br />");

            
            #line 109 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                                 Write(locationAddress.Address.AddressLine4);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 109 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                                                                       Write(locationAddress.Address.Postcode);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                            </td>\r\n                            " +
"                <td");

WriteLiteral(" class=\"location-positions\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                ");

            
            #line 112 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                           Write(locationAddress.NumberOfPositions);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                            </td>\r\n                            " +
"                <td");

WriteLiteral(" class=\"location-offline-urls\"");

WriteLiteral(">\r\n                                                <div");

WriteAttribute("class", Tuple.Create(" class=\"", 7918), Tuple.Create("\"", 8084)
            
            #line 115 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
, Tuple.Create(Tuple.Create("", 7926), Tuple.Create<System.Object, System.Int32>(SFA.Apprenticeships.Web.Common.Framework.HtmlExtensions.GetValidationCssClass(Html.GetValidationType("LocationAddresses[" + i + "].OfflineApplicationUrl"))
            
            #line default
            #line hidden
, 7926), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                                    ");

            
            #line 116 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                               Write(Html.Hidden("LocationAddresses[" + i + "].VacancyLocationId", locationAddress.VacancyLocationId));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                                    ");

            
            #line 117 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                               Write(Html.TextBox("LocationAddresses[" + i + "].OfflineApplicationUrl", locationAddress.OfflineApplicationUrl, new {@class = "width-all-1-1 form-control", type = "text", size = 12}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                                    ");

            
            #line 118 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                               Write(Html.ValidationMessage("LocationAddresses[" + i + "].OfflineApplicationUrl"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                </div>\r\n                       " +
"                     </td>\r\n                                        </tr>\r\n");

            
            #line 122 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </tbody>\r\n                            </table>\r\n");

            
            #line 125 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                        }
                        else
                        {
                            
            
            #line default
            #line hidden
            
            #line 128 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                       Write(Html.TextBoxFor(m => m.OfflineApplicationUrl, new { @class = "width-all-1-1 form-control", type = "text", size = 12, id = "apprenticeship-offline-application-url" }));

            
            #line default
            #line hidden
            
            #line 128 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                                                                                                                                                                                  
                            
            
            #line default
            #line hidden
            
            #line 129 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                       Write(Html.ValidationMessageFor(m => m.OfflineApplicationUrl));

            
            #line default
            #line hidden
            
            #line 129 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                                                                    
                        }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 131 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                   Write(Html.EditorFor(m => m.OfflineApplicationUrlComment, "Comment", Html.GetLabelFor(m => m.OfflineApplicationUrlComment)));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 132 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                   Write(Html.ValidationMessageFor(m => m.OfflineApplicationUrlComment));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    ");

WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 137 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
               Write(Html.FormTextAreaFor(m => m.OfflineApplicationInstructions, controlHtmlAttributes: new {type = "text", size = 12, @class = "width-all-1-1 form-textarea-medium", id = "apprenticheship-offline-application-instructions"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 138 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
               Write(Html.EditorFor(m => m.OfflineApplicationInstructionsComment, "Comment", Html.GetLabelFor(m => m.OfflineApplicationInstructionsComment)));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 139 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
               Write(Html.ValidationMessageFor(m => m.OfflineApplicationInstructionsComment));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <br/>\r\n                </div>\r\n            </div>\r\n        " +
"</div>\r\n    </div>\r\n");

            
            #line 145 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"

    
            
            #line default
            #line hidden
            
            #line 146 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
Write(Html.HiddenFor(model => model.VacancyReferenceNumber));

            
            #line default
            #line hidden
            
            #line 146 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                                          
    
            
            #line default
            #line hidden
            
            #line 147 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
Write(Html.HiddenFor(model => model.Ukprn));

            
            #line default
            #line hidden
            
            #line 147 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                         
    
            
            #line default
            #line hidden
            
            #line 148 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
Write(Html.HiddenFor(model => model.VacancyOwnerRelationship.VacancyOwnerRelationshipId));

            
            #line default
            #line hidden
            
            #line 148 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                                                                       
    
            
            #line default
            #line hidden
            
            #line 149 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
Write(Html.HiddenFor(model => model.VacancyGuid));

            
            #line default
            #line hidden
            
            #line 149 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                               
    
            
            #line default
            #line hidden
            
            #line 150 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
Write(Html.HiddenFor(model => model.Status));

            
            #line default
            #line hidden
            
            #line 150 "..\..\Views\Shared\DisplayTemplates\Vacancy\BasicVacancyDetails.cshtml"
                                          

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
