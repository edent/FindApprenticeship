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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ApprenticeshipApplication/_qualificationsNonJS.cshtml")]
    public partial class qualificationsNonJS : System.Web.Mvc.WebViewPage<SFA.Apprenticeships.Web.Candidate.ViewModels.Applications.ApprenticeshipApplicationViewModel>
    {
        public qualificationsNonJS()
        {
        }
        public override void Execute()
        {
WriteLiteral("<noscript>\r\n    <fieldset");

WriteLiteral(" class=\"fieldset-with-border\"");

WriteLiteral(" id=\"applyQualifications\"");

WriteLiteral(">\r\n        <legend");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Qualifications</legend>\r\n        <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral("></div>\r\n        <div>\r\n            <table>\r\n                <thead>\r\n           " +
"         <tr>\r\n                        <th>\r\n                            <span");

WriteLiteral(" class=\"heading-span\"");

WriteLiteral(">Subject</span>\r\n                        </th>\r\n                        <th>\r\n   " +
"                         <span");

WriteLiteral(" class=\"heading-span\"");

WriteLiteral(">Qualification</span>\r\n                        </th>\r\n                        <th" +
">\r\n                            <span");

WriteLiteral(" class=\"heading-span\"");

WriteLiteral(">Year</span>\r\n                        </th>\r\n                        <th>\r\n      " +
"                      <span");

WriteLiteral(" class=\"heading-span\"");

WriteLiteral(">Grade</span>\r\n                        </th>\r\n                        <th>\r\n     " +
"                       <span");

WriteLiteral(" class=\"heading-span\"");

WriteLiteral(">Predicted?</span>\r\n                        </th>\r\n                    </tr>\r\n   " +
"             </thead>\r\n                <tbody>\r\n\r\n");

            
            #line 29 "..\..\Views\ApprenticeshipApplication\_qualificationsNonJS.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\ApprenticeshipApplication\_qualificationsNonJS.cshtml"
                     for (var i = 0; i < Model.Candidate.Qualifications.Count() + Model.DefaultQualificationRows; i++)
                    {                        
                        if (i < Model.Candidate.Qualifications.Count())
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <tr>\r\n                                <td>\r\n         " +
"                      \r\n");

WriteLiteral("                                    ");

            
            #line 36 "..\..\Views\ApprenticeshipApplication\_qualificationsNonJS.cshtml"
                               Write(Html.TextBoxFor(m => Model.Candidate.Qualifications.ToList()[i].Subject, new {@id = "candidate_qualifications_" + i + "__subject", Name = "Candidate.Qualifications[" + i + "].Subject", @class = "form-control qual-input-edit", @maxlength = 50}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                   ");

            
            #line 37 "..\..\Views\ApprenticeshipApplication\_qualificationsNonJS.cshtml"
                              Write(Html.ValidationMessage("Candidate.Qualifications[" + i + "].Subject"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n");

WriteLiteral("                                    ");

            
            #line 40 "..\..\Views\ApprenticeshipApplication\_qualificationsNonJS.cshtml"
                               Write(Html.TextBoxFor(m => Model.Candidate.Qualifications.ToList()[i].QualificationType, new {@id = "candidate_qualifications_" + i + "__qualificationtype", Name = "Candidate.Qualifications[" + i + "].QualificationType", @class = "form-control qual-input-edit", @maxlength = 50}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                   ");

            
            #line 41 "..\..\Views\ApprenticeshipApplication\_qualificationsNonJS.cshtml"
                              Write(Html.ValidationMessage("Candidate.Qualifications[" + i + "].QualificationType"));

            
            #line default
            #line hidden
WriteLiteral("                                   \r\n                                </td>\r\n\r\n   " +
"                             <td>\r\n");

WriteLiteral("                                    ");

            
            #line 45 "..\..\Views\ApprenticeshipApplication\_qualificationsNonJS.cshtml"
                               Write(Html.TextBoxFor(m => Model.Candidate.Qualifications.ToList()[i].Year, new { @id = "candidate_qualifications_" + i + "__year", Name = "Candidate.Qualifications[" + i + "].Year", @class = "form-control qual-input-edit", @maxlength = 4 }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                    ");

            
            #line 46 "..\..\Views\ApprenticeshipApplication\_qualificationsNonJS.cshtml"
                               Write(Html.ValidationMessage("Candidate.Qualifications[" + i + "].Year"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n  " +
"                                  <div");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">\r\n");

WriteLiteral("                                        ");

            
            #line 50 "..\..\Views\ApprenticeshipApplication\_qualificationsNonJS.cshtml"
                                   Write(Html.TextBoxFor(m => Model.Candidate.Qualifications.ToList()[i].Grade, new {@id = "candidate_qualifications_" + i + "__grade", Name = "Candidate.Qualifications[" + i + "].Grade", @class = "form-control qual-input-edit", @maxlength = 15}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                        ");

            
            #line 51 "..\..\Views\ApprenticeshipApplication\_qualificationsNonJS.cshtml"
                                   Write(Html.ValidationMessage("Candidate.Qualifications[" + i + "].Grade"));

            
            #line default
            #line hidden
WriteLiteral(" \r\n                                    </div>\r\n                                </" +
"td>\r\n                                <td");

WriteLiteral(" class=\"ta-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 55 "..\..\Views\ApprenticeshipApplication\_qualificationsNonJS.cshtml"
                               Write(Html.CheckBoxFor(m => Model.Candidate.Qualifications.ToList()[i].IsPredicted, new {@id = "candidate_qualifications_" + i + "__ispredicted", Name = "Candidate.Qualifications[" + i + "].IsPredicted"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");

            
            #line 58 "..\..\Views\ApprenticeshipApplication\_qualificationsNonJS.cshtml"
                        }
                        else
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <tr>\r\n                                <td>\r\n");

WriteLiteral("                                    ");

            
            #line 63 "..\..\Views\ApprenticeshipApplication\_qualificationsNonJS.cshtml"
                               Write(Html.TextBox("Candidate.Qualifications[" + i + "].Subject", "", new {@id = "candidate_qualifications_" + i + "__subject", Name = "Candidate.Qualifications[" + i + "].Subject", @class = "form-control qual-input-edit", @maxlength = 50}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                    ");

            
            #line 64 "..\..\Views\ApprenticeshipApplication\_qualificationsNonJS.cshtml"
                               Write(Html.ValidationMessage("Candidate.Qualifications[" + i + "].Subject"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n");

WriteLiteral("                                    ");

            
            #line 67 "..\..\Views\ApprenticeshipApplication\_qualificationsNonJS.cshtml"
                               Write(Html.TextBox("Candidate.Qualifications[" + i + "].QualificationType", "", new {@id = "candidate_qualifications_" + i + "__qualificationtype", Name = "Candidate.Qualifications[" + i + "].QualificationType", @class = "form-control qual-input-edit", @maxlength = 50}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                    ");

            
            #line 68 "..\..\Views\ApprenticeshipApplication\_qualificationsNonJS.cshtml"
                               Write(Html.ValidationMessage("Candidate.Qualifications[" + i + "].QualificationType"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    \r\n                                </td>\r\n\r\n" +
"                                <td>\r\n");

WriteLiteral("                                    ");

            
            #line 73 "..\..\Views\ApprenticeshipApplication\_qualificationsNonJS.cshtml"
                               Write(Html.TextBox("Candidate.Qualifications[" + i + "].Year", "", new {@id = "candidate_qualifications_" + i + "__year", Name = "Candidate.Qualifications[" + i + "].Year", @class = "form-control qual-input-edit", @maxlength = 4}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                    ");

            
            #line 74 "..\..\Views\ApprenticeshipApplication\_qualificationsNonJS.cshtml"
                               Write(Html.ValidationMessage("Candidate.Qualifications[" + i + "].Year"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n  " +
"                                  <div");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">\r\n");

WriteLiteral("                                        ");

            
            #line 78 "..\..\Views\ApprenticeshipApplication\_qualificationsNonJS.cshtml"
                                   Write(Html.TextBox("Candidate.Qualifications[" + i + "].Grade", "", new {@id = "candidate_qualifications_" + i + "__grade", Name = "Candidate.Qualifications[" + i + "].Grade", @class = "form-control qual-input-edit", @maxlength = 11}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                        ");

            
            #line 79 "..\..\Views\ApprenticeshipApplication\_qualificationsNonJS.cshtml"
                                   Write(Html.ValidationMessage("Candidate.Qualifications[" + i + "].Grade"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        \r\n                                    <" +
"/div>\r\n                                </td>\r\n                                <t" +
"d");

WriteLiteral(" class=\"ta-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 84 "..\..\Views\ApprenticeshipApplication\_qualificationsNonJS.cshtml"
                               Write(Html.CheckBox("Candidate.Qualifications[" + i + "].IsPredicted", new {@id = "candidate_qualifications_" + i + "__ispredicted", Name = "Candidate.Qualifications[" + i + "].IsPredicted"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");

            
            #line 87 "..\..\Views\ApprenticeshipApplication\_qualificationsNonJS.cshtml"
                        }
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" id=\"add-qualification-rows-button\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" name=\"ApplicationAction\"");

WriteLiteral(" value=\"AddEmptyQualificationRows\"");

WriteLiteral(">Add 5 more qualifications</button>\r\n            </div>\r\n        </div>\r\n\r\n    </" +
"fieldset>\r\n</noscript>");

        }
    }
}
#pragma warning restore 1591
