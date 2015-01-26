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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ApprenticeshipApplication/_qualificationsJS.cshtml")]
    public partial class qualificationsJS : System.Web.Mvc.WebViewPage<SFA.Apprenticeships.Web.Candidate.ViewModels.Applications.ApprenticeshipApplicationViewModel>
    {
        public qualificationsJS()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"hide-nojs\"");

WriteLiteral(" data-bind=\"visible: selectedSection() === \'applyQualifications\', stopBinding:tru" +
"e\"");

WriteLiteral(">\r\n\r\n    <fieldset");

WriteLiteral(" class=\"fieldset-with-border\"");

WriteLiteral(" id=\"applyQualifications\"");

WriteLiteral(">\r\n        <legend");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Qualifications</legend>\r\n        <p");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(" id=\"qualificationQuestion\"");

WriteLiteral(">Do you have any qualifications?</p>\r\n        <p");

WriteLiteral(" class=\"form-hint text\"");

WriteLiteral(">\r\n            If you don\'t know your results yet, enter your predicted grades. T" +
"hese are grades your teacher expects you to get.\r\n        </p>\r\n        <div");

WriteLiteral(" class=\"form-group inline clearfix\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" data-target=\"qualifications-panel\"");

WriteLiteral(" for=\"qualifications-yes\"");

WriteLiteral(" class=\"block-label\"");

