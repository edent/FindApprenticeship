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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ApprenticeshipApplication/_workExperiencesNonJS.cshtml")]
    public partial class workExperiencesNonJS : System.Web.Mvc.WebViewPage<SFA.Apprenticeships.Web.Candidate.ViewModels.Applications.ApprenticeshipApplicationViewModel>
    {
        public workExperiencesNonJS()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<noscript>\r\n\r\n    <fieldset");

WriteLiteral(" class=\"fieldset-with-border\"");

WriteLiteral(" id=\"applyWorkExperience\"");

WriteLiteral(">\r\n        <legend");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Work experience</legend>       \r\n\r\n        <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n            <div>\r\n");

            
            #line 11 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                 for (var i = 0; i < Model.Candidate.WorkExperience.Count() + Model.DefaultWorkExperienceRows; i++)
                {
                    if (i < Model.Candidate.WorkExperience.Count())
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" id=\"work-history-item\"");

WriteLiteral(" class=\"grid-wrapper work-history-item\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"grid grid-1-2\"");

WriteLiteral(">\r\n                                <table");

WriteLiteral(" class=\"table-no-btm-border table-compound\"");

WriteLiteral(">\r\n                                    <thead>\r\n                                 " +
"       <tr>\r\n                                            <th>\r\n                 " +
"                               <span");

WriteLiteral(" class=\"heading-span\"");

WriteLiteral(@">Work experience</span>
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

WriteLiteral(">Employer</span>\r\n\r\n");

WriteLiteral("                                                    ");

            
            #line 31 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                               Write(Html.TextBoxFor(m => Model.Candidate.WorkExperience.ToList()[i].Employer, new { @id = "candidate_workexperience_" + i + "__employer", Name = "Candidate.WorkExperience[" + i + "].Employer", @class = "form-control", @maxlength = 50 }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("                                                    ");

            
            #line 33 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                               Write(Html.ValidationMessage("Candidate.WorkExperience[" + i + "].Employer"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                </div>\r\n\r\n                     " +
"                           <div");

WriteLiteral(" class=\"form-group form-group-compound inline-float width-all-49 no-right-margin\"" +
"");

WriteLiteral(">\r\n                                                    <span");

WriteLiteral(" class=\"cell-span\"");

WriteLiteral(">Job Title</span>\r\n");

WriteLiteral("                                                    ");

            
            #line 38 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                               Write(Html.TextBoxFor(m => Model.Candidate.WorkExperience.ToList()[i].JobTitle, new { @id = "candidate_workexperience_" + i + "__jobtitle", Name = "Candidate.WorkExperience[" + i + "].JobTitle", @class = "form-control", @maxlength = 50 }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("                                                    ");

            
            #line 40 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                               Write(Html.ValidationMessage("Candidate.WorkExperience[" + i + "].JobTitle"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                </div>\r\n\r\n                     " +
"                           <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral("></div>\r\n                                                <span");

WriteLiteral(" class=\"cell-span\"");

WriteLiteral(">Main Duties</span>\r\n");

WriteLiteral("                                                ");

            
            #line 45 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                           Write(Html.TextAreaFor(m => Model.Candidate.WorkExperience.ToList()[i].Description, new { @id = "candidate_workexperience_" + i + "__description", Name = "Candidate.WorkExperience[" + i + "].Description", @class = "form-control", @rows = 3 }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("                                                ");

            
            #line 47 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                           Write(Html.ValidationMessage("Candidate.WorkExperience[" + i + "].Description"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                        </tr>\r\n                           " +
"         </tbody>\r\n                                </table>\r\n                   " +
"         </div>\r\n                            <div");

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

            
            #line 78 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                               Write(Html.DropDownListFor(m => Model.Candidate.WorkExperience.ToList()[i].FromMonth, new SelectList(Model.Months, "Value", "Text", Model.Candidate.WorkExperience.ToList()[i].FromMonth), new { @id = "candidate_workexperience_" + i + "__frommonth", Name = "Candidate.WorkExperience[" + i + "].FromMonth" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                                                </div>\r\n                     " +
"                           <div");

WriteLiteral(" class=\"form-group form-group-compound\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                    ");

            
            #line 82 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                               Write(Html.TextBoxFor(m => Model.Candidate.WorkExperience.ToList()[i].FromYear, new {@id = "candidate_workexperience_" + i + "__fromyear", Name = "Candidate.WorkExperience[" + i + "].FromYear", @class = "form-control", @maxlength = 4}));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                \r\n");

WriteLiteral("                                                    ");

            
            #line 84 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                               Write(Html.ValidationMessage("Candidate.WorkExperience[" + i + "].FromYear"));

            
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

            
            #line 90 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                               Write(Html.DropDownListFor(m => Model.Candidate.WorkExperience.ToList()[i].ToMonth, new SelectList(Model.Months, "Value", "Text", Model.Candidate.WorkExperience.ToList()[i].ToMonth), new { @id = "candidate_workexperience_" + i + "__tomonth", Name = "Candidate.WorkExperience[" + i + "].ToMonth" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                                                </div>\r\n                     " +
"                           <div");

