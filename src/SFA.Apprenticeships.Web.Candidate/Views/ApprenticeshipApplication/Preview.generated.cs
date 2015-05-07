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

namespace SFA.Apprenticeships.Web.Candidate.Views.ApprenticeshipApplication
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ApprenticeshipApplication/Preview.cshtml")]
    public partial class Preview : System.Web.Mvc.WebViewPage<SFA.Apprenticeships.Web.Candidate.ViewModels.Applications.ApprenticeshipApplicationViewModel>
    {
        public Preview()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\ApprenticeshipApplication\Preview.cshtml"
  
    ViewBag.Title = "Preview your application - Find an apprenticeship";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var AnalyticsTag = "Webtrends.multiTrack({{ element: this, argsa: ['DCS.dcsuri', '/apprenticeship/preview/" + Model.VacancyId + "', 'WT.dl', '99', 'WT.ti', 'Apprenticeship – Submit Preview', 'DCSext.buttonPos', '{0}'] }});";

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"progress-indicator progress-indicator-horizontal hide-print\"");

WriteLiteral(">\r\n    <ul>\r\n        <li><span");

WriteLiteral(" class=\"hide-tablet\"");

WriteLiteral(">Step </span>1<span");

WriteLiteral(" class=\"hide-tablet\"");

WriteLiteral("> of 3</span>. Application form</li>\r\n        <li");

WriteLiteral(" class=\"active\"");

WriteLiteral("><span");

WriteLiteral(" class=\"hide-tablet\"");

WriteLiteral(">Step </span>2<span");

WriteLiteral(" class=\"hide-tablet\"");

WriteLiteral("> of 3</span>. Check your application</li>\r\n        <li><span");

WriteLiteral(" class=\"hide-tablet\"");

WriteLiteral(">Step </span>3<span");

WriteLiteral(" class=\"hide-tablet\"");

WriteLiteral("> of 3</span>. Submitted</li>\r\n    </ul>\r\n</div>\r\n");

            
            #line 15 "..\..\Views\ApprenticeshipApplication\Preview.cshtml"
 if (Model.DateUpdated.HasValue)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"panel-info\"");

WriteLiteral(">\r\n        <p");

WriteLiteral(" id=\"applicationSavedTopMessage\"");

WriteLiteral(">Last saved at ");

            
            #line 18 "..\..\Views\ApprenticeshipApplication\Preview.cshtml"
                                                    Write(Html.DisplayFor(m => m.DateUpdated.Value, "DateTimeSaved"));

            
            #line default
            #line hidden
WriteLiteral(" to <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1110), Tuple.Create("\"", 1166)
            
            #line 18 "..\..\Views\ApprenticeshipApplication\Preview.cshtml"
                                                 , Tuple.Create(Tuple.Create("", 1117), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(CandidateRouteNames.MyApplications)
            
            #line default
            #line hidden
, 1117), false)
);

WriteLiteral(" title=\"My Applications\"");

WriteLiteral(">my applications</a></p>\r\n    </div>\r\n");

            
            #line 20 "..\..\Views\ApprenticeshipApplication\Preview.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"grid-wrapper\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"grid-2-3 grid\"");

WriteLiteral(">\r\n        <h1");

WriteLiteral(" class=\"heading-xlarge hide-print\"");

WriteLiteral(">Check your application</h1>\r\n        <h1");

WriteLiteral(" class=\"heading-xlarge toggle-content hide-nojs show-print\"");

WriteLiteral(">Your application</h1>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"grid grid-1-3\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"page-link\"");

WriteLiteral(">\r\n            <p>\r\n                <a");

WriteLiteral(" class=\"print-trigger\"");

WriteLiteral(" href=\"\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-print\"");

WriteLiteral("></i>Print this page</a>\r\n            </p>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r" +
"\n\r\n<div");

WriteLiteral(" class=\"text\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 38 "..\..\Views\ApprenticeshipApplication\Preview.cshtml"
Write(Html.HiddenFor(m => m.VacancyDetail.Title));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 39 "..\..\Views\ApprenticeshipApplication\Preview.cshtml"
Write(Html.HiddenFor(m => m.VacancyDetail.VacancyReference));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"panel-indent\"");

WriteLiteral(">\r\n        <p");

WriteLiteral(" class=\"para-btm-margin hide-print\"");

WriteLiteral(">Check your answers before submitting and make sure they\'re relevant to the appre" +
"nticehip: <b>");

            
            #line 41 "..\..\Views\ApprenticeshipApplication\Preview.cshtml"
                                                                                                                                      Write(Model.VacancyDetail.Title);

            
            #line default
            #line hidden
WriteLiteral("</b>.\r\n        <p");

WriteLiteral(" class=\"para-btm-margin toggle-content hide-nojs show-print\"");

