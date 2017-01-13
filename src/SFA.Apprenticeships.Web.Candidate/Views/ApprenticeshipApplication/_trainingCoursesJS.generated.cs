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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ApprenticeshipApplication/_trainingCoursesJS.cshtml")]
    public partial class trainingCoursesJS : System.Web.Mvc.WebViewPage<SFA.Apprenticeships.Web.Candidate.ViewModels.Applications.ApprenticeshipApplicationViewModel>
    {
        public trainingCoursesJS()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"hide-nojs\"");

WriteLiteral(" data-enter-action=\"#addTrainingCourseBtn\"");

WriteLiteral(" data-bind=\" visible selectedsection()= = =\'applyTrainingCourses\' , stopbinding t" +
"rue\"");

WriteLiteral(">\r\n    <fieldset");

WriteLiteral(" id=\"applyTrainingCourses\"");

WriteLiteral(" class=\"sfa-xlarge-bottom-margin sfa-section-bordered\"");

WriteLiteral(">\r\n        <legend");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Training courses</legend>\r\n        <p");

WriteLiteral(" class=\"hide-nojs form-label-bold text\"");

WriteLiteral(" id=\"trainingCoursesQuestion\"");

WriteLiteral(">Have you been on a training course?</p>\r\n        <p");

WriteLiteral(" class=\"form-hint text\"");

WriteLiteral(" id=\"appTourTraining\"");

WriteLiteral(">\r\n            Include any courses you\'ve received, in or outside of work\r\n      " +
"  </p>\r\n        <div");

WriteLiteral(" class=\"hide-nojs\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"form-group inline clearfix\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" data-target=\"training-history-panel\"");

WriteLiteral(" for=\"training-history-yes\"");

WriteLiteral(" class=\"block-label selection-button-radio\"");

