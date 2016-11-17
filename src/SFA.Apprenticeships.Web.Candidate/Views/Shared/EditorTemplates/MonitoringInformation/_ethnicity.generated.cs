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

namespace SFA.Apprenticeships.Web.Candidate.Views.Shared.EditorTemplates.MonitoringInformation
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/EditorTemplates/MonitoringInformation/_ethnicity.cshtml")]
    public partial class ethnicity : System.Web.Mvc.WebViewPage<MonitoringInformationViewModel>
    {
        public ethnicity()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"form-group inline clearfix\"");

WriteLiteral(">\r\n    <p");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(" id=\"disability-label\"");

WriteLiteral(">What is your ethnic group?</p>\r\n    <p");

WriteLiteral(" class=\"form-hint text\"");

WriteLiteral(">\r\n        We need this information to make sure we\'re giving equal opportunities" +
"\r\n        to all candidates\r\n    </p>\r\n    <select");

WriteLiteral(" class=\"form-control\"");

WriteAttribute("id", Tuple.Create(" id=\"", 344), Tuple.Create("\"", 378)
            
            #line 9 "..\..\Views\Shared\EditorTemplates\MonitoringInformation\_ethnicity.cshtml"
, Tuple.Create(Tuple.Create("", 349), Tuple.Create<System.Object, System.Int32>(Html.IdFor(m => m.Ethnicity)
            
            #line default
            #line hidden
, 349), false)
);

WriteAttribute("name", Tuple.Create(" name=\"", 379), Tuple.Create("\"", 417)
            
            #line 9 "..\..\Views\Shared\EditorTemplates\MonitoringInformation\_ethnicity.cshtml"
, Tuple.Create(Tuple.Create("", 386), Tuple.Create<System.Object, System.Int32>(Html.NameFor(m => m.Ethnicity)
            
            #line default
            #line hidden
, 386), false)
);

WriteLiteral(" class=\"para-btm-margin\"");

WriteLiteral(">\r\n        <option");

