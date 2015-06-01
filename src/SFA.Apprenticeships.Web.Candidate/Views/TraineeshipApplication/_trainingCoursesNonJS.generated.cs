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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/TraineeshipApplication/_trainingCoursesNonJS.cshtml")]
    public partial class trainingCoursesNonJS : System.Web.Mvc.WebViewPage<SFA.Apprenticeships.Web.Candidate.ViewModels.Applications.TraineeshipApplicationViewModel>
    {
        public trainingCoursesNonJS()
        {
        }
        public override void Execute()
        {
WriteLiteral("<noscript>\r\n    <fieldset");

WriteLiteral(" class=\"fieldset-with-border\"");

WriteLiteral(" id=\"applyTrainingCourses\"");

WriteLiteral(">\r\n        <legend");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Training courses</legend>\r\n        <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n            <div>\r\n");

            
            #line 8 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                
            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                 for (var i = 0; i < Model.Candidate.TrainingCourses.Count() + Model.DefaultTrainingCourseRows; i++)
                {
                    if (i < Model.Candidate.TrainingCourses.Count())
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" id=\"training-history-item\"");

WriteLiteral(" class=\"grid-wrapper training-history-item\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"grid grid-1-2\"");

WriteLiteral(">\r\n                                <table");

WriteLiteral(" class=\"table-no-btm-border table-compound\"");

WriteLiteral(">\r\n                                    <thead>\r\n                                 " +
"       <tr>\r\n                                            <th>\r\n                 " +
"                               <span");

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

WriteLiteral(">\r\n                                                    <span");

WriteLiteral(" class=\"cell-span\"");

WriteLiteral(">Provider</span>\r\n");

WriteLiteral("                                                    ");

            
            #line 27 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                                               Write(Html.TextBoxFor(m => Model.Candidate.TrainingCourses.ToList()[i].Provider, new { @id = "candidate_trainingcourses_" + i + "__provider", Name = "Candidate.TrainingCourses[" + i + "].Provider", @class = "form-control", @maxlength = 50 }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                                    ");

            
            #line 28 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                                               Write(Html.ValidationMessage("Candidate.TrainingCourses[" + i + "].Provider"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                </div>\r\n                       " +
"                         <div");

WriteLiteral(" class=\"form-group form-group-compound inline-float width-all-49 no-right-margin\"" +
"");

WriteLiteral(">\r\n                                                    <span");

WriteLiteral(" class=\"cell-span\"");

WriteLiteral(">Course Title</span>\r\n");

WriteLiteral("                                                    ");

            
            #line 32 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                                               Write(Html.TextBoxFor(m => Model.Candidate.TrainingCourses.ToList()[i].Title, new { @id = "candidate_trainingcourses_" + i + "__title", Name = "Candidate.TrainingCourses[" + i + "].Title", @class = "form-control", @maxlength = 50 }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                                    ");

            
            #line 33 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                                               Write(Html.ValidationMessage("Candidate.TrainingCourses[" + i + "].Title"));

            
            #line default
            #line hidden
WriteLiteral(@"
                                                </div>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                            <div");

WriteLiteral(" class=\"grid grid-1-2\"");

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
                                            <td>
                                                <span");

WriteLiteral(" class=\"cell-span\"");

WriteLiteral(">From</span>\r\n                                                <div");

WriteLiteral(" class=\"form-group form-group-compound\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                    ");

            
            #line 66 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                                               Write(Html.DropDownListFor(m => Model.Candidate.TrainingCourses.ToList()[i].FromMonth, new SelectList(Model.Months, "Value", "Text", Model.Candidate.TrainingCourses.ToList()[i].FromMonth), new { @id = "candidate_trainingcourses_" + i + "__frommonth", Name = "Candidate.TrainingCourses[" + i + "].FromMonth" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                                                </div>\r\n                     " +
"                           <div");

WriteLiteral(" class=\"form-group form-group-compound\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                    ");

            
            #line 70 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                                               Write(Html.TextBoxFor(m => Model.Candidate.TrainingCourses.ToList()[i].FromYear, new { @id = "candidate_trainingcourses_" + i + "__fromyear", Name = "Candidate.TrainingCourses[" + i + "].FromYear", @class = "form-control", @maxlength = 4 }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("                                                    ");

            
            #line 72 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                                               Write(Html.ValidationMessage("Candidate.TrainingCourses[" + i + "].FromYear"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                </div>\r\n                       " +
"                     </td>\r\n                                            <td>\r\n  " +
"                                              <span");

WriteLiteral(" class=\"cell-span\"");

WriteLiteral(">To</span>\r\n                                                <div");

WriteLiteral(" class=\"form-group form-group-compound\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                    ");

            
            #line 78 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                                               Write(Html.DropDownListFor(m => Model.Candidate.TrainingCourses.ToList()[i].ToMonth, new SelectList(Model.Months, "Value", "Text", Model.Candidate.TrainingCourses.ToList()[i].ToMonth), new { @id = "candidate_trainingcourses_" + i + "__tomonth", Name = "Candidate.TrainingCourses[" + i + "].ToMonth" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                                                </div>\r\n                     " +
"                           <div");

