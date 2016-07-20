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
    
    #line 2 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
    using SFA.Apprenticeships.Domain.Entities.Raa.Vacancies;
    
    #line default
    #line hidden
    using SFA.Apprenticeships.Infrastructure.Presentation;
    using SFA.Apprenticeships.Web.Common.Constants;
    
    #line 3 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
    using SFA.Apprenticeships.Web.Common.Extensions;
    
    #line default
    #line hidden
    using SFA.Apprenticeships.Web.Common.Framework;
    using SFA.Apprenticeships.Web.Common.Models.Common;
    
    #line 4 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
    using SFA.Apprenticeships.Web.Common.Validators.Extensions;
    
    #line default
    #line hidden
    using SFA.Apprenticeships.Web.Raa.Common;
    
    #line 5 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
    using SFA.Apprenticeships.Web.Raa.Common.Constants.ViewModels;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
    using SFA.Apprenticeships.Web.Raa.Common.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/DisplayTemplates/Vacancy/FurtherVacancyDetails.cshtml")]
    public partial class FurtherVacancyDetails : System.Web.Mvc.WebViewPage<SFA.Apprenticeships.Web.Raa.Common.ViewModels.Vacancy.FurtherVacancyDetailsViewModel>
    {
        public FurtherVacancyDetails()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 8 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
  
    var heading = Model.VacancyType == VacancyType.Traineeship ? "Enter opportunity details" : "Enter further details";
    ViewBag.Title = "Recruit an Apprentice - " + heading;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h1");

WriteLiteral(" id=\"heading\"");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">");

            
            #line 13 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
                                   Write(heading);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n\r\n");

            
            #line 15 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 16 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
Write(Html.Partial("ValidationSummary", ViewData.ModelState));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 18 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
Write(Html.HiddenFor(m => m.VacancyReferenceNumber));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 19 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
Write(Html.HiddenFor(m => m.Status));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 20 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
Write(Html.HiddenFor(m => m.VacancyType));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 21 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
Write(Html.HiddenFor(m => m.WarningsHash));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 22 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
Write(Html.HiddenFor(m => m.ComeFromPreview));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<section>\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <fieldset");

WriteLiteral(" class=\"form-group inline-fixed\"");