WriteLiteral(" data-bind=\"css: {selected:showQualifications() }\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 13 "..\..\Views\ApprenticeshipApplication\_qualificationsJS.cshtml"
           Write(Html.RadioButtonFor(m => m.Candidate.HasQualifications, true, new { id = "qualifications-yes", data_bind = "attr:{'checked': hasQualifications() }", aria_controls = "qualifications-panel", aria_expanded = "false", aria_labelledby = "qualificationQuestion" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                Yes\r\n\r\n            </label>\r\n            <label");

WriteLiteral(" for=\"qualifications-no\"");

WriteLiteral(" class=\"block-label\"");

WriteLiteral(" data-bind=\"css: {selected: !showQualifications() }\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 18 "..\..\Views\ApprenticeshipApplication\_qualificationsJS.cshtml"
           Write(Html.RadioButtonFor(m => m.Candidate.HasQualifications, false, new { id = "qualifications-no", data_bind = "attr:{'checked': hasNoQualifications() }", aria_labelledby = "qualificationQuestion" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                No\r\n            </label>\r\n        </div>\r\n        <div");

WriteLiteral(" id=\"qualifications-panel\"");

WriteLiteral(" class=\"toggle-content\"");

WriteLiteral(" data-bind=\"style: {\'display\':showQualifications() ? \'block\' :\'none\' }\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"inline-fixed\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-group vert-align-top\"");

WriteLiteral(" data-bind=\"parentvalElement:selectedQualification\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"qual-type\"");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Type of qualification</label>\r\n                        <select");

WriteLiteral(" id=\"qual-type\"");

WriteLiteral(" data-bind=\"options: qualificationTypes, optionsCaption: \'Select from list\', opti" +
"onsText: \'qualificationTypeName\', optionsValue: \'qualificationTypeName\',value: s" +
"electedQualification\"");

WriteLiteral("></select>\r\n\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"form-group vert-align-top\"");

WriteLiteral(" data-bind=\"parentvalElement:year\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"subject-year\"");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Year</label>\r\n                        <input");

WriteLiteral(" maxlength=\"4\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control form-control-small\"");

WriteLiteral(" pattern=\"[0-9]*\"");

WriteLiteral("\r\n                               id=\"subject-year\"");

WriteLiteral(" data-bind=\"value: year\"");

WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(" data-bind=\"visible: showOtherQualification,parentvalElement:otherQualification\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"other-qual\"");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Name of other qualification</label>\r\n                    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" id=\"other-qual\"");

WriteLiteral(" data-bind=\"value: otherQualification\"");

WriteLiteral(" maxlength=\"100\"");

WriteLiteral(">\r\n\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(" data-bind=\"parentvalElement:subject\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"subject-name\"");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Subject</label>\r\n                    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" id=\"subject-name\"");

WriteLiteral(" data-bind=\"value: subject\"");

WriteLiteral(" maxlength=\"50\"");

WriteLiteral(">\r\n\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"inline-fixed\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(" data-bind=\"parentvalElement:grade\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"subject-grade\"");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Grade</label>\r\n                        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control form-control-medium\"");

WriteLiteral(" id=\"subject-grade\"");

WriteLiteral(" data-bind=\"value: grade\"");

WriteLiteral(" maxlength=\"15\"");

WriteLiteral(">\r\n\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" id=\"qual-predicted\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" data-bind=\"checked: predicted\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"qual-predicted\"");

WriteLiteral(">Predicted?</label>\r\n                    </div>\r\n                </div>\r\n        " +
"        <div");

WriteLiteral(" id=\"qualification-save-warning\"");

WriteLiteral(" class=\"hidden\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"form-hint text\"");

WriteLiteral(">TODO: Click \"Add qualification\" to add the qualification.</span>\r\n              " +
"  </div>\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" role=\"button\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" id=\"saveQualification\"");

WriteLiteral(" data-bind=\"click: addQualification\"");

WriteLiteral(">Add qualification</a>\r\n                    <span");

WriteLiteral(" class=\"visuallyhidden\"");

WriteLiteral(" aria-live=\"polite\"");

WriteLiteral(" id=\"qualAddConfirmText\"");

WriteLiteral("></span>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" data-bind=\"foreach: qualifications\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" data-bind=\"visible: groupItems().length > 0 \"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"hgroup-small\"");

WriteLiteral(">\r\n                        <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(" data-bind=\"text: groupKey\"");

WriteLiteral("></h3>\r\n                    </div>\r\n                    <table");

WriteLiteral(" class=\"grid-3-4\"");

WriteLiteral(">\r\n                        <colgroup>\r\n                            <col");

WriteLiteral(" class=\"t40\"");

WriteLiteral(">\r\n                            <col");

WriteLiteral(" class=\"t25\"");

WriteLiteral(">\r\n                            <col");

WriteLiteral(" class=\"t20\"");

WriteLiteral(">\r\n                            <col");

WriteLiteral(" class=\"t10\"");

WriteLiteral(">\r\n                            <col");

WriteLiteral(" class=\"t5\"");

WriteLiteral(">\r\n                            <col>\r\n                        </colgroup>\r\n\r\n    " +
"                    <thead>\r\n                            <tr>\r\n                 " +
"               <th>\r\n                                    <span");

WriteLiteral(" class=\"heading-span\"");

WriteLiteral(">Subject</span>\r\n                                </th>\r\n                         " +
"       <th>\r\n                                    <span");

WriteLiteral(" class=\"heading-span\"");

WriteLiteral(">Grade</span>\r\n                                </th>\r\n                           " +
"     <th>\r\n                                    <span");

WriteLiteral(" class=\"heading-span\"");

WriteLiteral(">Year</span>\r\n                                </th>\r\n                            " +
"    <th></th>\r\n                                <th></th>\r\n                      " +
"      </tr>\r\n                        </thead>\r\n                        <tbody");

WriteLiteral(" id=\"qualifications-summary\"");

WriteLiteral(" data-bind=\"foreach: groupItems\"");

WriteLiteral(">\r\n                            <tr>\r\n                                <td>\r\n      " +
"                              <input");

WriteLiteral(" class=\"form-control qual-input-edit qual-subject\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" data-bind=\"value: qualificationSubject, attr:{\'name\':\'Candidate.Qualifications[\'" +
" + itemIndex() +\'].Subject\', \'id\':\'candidate_qualifications_\'+ itemIndex() + \'__" +
"subject\', \'readonly\':readOnly() }\"");

WriteLiteral(" maxlength=\"50\"");

WriteLiteral(" />\r\n                                </td>\r\n                                <td>\r" +
"\n                                    <div");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">\r\n                                        <input");

WriteLiteral(" class=\"form-control qual-input-edit qual-grade\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" data-bind=\"value: showEditButton()? gradeDisplay : qualificationGrade, attr:{\'id" +
"\':\'candidate_qualifications_\'+ itemIndex() + \'__grade\',\'readonly\':readOnly() }\"");

WriteLiteral(" />\r\n                                        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"value: qualificationGrade, attr:{\'name\':\'Candidate.Qualifications[\' +" +
" itemIndex() +\'].Grade\'}\"");

WriteLiteral(" />\r\n                                    </div>\r\n                                " +
"    <label");

WriteLiteral(" for=\"item-qual-predicted\"");

WriteLiteral(" data-bind=\"ifnot: showEditButton\"");

WriteLiteral(">\r\n                                        <input");

WriteLiteral(" id=\"item-qual-predicted\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" class=\"qual-predicted\"");

WriteLiteral(" data-bind=\"checked: qualificationPredicted\"");

WriteLiteral(" /> Predicted\r\n                                    </label>\r\n                    " +
"            </td>\r\n                                <td>\r\n                       " +
"             <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"value: qualificationType, attr:{\'name\':\'Candidate.Qualifications[\' + " +
"itemIndex() +\'].QualificationType\'}\"");

WriteLiteral(" />\r\n                                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"value: qualificationPredicted, attr:{\'name\':\'Candidate.Qualifications" +
"[\' + itemIndex() +\'].IsPredicted\'}\"");

WriteLiteral(" />\r\n                                    <input");

WriteLiteral(" maxlength=\"4\"");

WriteLiteral(" pattern=\"[0-9]*\"");

WriteLiteral(" class=\"form-control qual-input-edit qual-year\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" data-bind=\"value: qualificationYear, attr:{\'name\':\'Candidate.Qualifications[\' + " +
"itemIndex() +\'].Year\', \'id\':\'candidate_qualifications_\'+ itemIndex() + \'__year\'," +
"\'readonly\':readOnly() }\"");

WriteLiteral(">\r\n                                </td>\r\n                                <td");

WriteLiteral(" class=\"ta-center\"");

WriteLiteral(">\r\n                                    <span");

WriteLiteral(" data-bind=\"if: showEditButton, click: $root.editQualification\"");

WriteLiteral("><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"fake-link cell-span edit-qualification-link\"");

WriteLiteral(">Edit</a></span>\r\n                                    <span");

WriteLiteral(" data-bind=\"ifnot: showEditButton,click: $root.saveQualificationItem\"");

WriteLiteral("><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"fake-link cell-span save-qualification-link\"");

WriteLiteral(">Save</a></span>\r\n                                </td>\r\n                        " +
"        <td");

WriteLiteral(" class=\"ta-center\"");

WriteLiteral(">\r\n                                    <i");

WriteLiteral(" class=\"cell-span\"");

WriteLiteral("><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"copy-16 fa fa-times-circle icon-black remove-qualification-link no-underl" +
"ine\"");

WriteLiteral(" data-bind=\"click: $root.removeQualification\"");

WriteLiteral("><i");

WriteLiteral(" class=\"visuallyhidden\"");

WriteLiteral(@">Remove this qualification</i></a></i>
                                </td>
                            </tr>
                        </tbody>
                    </table>
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
