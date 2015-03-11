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

namespace SFA.Apprenticeships.Web.Candidate.Views.Home
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/Helpdesk.cshtml")]
    public partial class Helpdesk : System.Web.Mvc.WebViewPage<SFA.Apprenticeships.Web.Candidate.ViewModels.Home.ContactMessageViewModel>
    {
        public Helpdesk()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Home\Helpdesk.cshtml"
  
    ViewBag.Title = "Contact us - Find an apprenticeship";
    Layout = "~/Views/Shared/_Layout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\r\n        <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">Contact us</h1>\r\n    </div>\r\n\r\n");

            
            #line 12 "..\..\Views\Home\Helpdesk.cshtml"
    
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Home\Helpdesk.cshtml"
     using (Html.BeginForm("HelpDesk", "Home", FormMethod.Post))
    {
            
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Home\Helpdesk.cshtml"
       Write(Html.FormTextFor(
                m => m.Name,
                containerHtmlAttributes: new { @class = "form-group-compound" },
                controlHtmlAttributes: new { type = "text", autocorrect = "off", maxlength = "71" }));

            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Home\Helpdesk.cshtml"
                                                                                                    

            
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Home\Helpdesk.cshtml"
       Write(Html.FormTextFor(
                m => m.Email,
                containerHtmlAttributes: new { @class = "form-group-compound" },
                 controlHtmlAttributes: new { type = "email", spellcheck = "false", maxlength = "100" },
                hintHtmlAttributes: new { @class = "text" }));

            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Home\Helpdesk.cshtml"
                                                            


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"contact-subject\"");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Briefly describe your question</label>\r\n");

WriteLiteral("                    ");

            
            #line 27 "..\..\Views\Home\Helpdesk.cshtml"
               Write(Html.DropDownListFor(m => m.SelectedEnquiry, Model.Enquiries, new { @id = "contact-subject", @class="hide-nojs small-btm-margin select-inject" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("                ");

            
            #line 29 "..\..\Views\Home\Helpdesk.cshtml"
           Write(Html.FormTextFor(
                m => m.Enquiry,
                containerHtmlAttributes: new { @class = "form-group-compound" },
          controlHtmlAttributes: new { type = "text", autocorrect = "off", @class = "select-injected", maxlength = "100" }, labelText: string.Empty));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 34 "..\..\Views\Home\Helpdesk.cshtml"
            
            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\Home\Helpdesk.cshtml"
       Write(Html.FormTextAreaFor(m => m.Details,
                controlHtmlAttributes: new { @data_val_length_max = "4000", rows = "4", role = "textbox", aria_multiline = "true" },
                hintHtmlAttributes: new { @class = "text" }));

            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Home\Helpdesk.cshtml"
                                                            

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" id=\"send-contact-form-button\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Send</button>\r\n            </div>\r\n");

            
            #line 40 "..\..\Views\Home\Helpdesk.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <section");

WriteLiteral(" class=\"text\"");

WriteLiteral(">\r\n        <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(@">Apprenticeship helpline</h2>
        <p>
            Contact the helpline if you’d prefer to speak to somebody, or if
            you're having difficulty with the contact form.
        </p>
        <p>
            Phone:
            <br>0800 015 0400
            <br>02476 826482
        </p>
        <p>
            Email: <a");

WriteLiteral(" href=\"mailto:nationalhelpdesk@findapprenticeship.service.gov.uk\"");

WriteLiteral(">nationalhelpdesk@findapprenticeship.service.gov.uk</a>\r\n        </p>\r\n        <p" +
">\r\n            Contact <a");

WriteLiteral(" href=\"https://nationalcareersservice.direct.gov.uk/Pages/Home.aspx\"");

WriteLiteral("\r\n                       rel=\"external\"");

WriteLiteral(">National Careers Service</a> (NCS) if you have a\r\n            question about whe" +
"ther an apprenticeship is right for you.\r\n        </p>\r\n    </section>\r\n");

        }
    }
}
#pragma warning restore 1591