WriteLiteral(" value=\"0\"");

            
            #line 10 "..\..\Views\Shared\EditorTemplates\MonitoringInformation\_ethnicity.cshtml"
                     Write(Model != null && Model.Ethnicity == 0 ? " selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">-- Please select --</option>\r\n        <option");

WriteLiteral(" value=\"99\"");

            
            #line 11 "..\..\Views\Shared\EditorTemplates\MonitoringInformation\_ethnicity.cshtml"
                      Write(Model != null && Model.Ethnicity == 99 ? " selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">Prefer not to say</option>\r\n        <optgroup");

WriteLiteral(" label=\"White\"");

WriteLiteral(">\r\n            <option");

WriteLiteral(" value=\"31\"");

            
            #line 13 "..\..\Views\Shared\EditorTemplates\MonitoringInformation\_ethnicity.cshtml"
                          Write(Model != null && Model.Ethnicity == 31 ? " selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">English / Welsh / Scottish / Northern Irish / British</option>\r\n            <opt" +
"ion");

WriteLiteral(" value=\"32\"");

            
            #line 14 "..\..\Views\Shared\EditorTemplates\MonitoringInformation\_ethnicity.cshtml"
                          Write(Model != null && Model.Ethnicity == 32 ? " selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">Irish</option>\r\n            <option");

WriteLiteral(" value=\"33\"");

            
            #line 15 "..\..\Views\Shared\EditorTemplates\MonitoringInformation\_ethnicity.cshtml"
                          Write(Model != null && Model.Ethnicity == 33 ? " selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">Gypsy or Irish Traveller</option>\r\n            <option");

WriteLiteral(" value=\"34\"");

            
            #line 16 "..\..\Views\Shared\EditorTemplates\MonitoringInformation\_ethnicity.cshtml"
                          Write(Model != null && Model.Ethnicity == 34 ? " selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">Any other White background</option>\r\n        </optgroup>\r\n        <optgroup");

WriteLiteral(" label=\"Mixed / Multiple ethnic groups\"");

WriteLiteral(">\r\n            <option");

WriteLiteral(" value=\"35\"");

            
            #line 19 "..\..\Views\Shared\EditorTemplates\MonitoringInformation\_ethnicity.cshtml"
                          Write(Model != null && Model.Ethnicity == 35 ? " selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">White and Black Caribbean</option>\r\n            <option");

WriteLiteral(" value=\"36\"");

            
            #line 20 "..\..\Views\Shared\EditorTemplates\MonitoringInformation\_ethnicity.cshtml"
                          Write(Model != null && Model.Ethnicity == 36 ? " selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">White and Black African</option>\r\n            <option");

WriteLiteral(" value=\"37\"");

            
            #line 21 "..\..\Views\Shared\EditorTemplates\MonitoringInformation\_ethnicity.cshtml"
                          Write(Model != null && Model.Ethnicity == 37 ? " selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">White and Asian</option>\r\n            <option");

WriteLiteral(" value=\"38\"");

            
            #line 22 "..\..\Views\Shared\EditorTemplates\MonitoringInformation\_ethnicity.cshtml"
                          Write(Model != null && Model.Ethnicity == 38 ? " selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">Any other Mixed / Multiple ethnic background</option>\r\n        </optgroup>\r\n    " +
"    <optgroup");

WriteLiteral(" label=\"Asian / Asian British\"");

WriteLiteral(">\r\n            <option");

WriteLiteral(" value=\"39\"");

            
            #line 25 "..\..\Views\Shared\EditorTemplates\MonitoringInformation\_ethnicity.cshtml"
                          Write(Model != null && Model.Ethnicity == 39 ? " selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">Indian</option>\r\n            <option");

WriteLiteral(" value=\"40\"");

            
            #line 26 "..\..\Views\Shared\EditorTemplates\MonitoringInformation\_ethnicity.cshtml"
                          Write(Model != null && Model.Ethnicity == 40 ? " selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">Pakistani</option>\r\n            <option");

WriteLiteral(" value=\"41\"");

            
            #line 27 "..\..\Views\Shared\EditorTemplates\MonitoringInformation\_ethnicity.cshtml"
                          Write(Model != null && Model.Ethnicity == 41 ? " selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">Bangladeshi</option>\r\n            <option");

WriteLiteral(" value=\"42\"");

            
            #line 28 "..\..\Views\Shared\EditorTemplates\MonitoringInformation\_ethnicity.cshtml"
                          Write(Model != null && Model.Ethnicity == 42 ? " selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">Chinese</option>\r\n            <option");

WriteLiteral(" value=\"43\"");

            
            #line 29 "..\..\Views\Shared\EditorTemplates\MonitoringInformation\_ethnicity.cshtml"
                          Write(Model != null && Model.Ethnicity == 43 ? " selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">Any other Asian background</option>\r\n        </optgroup>\r\n        <optgroup");

WriteLiteral(" label=\"Black / African / Caribbean / Black British\"");

WriteLiteral(">\r\n            <option");

WriteLiteral(" value=\"44\"");

            
            #line 32 "..\..\Views\Shared\EditorTemplates\MonitoringInformation\_ethnicity.cshtml"
                          Write(Model != null && Model.Ethnicity == 44 ? " selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">African</option>\r\n            <option");

WriteLiteral(" value=\"45\"");

            
            #line 33 "..\..\Views\Shared\EditorTemplates\MonitoringInformation\_ethnicity.cshtml"
                          Write(Model != null && Model.Ethnicity == 45 ? " selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">Caribbean</option>\r\n            <option");

WriteLiteral(" value=\"46\"");

            
            #line 34 "..\..\Views\Shared\EditorTemplates\MonitoringInformation\_ethnicity.cshtml"
                          Write(Model != null && Model.Ethnicity == 46 ? " selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">Any other Black / African / Caribbean background</option>\r\n        </optgroup>\r\n" +
"        <optgroup");

WriteLiteral(" label=\"Other ethnic group\"");

WriteLiteral(">\r\n            <option");

WriteLiteral(" value=\"47\"");

            
            #line 37 "..\..\Views\Shared\EditorTemplates\MonitoringInformation\_ethnicity.cshtml"
                          Write(Model != null && Model.Ethnicity == 47 ? " selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">Arab</option>\r\n            <option");

WriteLiteral(" value=\"98\"");

            
            #line 38 "..\..\Views\Shared\EditorTemplates\MonitoringInformation\_ethnicity.cshtml"
                          Write(Model != null && Model.Ethnicity == 98 ? " selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">Any other ethnic group</option>\r\n        </optgroup>\r\n    </select>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