WriteLiteral(">\r\n");

            
            #line 27 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
            
            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
              
                var workingWeeklabelText = Model.VacancyType == VacancyType.Traineeship ? VacancyViewModelMessages.WorkingWeek.TraineeshipLabelText : null;
                var workingWeekDataValLength = Model.VacancyType == VacancyType.Traineeship ? VacancyViewModelMessages.WorkingWeek.TraineeshipTooLongErrorText : VacancyViewModelMessages.WorkingWeek.TooLongErrorText;
                var workingWeekDataValRegex = Model.VacancyType == VacancyType.Traineeship ? VacancyViewModelMessages.WorkingWeek.TraineeshipWhiteListErrorText : VacancyViewModelMessages.WorkingWeek.WhiteListErrorText;
            
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 32 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
       Write(Html.FormTextAreaFor(m => m.WorkingWeek, workingWeeklabelText, containerHtmlAttributes: new {@baseClassName = "working-week"}, controlHtmlAttributes: new {@class = "width-all-1-1", type = "text", size = 12, data_val_length = workingWeekDataValLength, data_val_regex = workingWeekDataValRegex }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </fieldset>\r\n");

            
            #line 34 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
         if (Model.VacancyType == VacancyType.Traineeship)
        {
            
            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
       Write(Html.HiddenFor(m => m.HoursPerWeek));

            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
                                                
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <fieldset");

WriteLiteral(" class=\"form-group inline-fixed\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 41 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
           Write(Html.FormTextFor(m => m.HoursPerWeek, controlHtmlAttributes: new {@class = "form-control-small", type = "tel", size = 12}, containerHtmlAttributes: new {style = "margin-bottom: 15px"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </fieldset>\r\n");

            
            #line 43 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">");

            
            #line 44 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
                           Write(Html.EditorFor(m => m.WorkingWeekComment, "Comment", Html.GetLabelFor(m => m.WorkingWeekComment, Model.VacancyType == VacancyType.Traineeship ? VacancyViewModelMessages.WorkingWeekComment.TraineeshipLabelText : null)));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

            
            #line 46 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
         if (Model.VacancyType == VacancyType.Traineeship)
        {
            
            
            #line default
            #line hidden
            
            #line 48 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
       Write(Html.HiddenFor(m => m.WageType));

            
            #line default
            #line hidden
            
            #line 48 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
                                            
            
            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
       Write(Html.HiddenFor(m => m.Wage));

            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
                                        
            
            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
       Write(Html.HiddenFor(m => m.WageUnit));

            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
                                            
            
            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
       Write(Html.HiddenFor(m => m.WageComment));

            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
                                               
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"blocklabel-single-container\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <a");

WriteAttribute("name", Tuple.Create(" name=\"", 3080), Tuple.Create("\"", 3138)
            
            #line 57 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
, Tuple.Create(Tuple.Create("", 3087), Tuple.Create<System.Object, System.Int32>(Html.NameFor(m => m.WageType).ToString().ToLower()
            
            #line default
            #line hidden
, 3087), false)
);

WriteLiteral("></a>\r\n                    <label");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(" for=\"weekly-wage\"");

WriteLiteral(">Wage</label>\r\n                    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 3248), Tuple.Create("\"", 3388)
, Tuple.Create(Tuple.Create("", 3256), Tuple.Create("form-group", 3256), true)
            
            #line 59 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
, Tuple.Create(Tuple.Create(" ", 3266), Tuple.Create<System.Object, System.Int32>(SFA.Apprenticeships.Web.Common.Framework.HtmlExtensions.GetValidationCssClass(Html.GetValidationType(m => m.WageType))
            
            #line default
            #line hidden
, 3267), false)
);

WriteLiteral(" data-editable-x=\"\"");

WriteLiteral(">\r\n                        ");

WriteLiteral("\r\n                        <label");

WriteLiteral(" for=\"custom-wage\"");

WriteLiteral(" class=\"block-label\"");

WriteLiteral(" data-target=\"custom-wage-panel\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 62 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
                       Write(Html.RadioButtonFor(model => model.WageType, WageType.Custom, new {id = "custom-wage", aria_controls = "wage-type-panel"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            Custom wage\r\n                        </label>\r\n    " +
"                    ");

WriteLiteral("\r\n                        <label");

WriteLiteral(" for=\"national-minimum-wage\"");

WriteLiteral(" class=\"block-label\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 67 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
                       Write(Html.RadioButtonFor(model => model.WageType, WageType.NationalMinimum, new {id = "national-minimum-wage", aria_controls = "wage-type-panel"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            National Minimum Wage\r\n                        </la" +
"bel>\r\n                        ");

WriteLiteral("\r\n                        <label");

WriteLiteral(" for=\"apprenticeship-minimum-wage\"");

WriteLiteral(" class=\"block-label\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 72 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
                       Write(Html.RadioButtonFor(model => model.WageType, WageType.ApprenticeshipMinimum, new {id = "apprenticeship-minimum-wage", aria_controls = "wage-type-panel"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            National Minimum Wage for apprentices\r\n            " +
"            </label>\r\n");

WriteLiteral("                        ");

            
            #line 75 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
                   Write(Html.ValidationMessageFor(m => m.WageType));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                    <div");

WriteLiteral(" id=\"custom-wage-panel\"");

WriteLiteral(" class=\"toggle-content blocklabel-content\"");

WriteLiteral(">\r\n                        <fieldset");

WriteLiteral(" class=\"form-group inline-fixed\"");

WriteLiteral(">\r\n                            £\r\n");

WriteLiteral("                            ");

            
            #line 80 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
                       Write(Html.FormTextFor(m => m.Wage, containerHtmlAttributes: new {@class = "form-group-compound"}, labelHtmlAttributes: new {style = "Display: none"}, controlHtmlAttributes: new {@class = "form-control-large", type = "tel", size = 12}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 81 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
                       Write(Html.DropDownListFor(m => m.WageUnit, Model.WageUnits));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </fieldset>\r\n                    </div>\r\n              " +
"  </div>\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">");

            
            #line 85 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
                                   Write(Html.EditorFor(m => m.WageComment, "Comment", Html.GetLabelFor(m => m.WageComment)));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            </div>\r\n");

            
            #line 87 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n        <fieldset");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <div");

WriteAttribute("class", Tuple.Create(" class=\"", 5613), Tuple.Create("\"", 5753)
, Tuple.Create(Tuple.Create("", 5621), Tuple.Create("form-group", 5621), true)
            
            #line 90 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
, Tuple.Create(Tuple.Create(" ", 5631), Tuple.Create<System.Object, System.Int32>(SFA.Apprenticeships.Web.Common.Framework.HtmlExtensions.GetValidationCssClass(Html.GetValidationType(m => m.Duration))
            
            #line default
            #line hidden
, 5632), false)
);

WriteLiteral(">\r\n                <a");

WriteAttribute("name", Tuple.Create(" name=\"", 5775), Tuple.Create("\"", 5833)
            
            #line 91 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
, Tuple.Create(Tuple.Create("", 5782), Tuple.Create<System.Object, System.Int32>(Html.NameFor(m => m.Duration).ToString().ToLower()
            
            #line default
            #line hidden
, 5782), false)
);

WriteLiteral("></a>\r\n");

WriteLiteral("                ");

            
            #line 92 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
           Write(Html.LabelFor(m => m.Duration, new {@class = "form-label"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 93 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
           Write(Html.TextBoxFor(m => m.Duration, new {@class = "form-control-large form-control", type = "tel", size = 12}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 94 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
           Write(Html.DropDownListFor(m => m.DurationType, Model.DurationTypes));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 95 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
           Write(Html.ValidationMessageWithSeverityFor(m => m.Duration, Html.GetValidationType(m => m.Duration)));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </fieldset>\r\n        <fieldset");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 99 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
       Write(Html.EditorFor(m => m.DurationComment, "Comment", Html.GetLabelFor(m => m.DurationComment)));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </fieldset>\r\n\r\n        <fieldset");

WriteAttribute("class", Tuple.Create(" class=\"", 6466), Tuple.Create("\"", 6653)
, Tuple.Create(Tuple.Create("", 6474), Tuple.Create("form-group", 6474), true)
, Tuple.Create(Tuple.Create(" ", 6484), Tuple.Create("inline-fixed", 6485), true)
, Tuple.Create(Tuple.Create(" ", 6497), Tuple.Create("date-input", 6498), true)
            
            #line 102 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
, Tuple.Create(Tuple.Create(" ", 6508), Tuple.Create<System.Object, System.Int32>(SFA.Apprenticeships.Web.Common.Framework.HtmlExtensions.GetValidationCssClass(Html.GetValidationType(m => m.VacancyDatesViewModel.ClosingDate))
            
            #line default
            #line hidden
, 6509), false)
);

WriteLiteral(">\r\n            <a");

WriteAttribute("name", Tuple.Create(" name=\"", 6671), Tuple.Create("\"", 6772)
            
            #line 103 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
, Tuple.Create(Tuple.Create("", 6678), Tuple.Create<System.Object, System.Int32>(Html.NameFor(m => m.VacancyDatesViewModel.ClosingDate).ToString().Replace(".", "_").ToLower()
            
            #line default
            #line hidden
, 6678), false)
);

WriteLiteral("></a>\r\n            <legend");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">");

            
            #line 104 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
                                  Write(Model.GetMetadata(m => m.VacancyDatesViewModel.ClosingDate).DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</legend>\r\n");

WriteLiteral("            ");

            
            #line 105 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
       Write(Html.EditorFor(m => m.VacancyDatesViewModel.ClosingDate));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 106 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
       Write(Html.ValidationMessageWithSeverityFor(m => m.VacancyDatesViewModel.ClosingDate, Html.GetValidationType(m => m.VacancyDatesViewModel.ClosingDate)));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </fieldset>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">");

            
            #line 108 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
                           Write(Html.EditorFor(m => m.VacancyDatesViewModel.ClosingDateComment, "Comment", Html.GetLabelFor(m => m.VacancyDatesViewModel.ClosingDateComment)));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n        <fieldset");

WriteAttribute("class", Tuple.Create(" class=\"", 7355), Tuple.Create("\"", 7548)
, Tuple.Create(Tuple.Create("", 7363), Tuple.Create("form-group", 7363), true)
, Tuple.Create(Tuple.Create(" ", 7373), Tuple.Create("inline-fixed", 7374), true)
, Tuple.Create(Tuple.Create(" ", 7386), Tuple.Create("date-input", 7387), true)
            
            #line 110 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
, Tuple.Create(Tuple.Create(" ", 7397), Tuple.Create<System.Object, System.Int32>(SFA.Apprenticeships.Web.Common.Framework.HtmlExtensions.GetValidationCssClass(Html.GetValidationType(m => m.VacancyDatesViewModel.PossibleStartDate))
            
            #line default
            #line hidden
, 7398), false)
);

WriteLiteral(">\r\n            <a");

WriteAttribute("name", Tuple.Create(" name=\"", 7566), Tuple.Create("\"", 7673)
            
            #line 111 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
, Tuple.Create(Tuple.Create("", 7573), Tuple.Create<System.Object, System.Int32>(Html.NameFor(m => m.VacancyDatesViewModel.PossibleStartDate).ToString().Replace(".", "_").ToLower()
            
            #line default
            #line hidden
, 7573), false)
);

WriteLiteral("></a>\r\n            <legend");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">");

            
            #line 112 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
                                  Write(Model.GetMetadata(m => m.VacancyDatesViewModel.PossibleStartDate).DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</legend>\r\n");

WriteLiteral("            ");

            
            #line 113 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
       Write(Html.EditorFor(m => m.VacancyDatesViewModel.PossibleStartDate));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 114 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
       Write(Html.ValidationMessageWithSeverityFor(m => m.VacancyDatesViewModel.PossibleStartDate, Html.GetValidationType(m => m.VacancyDatesViewModel.PossibleStartDate)));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </fieldset>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">");

            
            #line 116 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
                           Write(Html.EditorFor(m => m.VacancyDatesViewModel.PossibleStartDateComment, "Comment", Html.GetLabelFor(m => m.VacancyDatesViewModel.PossibleStartDateComment)));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 117 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 117 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
          
            var longDescriptionlabelText = Model.VacancyType == VacancyType.Traineeship ? VacancyViewModelMessages.LongDescription.TraineeshipLabelText : null;
            var longDescriptionDataValLength = Model.VacancyType == VacancyType.Traineeship ? VacancyViewModelMessages.LongDescription.TraineeshipTooLongErrorText : VacancyViewModelMessages.LongDescription.TooLongErrorText;
            var longDescriptionDataValRegex = Model.VacancyType == VacancyType.Traineeship ? VacancyViewModelMessages.LongDescription.TraineeshipWhiteListInvalidCharacterErrorText : VacancyViewModelMessages.LongDescription.WhiteListInvalidCharacterErrorText;
        
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 122 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
   Write(Html.FormTextAreaFor(m => m.LongDescription, longDescriptionlabelText, controlHtmlAttributes: new { id="editor1", @class = "ckeditor", type = "text", size = 12, rows = 22, data_val_length = longDescriptionDataValLength, data_val_regex = longDescriptionDataValRegex}));

            
            #line default
            #line hidden
WriteLiteral("        \r\n");

WriteLiteral("        ");

            
            #line 123 "..\..\Views\Shared\DisplayTemplates\Vacancy\FurtherVacancyDetails.cshtml"
   Write(Html.EditorFor(m => m.LongDescriptionComment, "Comment", Html.GetLabelFor(m => m.LongDescriptionComment, Model.VacancyType == VacancyType.Traineeship ? VacancyViewModelMessages.LongDescriptionComment.TraineeshipLabelText : null)));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</section>\r\n");

        }
    }
}
#pragma warning restore 1591