WriteLiteral(" class=\"form-group form-group-compound\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                    ");

            
            #line 94 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                               Write(Html.TextBoxFor(m => Model.Candidate.WorkExperience.ToList()[i].ToYear, new { @id = "candidate_workexperience_" + i + "__toyear", Name = "Candidate.WorkExperience[" + i + "].ToYear", @class = "form-control", @maxlength = 4 }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("                                                    ");

            
            #line 96 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                               Write(Html.ValidationMessage("Candidate.WorkExperience[" + i + "].ToYear"));

            
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

            
            #line 106 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" id=\"work-history-item\"");

WriteLiteral(" class=\"grid-wrapper work-history-item\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"grid grid-1-2\"");

WriteLiteral(">\r\n                                <table");

WriteLiteral(" class=\"table-no-btm-border table-compound\"");

WriteLiteral(">\r\n                                    <thead>\r\n                                 " +
"       <tr>\r\n                                            <th>\r\n                 " +
"                               <span");

WriteLiteral(" class=\"heading-span\"");

WriteLiteral(@">Work experience</span>
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

WriteLiteral(">Employer</span>\r\n\r\n");

WriteLiteral("                                                    ");

            
            #line 125 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                               Write(Html.TextBox("Candidate.WorkExperience[" + i + "].Employer", "", new {@id = "candidate_workexperience_" + i + "__employer", Name = "Candidate.WorkExperience[" + i + "].Employer", @class = "form-control", @maxlength = 50}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                                    ");

            
            #line 126 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                               Write(Html.ValidationMessage("Candidate.WorkExperience[" + i + "].Employer"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                </div>\r\n\r\n                     " +
"                           <div");

WriteLiteral(" class=\"form-group form-group-compound inline-float width-all-49 no-right-margin\"" +
"");

WriteLiteral(">\r\n                                                    <span");

WriteLiteral(" class=\"cell-span\"");

WriteLiteral(">Job Title</span>\r\n");

WriteLiteral("                                                    ");

            
            #line 131 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                               Write(Html.TextBox("Candidate.WorkExperience[" + i + "].JobTitle", "", new {@id = "candidate_workexperience_" + i + "__jobtitle", Name = "Candidate.WorkExperience[" + i + "].JobTitle", @class = "form-control", @maxlength = 50}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                                    ");

            
            #line 132 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                               Write(Html.ValidationMessage("Candidate.WorkExperience[" + i + "].JobTitle"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                </div>\r\n\r\n                     " +
"                           <div></div>\r\n                                        " +
"        <span");

WriteLiteral(" class=\"cell-span\"");

WriteLiteral(">Main Duties</span>\r\n");

WriteLiteral("                                                ");

            
            #line 137 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                           Write(Html.TextArea("Candidate.WorkExperience[" + i + "].Description", "", new {@id = "candidate_workexperience_" + i + "__description", Name = "Candidate.WorkExperience[" + i + "].Description", @class = "form-control", @rows = 3}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                                ");

            
            #line 138 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                           Write(Html.ValidationMessage("Candidate.WorkExperience[" + i + "].Description"));

            
            #line default
            #line hidden
WriteLiteral(@"
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

            
            #line 170 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                               Write(Html.DropDownList("Candidate.WorkExperience[" + i + "].FromMonth", new SelectList(Model.Months, "Value","Text",1), new { @id = "candidate_workexperience_" + i + "__frommonth", Name = "Candidate.WorkExperience[" + i + "].FromMonth" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                                                </div>\r\n                     " +
"                           <div");

WriteLiteral(" class=\"form-group form-group-compound\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                    ");

            
            #line 174 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                               Write(Html.TextBox("Candidate.WorkExperience[" + i + "].FromYear", "", new {@id = "candidate_workexperience_" + i + "__fromyear", Name = "Candidate.WorkExperience[" + i + "].FromYear", @class = "form-control", @maxlength = 4}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                                    ");

            
            #line 175 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                               Write(Html.ValidationMessage("Candidate.WorkExperience[" + i + "].FromYear"));

            
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

            
            #line 181 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                               Write(Html.DropDownList("Candidate.WorkExperience[" + i + "].ToMonth", new SelectList(Model.Months, "Value", "Text", 1), new { @id = "candidate_workexperience_" + i + "__tomonth", Name = "Candidate.WorkExperience[" + i + "].ToMonth" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                                                </div>\r\n                     " +
"                           <div");

WriteLiteral(" class=\"form-group form-group-compound\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                    ");

            
            #line 185 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                               Write(Html.TextBox("Candidate.WorkExperience[" + i + "].ToYear", "", new {@id = "candidate_workexperience_" + i + "__toyear", Name = "Candidate.WorkExperience[" + i + "].ToYear", @class = "form-control", @maxlength = 4}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                                    ");

            
            #line 186 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                                               Write(Html.ValidationMessage("Candidate.WorkExperience[" + i + "].ToYear"));

            
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

            
            #line 196 "..\..\Views\ApprenticeshipApplication\_workExperiencesNonJS.cshtml"
                    }
                }                              

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n\r\n                    <button");

WriteLiteral(" id=\"add-workexperience-rows-button\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" name=\"ApplicationAction:AddEmptyWorkExperienceRows\"");

WriteLiteral(">Add 1 more work experience</button>\r\n\r\n                </div>\r\n            </div" +
">\r\n        </div>\r\n\r\n    </fieldset>\r\n</noscript>");

        }
    }
}
#pragma warning restore 1591