WriteLiteral(" class=\"form-group form-group-compound\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                    ");

            
            #line 82 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                                               Write(Html.TextBoxFor(m => Model.Candidate.TrainingCourses.ToList()[i].ToYear, new { @id = "candidate_trainingcourses_" + i + "__toyear", Name = "Candidate.TrainingCourses[" + i + "].ToYear", @class = "form-control", @maxlength = 4 }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("                                                    ");

            
            #line 84 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                                               Write(Html.ValidationMessage("Candidate.TrainingCourses[" + i + "].ToYear"));

            
            #line default
            #line hidden
WriteLiteral(@"
                                                </div>
                                            </td>
                                            <td></td>
                                            <td></td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
");

            
            #line 94 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" id=\"training-history-item\"");

WriteLiteral(" class=\"grid-wrapper training-history-item\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"grid grid-1-2\"");

WriteLiteral(">\r\n                                <table");

WriteLiteral(" class=\"table-no-btm-border table-compound\"");

WriteLiteral(">\r\n                                    <thead>\r\n                                 " +
"       <tr>\r\n                                            <th>\r\n                 " +
"                               <span");

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

WriteLiteral(">\r\n                                                    <span");

WriteLiteral(" class=\"cell-span\"");

WriteLiteral(">Provider</span>\r\n");

WriteLiteral("                                                    ");

            
            #line 112 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                                               Write(Html.TextBox("Candidate.TrainingCourses[" + i + "].Provider", "", new { @id = "candidate_trainingcourses_" + i + "__provider", Name = "Candidate.TrainingCourses[" + i + "].Provider", @class = "form-control", @maxlength = 50 }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                                    ");

            
            #line 113 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                                               Write(Html.ValidationMessage("Candidate.TrainingCourses[" + i + "].Provider"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                </div>\r\n                       " +
"                         <div");

WriteLiteral(" class=\"form-group form-group-compound inline-float width-all-49 no-right-margin\"" +
"");

WriteLiteral(">\r\n                                                    <span");

WriteLiteral(" class=\"cell-span\"");

WriteLiteral(">Course Title</span>\r\n");

WriteLiteral("                                                    ");

            
            #line 117 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                                               Write(Html.TextBox("Candidate.TrainingCourses[" + i + "].Title", "", new { @id = "candidate_trainingcourses_" + i + "__title", Name = "Candidate.TrainingCourses[" + i + "].Title", @class = "form-control", @maxlength = 50 }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                                    ");

            
            #line 118 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                                               Write(Html.ValidationMessage("Candidate.TrainingCourses[" + i + "].Title"));

            
            #line default
            #line hidden
WriteLiteral(@"
                                                </div>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                            <div");

WriteLiteral(" class=\"grid grid-1-2\"");

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
                                            <td>
                                                <span");

WriteLiteral(" class=\"cell-span\"");

WriteLiteral(">From</span>\r\n                                                <div");

WriteLiteral(" class=\"form-group form-group-compound\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                    ");

            
            #line 151 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                                               Write(Html.DropDownList("Candidate.TrainingCourses[" + i + "].FromMonth", new SelectList(Model.Months, "Value", "Text", 1), new { @id = "candidate_trainingcourses_" + i + "__frommonth", Name = "Candidate.TrainingCourses[" + i + "].FromMonth" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                                                </div>\r\n                     " +
"                           <div");

WriteLiteral(" class=\"form-group form-group-compound\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                    ");

            
            #line 155 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                                               Write(Html.TextBox("Candidate.TrainingCourses[" + i + "].FromYear", "", new { @id = "candidate_trainingcourses_" + i + "__fromyear", Name = "Candidate.TrainingCourses[" + i + "].FromYear", @class = "form-control", @maxlength = 4 }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                                    ");

            
            #line 156 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                                               Write(Html.ValidationMessage("Candidate.TrainingCourses[" + i + "].FromYear"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                </div>\r\n                       " +
"                     </td>\r\n                                            <td>\r\n  " +
"                                              <span");

WriteLiteral(" class=\"cell-span\"");

WriteLiteral(">To</span>\r\n                                                <div");

WriteLiteral(" class=\"form-group form-group-compound\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                    ");

            
            #line 162 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                                               Write(Html.DropDownList("Candidate.TrainingCourses[" + i + "].ToMonth", new SelectList(Model.Months, "Value", "Text", 1), new { @id = "candidate_trainingcourses_" + i + "__tomonth", Name = "Candidate.TrainingCourses[" + i + "].ToMonth" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                                                </div>\r\n                     " +
"                           <div");

WriteLiteral(" class=\"form-group form-group-compound\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                    ");

            
            #line 166 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                                               Write(Html.TextBox("Candidate.TrainingCourses[" + i + "].ToYear", "", new { @id = "candidate_trainingcourses_" + i + "__toyear", Name = "Candidate.TrainingCourses[" + i + "].ToYear", @class = "form-control", @maxlength = 4 }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                                    ");

            
            #line 167 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                                               Write(Html.ValidationMessage("Candidate.TrainingCourses[" + i + "].ToYear"));

            
            #line default
            #line hidden
WriteLiteral(@"
                                                </div>
                                            </td>
                                            <td></td>
                                            <td></td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
");

            
            #line 177 "..\..\Views\TraineeshipApplication\_trainingCoursesNonJS.cshtml"
                    }
                }

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" id=\"add-training-history-rows-button\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" name=\"ApplicationAction:AddEmptyTrainingCourseRows\"");

WriteLiteral(">Add 1 more training course</button>\r\n                </div>\r\n            </div>\r" +
"\n        </div>\r\n    </fieldset>\r\n</noscript>");

        }
    }
}
#pragma warning restore 1591