WriteLiteral(">Application for <b>");

            
            #line 42 "..\..\Views\ApprenticeshipApplication\Preview.cshtml"
                                                                                     Write(Model.VacancyDetail.Title);

            
            #line default
            #line hidden
WriteLiteral("</b></p>\r\n        <p");

WriteLiteral(" class=\"para-btm-margin toggle-content hide-nojs show-print\"");

WriteLiteral(">Apprenticeship reference number: <b>");

            
            #line 43 "..\..\Views\ApprenticeshipApplication\Preview.cshtml"
                                                                                                      Write(Model.VacancyDetail.VacancyReference);

            
            #line default
            #line hidden
WriteLiteral("</b></p>\r\n    </div>\r\n<div");

WriteLiteral(" class=\"form-group hide-print\"");

WriteLiteral(">\r\n    <p><a");

WriteLiteral(" title=\"Return to application form\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2420), Tuple.Create("\"", 2512)
            
            #line 46 "..\..\Views\ApprenticeshipApplication\Preview.cshtml"
, Tuple.Create(Tuple.Create("", 2427), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(CandidateRouteNames.ApprenticeshipApply, new { @id = Model.VacancyId })
            
            #line default
            #line hidden
, 2427), false)
);

WriteLiteral(">Return to application form</a></p>\r\n</div>\r\n</div>\r\n\r\n");

            
            #line 50 "..\..\Views\ApprenticeshipApplication\Preview.cshtml"
Write(Html.DisplayFor(m => m.Candidate.Education));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 51 "..\..\Views\ApprenticeshipApplication\Preview.cshtml"
Write(Html.DisplayFor(m => m.Candidate.Qualifications, "QualificationsViewModel"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 52 "..\..\Views\ApprenticeshipApplication\Preview.cshtml"
Write(Html.DisplayFor(m => m.Candidate.WorkExperience, "WorkExperienceViewModel"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 53 "..\..\Views\ApprenticeshipApplication\Preview.cshtml"
Write(Html.DisplayFor(m => m.Candidate.AboutYou));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 54 "..\..\Views\ApprenticeshipApplication\Preview.cshtml"
Write(Html.DisplayFor(m => m.Candidate.EmployerQuestionAnswers));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"hide-print\"");

WriteLiteral(">\r\n    <h3");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Submit your application</h3>\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(@">
        <p>Before you submit your application make sure you:</p>
        <ul>
            <li>ask someone to check your application for mistakes</li>
            <li>check your answers are relevant to the apprenticeship</li>
            <li>are able to get to the apprenticeship location easily</li>
        </ul>
    </div>
</div>

<div");

WriteLiteral(" class=\"form-group hide-print\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 69 "..\..\Views\ApprenticeshipApplication\Preview.cshtml"
Write(Html.ActionLink("Submit application", "SubmitApplication", new { id = Model.VacancyId }, new { @class = "button", id = "submit-application", onclick = string.Format(AnalyticsTag, "BottomButton") }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 71 "..\..\Views\ApprenticeshipApplication\Preview.cshtml"
    
            
            #line default
            #line hidden
            
            #line 71 "..\..\Views\ApprenticeshipApplication\Preview.cshtml"
     if (Model.DateUpdated.HasValue)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" id=\"applicationSavedBottomMessage\"");

WriteLiteral(">Last saved at ");

            
            #line 73 "..\..\Views\ApprenticeshipApplication\Preview.cshtml"
                                                       Write(Html.DisplayFor(m => m.DateUpdated.Value, "DateTimeSaved"));

            
            #line default
            #line hidden
WriteLiteral(" to <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3748), Tuple.Create("\"", 3804)
            
            #line 73 "..\..\Views\ApprenticeshipApplication\Preview.cshtml"
                                                    , Tuple.Create(Tuple.Create("", 3755), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(CandidateRouteNames.MyApplications)
            
            #line default
            #line hidden
, 3755), false)
);

WriteLiteral(" title=\"My Applications\"");

WriteLiteral(">my applications</a></p>\r\n");

            
            #line 74 "..\..\Views\ApprenticeshipApplication\Preview.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

DefineSection("scripts", () => {

WriteLiteral(@"

    <script>
        function getMonthLabel(index) {
            //alert(index);
            var month = """";

            if (index === 0) {

            } else {
                var mths = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'June', 'July', 'Aug', 'Sept', 'Oct', 'Nov', 'Dec'];
                month = mths[index - 1];
            }

            return month;
        }

        $(function () {
            $('#submit-application').on('click', function () {

                if ($('#submit-application').attr('data-disabled') != undefined) {
                    if (event.preventDefault) {
                        event.preventDefault();
                    }

                    $('#submit-application').attr(""disabled"", ""disabled"");
                    return false;

                } else {
                    $('#submit-application').attr(""data-disabled"", ""disabled"");
                }
            });
        });


    </script>
");

});

        }
    }
}
#pragma warning restore 1591
