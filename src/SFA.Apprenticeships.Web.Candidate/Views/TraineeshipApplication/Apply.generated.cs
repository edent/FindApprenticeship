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

namespace SFA.Apprenticeships.Web.Candidate.Views.TraineeshipApplication
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/TraineeshipApplication/Apply.cshtml")]
    public partial class Apply : System.Web.Mvc.WebViewPage<SFA.Apprenticeships.Web.Candidate.ViewModels.Applications.TraineeshipApplicationViewModel>
    {
        public Apply()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\TraineeshipApplication\Apply.cshtml"
  
    ViewBag.Title = "Application form - Find a traineeship";
    Layout = "~/Views/Shared/_Layout.cshtml";   

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 8 "..\..\Views\TraineeshipApplication\Apply.cshtml"
 using (Html.BeginForm(null, "TraineeshipApplication", new { id = Model.VacancyId }, FormMethod.Post, new { id = "application-form", autocomplete = "off" }))
{

            
            #line default
            #line hidden
WriteLiteral("    <button");

WriteLiteral(" class=\"button hide-button\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" name=\"ApplicationAction\"");

WriteLiteral(" value=\"Apply\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(">Apply</button>\r\n");

            
            #line 11 "..\..\Views\TraineeshipApplication\Apply.cshtml"
    
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\TraineeshipApplication\Apply.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\TraineeshipApplication\Apply.cshtml"
                            

            
            #line default
            #line hidden
WriteLiteral("    <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">Application form</h1>\r\n");

WriteLiteral("    <section");

WriteLiteral(" class=\"section-border\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"text\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"hgroup-medium\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 16 "..\..\Views\TraineeshipApplication\Apply.cshtml"
           Write(Html.HiddenFor(m => m.VacancyDetail.Title));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(" id=\"vacancy-title\"");

WriteLiteral(">");

            
            #line 17 "..\..\Views\TraineeshipApplication\Apply.cshtml"
                                                         Write(Model.VacancyDetail.Title);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n");

WriteLiteral("                ");

            
            #line 18 "..\..\Views\TraineeshipApplication\Apply.cshtml"
           Write(Html.HiddenFor(m => m.VacancyDetail.EmployerName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <p");

WriteLiteral(" class=\"subtitle\"");

WriteLiteral(" id=\"vacancy-employer\"");

WriteLiteral(">");

            
            #line 19 "..\..\Views\TraineeshipApplication\Apply.cshtml"
                                                     Write(Model.VacancyDetail.EmployerName);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n            </div>\r\n");

WriteLiteral("            ");

            
            #line 21 "..\..\Views\TraineeshipApplication\Apply.cshtml"
       Write(Html.HiddenFor(m => m.VacancyDetail.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <p");

WriteLiteral(" id=\"vacancy-summary\"");

WriteLiteral(">");

            
            #line 22 "..\..\Views\TraineeshipApplication\Apply.cshtml"
                               Write(Model.VacancyDetail.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n            <p>\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1209), Tuple.Create("\"", 1299)
            
            #line 24 "..\..\Views\TraineeshipApplication\Apply.cshtml"
, Tuple.Create(Tuple.Create("", 1216), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(CandidateRouteNames.TraineeshipDetails, new { id = Model.VacancyId })
            
            #line default
            #line hidden
, 1216), false)
);

WriteLiteral(">View traineeship</a>\r\n            </p>\r\n        </div>\r\n    </section>\r\n");

            
            #line 28 "..\..\Views\TraineeshipApplication\Apply.cshtml"


    
            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\TraineeshipApplication\Apply.cshtml"
Write(Html.Partial("ValidationSummary", ViewData.ModelState));

            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\TraineeshipApplication\Apply.cshtml"
                                                           


    
            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\TraineeshipApplication\Apply.cshtml"
Write(Html.DisplayFor(m => m.Candidate));

            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\TraineeshipApplication\Apply.cshtml"
                                      
    
            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\TraineeshipApplication\Apply.cshtml"
Write(Html.HiddenFor(m => m.VacancyId));

            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\TraineeshipApplication\Apply.cshtml"
                                     
    
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\TraineeshipApplication\Apply.cshtml"
Write(Html.HiddenFor(m => m.IsJavascript, new{ @id="hidden-flag-javascript"}));

            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\TraineeshipApplication\Apply.cshtml"
                                                                            

    Html.RenderPartial("_qualificationsJS", Model);    
    Html.RenderPartial("_qualificationsNonJS", Model);
    
    Html.RenderPartial("_workExperiencesJS", Model);   
    Html.RenderPartial("_workExperiencesNonJS", Model);

    Html.RenderPartial("_trainingCoursesJS", Model);
    Html.RenderPartial("_trainingCoursesNonJS", Model);   
    
    
            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\TraineeshipApplication\Apply.cshtml"
Write(Html.EditorFor(m => m.Candidate.EmployerQuestionAnswers));

            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\TraineeshipApplication\Apply.cshtml"
                                                             
    
    
            
            #line default
            #line hidden
            
            #line 48 "..\..\Views\TraineeshipApplication\Apply.cshtml"
Write(Html.EditorFor(m => m.Candidate.MonitoringInformation, "MonitoringInformation/_disability"));

            
            #line default
            #line hidden
            
            #line 48 "..\..\Views\TraineeshipApplication\Apply.cshtml"
                                                                                                


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        ");

WriteLiteral("\r\n        <button");

WriteLiteral(" id=\"apply-button\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" name=\"ApplicationAction\"");

WriteLiteral(" class=\"button no-check-for-dirty-form\"");

WriteLiteral(" value=\"Apply\"");

WriteLiteral(">Submit application</button>\r\n    </div>\r\n");

            
            #line 54 "..\..\Views\TraineeshipApplication\Apply.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n\r\n");

WriteLiteral("    ");

            
            #line 58 "..\..\Views\TraineeshipApplication\Apply.cshtml"
Write(Scripts.Render("~/bundles/knockout"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">

    var qualificationData = null;
    var workExperienceData = null;
    var trainingCourseData = null;
    var currentYear = null;
    var whitelistregex = null;
    var yearRegex = null;
    var autoSaveTimeout = null;

    $(function() {

        document.getElementById(""hidden-flag-javascript"").value = ""True"";

        qualificationData = ");

            
            #line 74 "..\..\Views\TraineeshipApplication\Apply.cshtml"
                       Write(Html.Raw(Json.Encode(Model.Candidate.Qualifications)));

            
            #line default
            #line hidden
WriteLiteral(";\r\n        workExperienceData = ");

            
            #line 75 "..\..\Views\TraineeshipApplication\Apply.cshtml"
                        Write(Html.Raw(Json.Encode(Model.Candidate.WorkExperience)));

            
            #line default
            #line hidden
WriteLiteral(";\r\n        trainingCourseData = ");

            
            #line 76 "..\..\Views\TraineeshipApplication\Apply.cshtml"
                        Write(Html.Raw(Json.Encode(Model.Candidate.TrainingCourses)));

            
            #line default
            #line hidden
WriteLiteral(";\r\n        currentYear = ");

            
            #line 77 "..\..\Views\TraineeshipApplication\Apply.cshtml"
                 Write(Html.Raw(Model.CurrentYear));

            
            #line default
            #line hidden
WriteLiteral(";\r\n        whitelistregex =  ");

            
            #line 78 "..\..\Views\TraineeshipApplication\Apply.cshtml"
                     Write(Html.Raw(Json.Encode(Model.WhiteListRegex)));

            
            #line default
            #line hidden
WriteLiteral(";\r\n        yearRegex =  ");

            
            #line 79 "..\..\Views\TraineeshipApplication\Apply.cshtml"
                Write(Html.Raw(Json.Encode(Model.FourDigitYearRegex)));

            
            #line default
            #line hidden
WriteLiteral(";\r\n\r\n        $(window).on(\'load\', function (){\r\n            dirtyFormDialog.initi" +
"alise({\r\n                formSelector: \"form\",\r\n                classToExclude: " +
"\"no-check-for-dirty-form\",\r\n                timeout: ");

            
            #line 85 "..\..\Views\TraineeshipApplication\Apply.cshtml"
                    Write(Model.SessionTimeout);

            
            #line default
            #line hidden
WriteLiteral(" * 1000,\r\n                confirmationMessage: \'");

            
            #line 86 "..\..\Views\TraineeshipApplication\Apply.cshtml"
                                 Write(Model.ConfirmationMessage);

            
            #line default
            #line hidden
WriteLiteral(@"'
            });
        });
    });

    function getCurrentYear() {
        return currentYear;
    }

    function getQualificationData() {
        return qualificationData;
    }

    function getWorkExperienceData() {
        return workExperienceData;
    }

    function getTrainingCourseData() {
        return trainingCourseData;
    }

    function getWhiteListRegex() {
        return whitelistregex;
    }

    function getYearRegex() {
        return yearRegex;
    }

    function getMonthLabel(index) {
        var month = """";

        if (index === 0) {

        } else {
            var mths = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'June', 'July', 'Aug', 'Sept', 'Oct', 'Nov', 'Dec'];
            month = mths[index - 1];
        }

        return month;
    }

</script>
       
");

WriteLiteral("    ");

            
            #line 130 "..\..\Views\TraineeshipApplication\Apply.cshtml"
Write(Scripts.Render("~/bundles/nas/application"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