WriteLiteral(" data-bind=\"css: {selected: showTrainingCourses()}\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 13 "..\..\Views\ApprenticeshipApplication\_trainingCoursesJS.cshtml"
               Write(Html.RadioButtonFor(m => m.Candidate.HasTrainingCourses, true, new { id = "training-history-yes", data_bind = "attr:{'checked': hasTrainingCourses() }", aria_controls = "training-history-panel", aria_expanded = "false", aria_labelledby = "trainingCoursesQuestion" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    Yes\r\n                </label>\r\n                <label");

WriteLiteral(" for=\"training-history-no\"");

WriteLiteral(" class=\"block-label selection-button-radio\"");

WriteLiteral(" data-bind=\"css: {selected: !showTrainingCourses()}\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 17 "..\..\Views\ApprenticeshipApplication\_trainingCoursesJS.cshtml"
               Write(Html.RadioButtonFor(m => m.Candidate.HasTrainingCourses, false, new { id = "training-history-no", data_bind = "attr:{'checked': hasNoTrainingCourses() }", aria_labelledby = "hasNoTrainingCoursesQuestion" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    No\r\n                </label>\r\n            </div>\r\n         " +
"   <div");

WriteLiteral(" id=\"training-history-panel\"");

WriteLiteral(" class=\"toggle-content\"");

WriteLiteral(" data-bind=\"style: {\'display\': trainingCoursesStatus() }\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" id=\"training-history-apply\"");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-group form-group-compound\"");

WriteLiteral(" data-bind=\"parentvalElement: provider\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"training-history-provider\"");

WriteLiteral(" class=\"form-label-bold\"");

WriteLiteral(">Provider</label>\r\n                        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" id=\"training-history-provider\"");

WriteLiteral(" data-bind=\"value: provider\"");

WriteLiteral(" maxlength=\"50\"");

WriteLiteral(">\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"form-group form-group-compound\"");

WriteLiteral(" data-bind=\"parentvalElement: title\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"training-history-course-title\"");

WriteLiteral(" class=\"form-label-bold\"");

WriteLiteral(">Course title</label>\r\n                        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" id=\"training-history-course-title\"");

WriteLiteral(" data-bind=\"value: title\"");

WriteLiteral(" maxlength=\"50\"");

WriteLiteral(">\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"form-group inline-fixed validation-message-parent\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"form-group error-wrapper vert-align-top sfa-no-bottom-margin\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" for=\"training-history-from-month\"");

WriteLiteral(" class=\"form-label-bold\"");

WriteLiteral(">From</label>\r\n                            <div");

WriteLiteral(" class=\"form-group form-group-compound sfa-no-bottom-margin\"");

WriteLiteral(">\r\n                                <span");

WriteLiteral(" class=\"form-hint\"");

WriteLiteral(">Month</span>\r\n                                <select");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" id=\"training-history-from-month\"");

WriteLiteral(" data-bind=\"options: months, optionsText: \'monthName\', optionsValue: \'monthNumber" +
"\', value: fromMonth\"");

WriteLiteral("></select>\r\n                            </div>\r\n                            <div");

WriteLiteral(" class=\"form-group sfa-no-bottom-margin\"");

WriteLiteral(" data-bind=\"parentvalElement: fromYear\"");

WriteLiteral(">\r\n                                <label");

WriteLiteral(" for=\"training-history-from-year\"");

WriteLiteral(" class=\"form-hint\"");

WriteLiteral(">Year</label>\r\n                                <input");

WriteLiteral(" type=\"tel\"");

WriteLiteral(" class=\"form-control form-control-small\"");

WriteLiteral(" pattern=\"[0-9]*\"");

WriteLiteral(" maxlength=\"4\"");

WriteLiteral(" id=\"training-history-from-year\"");

WriteLiteral(" data-bind=\"value: fromYear\"");

WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n          " +
"              <div");

WriteLiteral(" class=\"form-group error-wrapper vert-align-top sfa-no-bottom-margin\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" for=\"training-history-to-month\"");

WriteLiteral(" class=\"form-label-bold\"");

WriteLiteral(">To</label>\r\n                            <div");

WriteLiteral(" class=\"form-group form-group-compound sfa-no-bottom-margin\"");

WriteLiteral(">\r\n                                <span");

WriteLiteral(" class=\"form-hint\"");

WriteLiteral(">Month</span>\r\n                                <select");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" id=\"training-history-to-month\"");

WriteLiteral(" data-bind=\"options: months, optionsText: \'monthName\', optionsValue: \'monthNumber" +
"\', value: toMonth\"");

WriteLiteral("></select>\r\n                            </div>\r\n                            <div");

WriteLiteral(" class=\"form-group form-group-compound sfa-no-bottom-margin\"");

WriteLiteral(" data-bind=\"parentvalElement: toYear\"");

WriteLiteral(">\r\n                                <label");

WriteLiteral(" for=\"training-history-to-year\"");

WriteLiteral(" class=\"form-hint\"");

WriteLiteral(">Year</label>\r\n                                <input");

WriteLiteral(" type=\"tel\"");

WriteLiteral(" class=\"form-control form-control-small\"");

WriteLiteral(" pattern=\"[0-9]*\"");

WriteLiteral(" maxlength=\"4\"");

WriteLiteral("\r\n                                       id=\"training-history-to-year\"");

WriteLiteral(" data-bind=\"value: toYear\"");

WriteLiteral(" />\r\n                            </div>\r\n                        </div>\r\n        " +
"                <div");

WriteLiteral(" class=\"validation-message-container\"");

WriteLiteral("></div>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" role=\"button\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" id=\"addTrainingCourseBtn\"");

WriteLiteral(" data-bind=\"click: addTrainingCourse\"");

WriteLiteral(">Save this training course</a>\r\n                        <span");

WriteLiteral(" class=\"visuallyhidden\"");

WriteLiteral(" aria-live=\"polite\"");

WriteLiteral(" id=\"trainingCourseAddConfirmText\"");

WriteLiteral("></span>\r\n                    </div>\r\n                </div>\r\n                <di" +
"v");

WriteLiteral(" id=\"training-history-summary\"");

WriteLiteral(" data-bind=\"foreach: trainingCourseItems\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"grid-3-4\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" id=\"training-history-item\"");

WriteLiteral(" class=\"grid-row training-history-item\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"training-controls\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"training-edit sfa-align-center\"");

WriteLiteral(">\r\n                                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"fake-link cell-span\"");

WriteLiteral(" data-bind=\"if: showEditButton, click: $parent.editTrainingCourse\"");

WriteLiteral(">Edit</a>\r\n                                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"fake-link cell-span\"");

WriteLiteral(" data-bind=\"ifnot: showEditButton,click: $parent.saveTrainingCourse\"");

WriteLiteral(">Save</a>\r\n                                </div>\r\n                              " +
"  <div");

WriteLiteral(" class=\"training-delete sfa-align-center\"");

WriteLiteral(">\r\n                                    <span");

WriteLiteral(" class=\"cell-span\"");

WriteLiteral(">\r\n                                        <i");

WriteLiteral(" class=\"font-xsmall fa fa-times-circle icon-black remove-training-history-item-li" +
"nk\"");

WriteLiteral(" data-bind=\"click: $parent.removeTrainingCourse\"");

WriteLiteral("></i>\r\n                                        <i");

WriteLiteral(" class=\"visuallyhidden\"");

WriteLiteral(">Remove</i>\r\n                                    </span>\r\n                       " +
"         </div>\r\n                            </div>\r\n                           " +
" <div");

WriteLiteral(" class=\"column-one-half\"");

WriteLiteral(">\r\n                                <table");

WriteLiteral(" class=\"table-no-btm-border table-compound\"");

WriteLiteral(">\r\n                                    <colgroup>\r\n                              " +
"          <col");

WriteLiteral(" class=\"t100\"");

WriteLiteral(@">
                                        <col>
                                    </colgroup>
                                    <thead>
                                        <tr>
                                            <th>
                                                <span");

WriteLiteral(" class=\"heading-span\"");

WriteLiteral(@">Training course</span>
                                            </th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>
                                                <div");

WriteLiteral(" class=\"form-group form-group-compound inline-float width-all-49\"");

WriteLiteral(" data-bind=\"visible: !showEditButton()\"");

WriteLiteral(">\r\n                                                    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" title=\"Provider\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" data-bind=\"value: itemProvider, attr:{\'name\':\'Candidate.TrainingCourses[\' + $ind" +
"ex() +\'].Provider\'}\"");

WriteLiteral(" maxlength=\"50\"");

WriteLiteral(" />\r\n                                                </div>\r\n                    " +
"                            <span");

WriteLiteral(" class=\"cell-span training-history-provider-span\"");

WriteLiteral(" data-bind=\"visible: showEditButton, text: itemProvider, attr:{\'id\':\'candidate_tr" +
"ainingcourses_\' + $index() + \'__provider\'}\"");

WriteLiteral("></span>\r\n                                                <span");

WriteLiteral(" class=\"cell-span training-hyphen\"");

WriteLiteral(" data-bind=\"visible: showEditButton\"");

WriteLiteral(">-</span>\r\n                                                <div");

WriteLiteral(" class=\"form-group form-group-compound inline-float width-all-49 no-right-margin\"" +
"");

WriteLiteral(" data-bind=\"visible: !showEditButton()\"");

WriteLiteral(">\r\n                                                    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" title=\"Training course title\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" data-bind=\"value: itemTitle, attr:{\'name\':\'Candidate.TrainingCourses[\' + $index(" +
") +\'].Title\'}\"");

WriteLiteral(" maxlength=\"50\"");

WriteLiteral(" />\r\n                                                </div>\r\n                    " +
"                            <span");

WriteLiteral(" class=\"cell-span training-history-course-title-span\"");

WriteLiteral(" data-bind=\"visible: showEditButton, text: itemTitle, attr:{\'id\':\'candidate_train" +
"ingcourses_\' + $index() + \'__title\'}\"");

WriteLiteral(@"></span>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                            <div");

WriteLiteral(" class=\"column-one-half\"");

WriteLiteral(">\r\n                                <table");

WriteLiteral(" class=\"table-no-btm-border table-compound\"");

WriteLiteral(">\r\n                                    <colgroup>\r\n                              " +
"          <col");

WriteLiteral(" class=\"t30\"");

WriteLiteral(">\r\n                                        <col");

WriteLiteral(" class=\"t30\"");

WriteLiteral(">\r\n                                        <col");

WriteLiteral(" class=\"t25\"");

WriteLiteral(">\r\n                                        <col");

WriteLiteral(" class=\"t15\"");

WriteLiteral(@">
                                        <col>
                                    </colgroup>
                                    <thead>
                                        <tr>
                                            <th>
                                                <span");

WriteLiteral(" class=\"heading-span\"");

WriteLiteral(">From</span>\r\n                                            </th>\r\n                " +
"                            <th>\r\n                                              " +
"  <span");

WriteLiteral(" class=\"heading-span\"");

WriteLiteral(@">To</span>
                                            </th>
                                            <th></th>
                                            <th></th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td");

WriteLiteral(" class=\"validation-message-parent\"");

WriteLiteral(">\r\n                                                <div");

WriteLiteral(" class=\"form-group form-group-compound\"");

WriteLiteral(" data-bind=\"visible: !showEditButton()\"");

WriteLiteral(">\r\n                                                    <select");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" title=\"From month\"");

WriteLiteral(" data-bind=\"options: $parent.months, optionsText: \'monthName\', optionsValue: \'mon" +
"thNumber\', value: itemFromMonth, attr:{\'name\':\'Candidate.TrainingCourses[\' + $in" +
"dex() +\'].FromMonth\'} \"");

WriteLiteral("></select>\r\n                                                </div>\r\n             " +
"                                   <div");

WriteLiteral(" class=\"form-group form-group-compound\"");

WriteLiteral(" data-bind=\"visible: !showEditButton()\"");

WriteLiteral(">\r\n                                                    <input");

WriteLiteral(" title=\"From year\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" data-bind=\"value: itemFromYear, attr:{\'name\':\'Candidate.TrainingCourses[\' + $ind" +
"ex() +\'].FromYear\'}\"");

WriteLiteral(" pattern=\"[0-9]*\"");

WriteLiteral(" maxlength=\"4\"");

WriteLiteral(">\r\n                                                </div>\r\n                      " +
"                          <span");

WriteLiteral(" class=\"cell-span\"");

WriteLiteral(" data-bind=\"visible: showEditButton, text: getMonthLabel(itemFromMonth()), attr:{" +
"\'id\':\'candidate_trainingcourses_\' + $index() + \'__frommonth\'}\"");

WriteLiteral("></span>\r\n                                                <span");

WriteLiteral(" class=\"cell-span\"");

WriteLiteral(" data-bind=\"visible: showEditButton, text: itemFromYear, attr:{\'id\':\'candidate_tr" +
"ainingcourses_\' + $index() + \'__fromyear\'}\"");

WriteLiteral("></span>\r\n                                                <div");

WriteLiteral(" class=\"validation-message-container\"");

WriteLiteral("></div>\r\n                                            </td>\r\n                     " +
"                       <td");

WriteLiteral(" class=\"validation-message-parent\"");

WriteLiteral(">\r\n                                                <div");

WriteLiteral(" class=\"form-group form-group-compound\"");

WriteLiteral(" data-bind=\"visible: !showEditButton()\"");

WriteLiteral(">\r\n                                                    <select");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" title=\"To month\"");

WriteLiteral(" data-bind=\"options: $parent.months, optionsText: \'monthName\', optionsValue: \'mon" +
"thNumber\', value: itemToMonth, attr:{\'name\':\'Candidate.TrainingCourses[\' + $inde" +
"x() +\'].ToMonth\'}\"");

WriteLiteral("></select>\r\n                                                </div>\r\n             " +
"                                   <div");

WriteLiteral(" class=\"form-group form-group-compound\"");

WriteLiteral(" data-bind=\"visible: !showEditButton()\"");

WriteLiteral(">\r\n                                                    <input");

WriteLiteral(" title=\"To year\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" data-bind=\"value: itemToYear, attr:{\'name\':\'Candidate.TrainingCourses[\' + $index" +
"() +\'].ToYear\'}\"");

WriteLiteral(" pattern=\"[0-9]*\"");

WriteLiteral(" maxlength=\"4\"");

WriteLiteral(">\r\n                                                </div>\r\n                      " +
"                          <span");

WriteLiteral(" class=\"cell-span\"");

WriteLiteral(" data-bind=\"visible: showEditButton, text: getMonthLabel(itemToMonth()), attr:{\'i" +
"d\':\'candidate_trainingcourses_\' + $index() + \'__tomonth\'}\"");

WriteLiteral("></span>\r\n                                                <span");

WriteLiteral(" class=\"cell-span\"");

WriteLiteral(" data-bind=\"visible: showEditButton, text: itemToYear, attr:{\'id\':\'candidate_trai" +
"ningcourses_\' + $index() + \'__toyear\'}\"");

WriteLiteral("></span>\r\n                                                <div");

WriteLiteral(" class=\"validation-message-container\"");

WriteLiteral(@"></div>
                                            </td>
                                            <td></td>
                                            <td></td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </fieldset>
</div>

");

        }
    }
}
#pragma warning restore 1591
