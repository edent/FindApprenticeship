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

namespace SFA.Apprenticeships.Web.Candidate.Views.ApprenticeshipApplication.DisplayTemplates
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ApprenticeshipApplication/DisplayTemplates/ApprenticeshipCandidateViewMod" +
        "el.cshtml")]
    public partial class ApprenticeshipCandidateViewModel_ : System.Web.Mvc.WebViewPage<ApprenticeshipCandidateViewModel>
    {
        public ApprenticeshipCandidateViewModel_()
        {
        }
        public override void Execute()
        {
WriteLiteral("<section");

WriteLiteral(" class=\"section-border grid-wrapper\"");

WriteLiteral(">\r\n    <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Your details</h2>\r\n    <div");

WriteLiteral(" class=\"grid grid-1-2\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <p");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Full name</p>\r\n");

WriteLiteral("            ");

            
            #line 8 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\ApprenticeshipCandidateViewModel.cshtml"
       Write(Html.HiddenFor(m => m.FirstName));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 9 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\ApprenticeshipCandidateViewModel.cshtml"
       Write(Html.HiddenFor(m => m.LastName));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" id=\"candidate-fullname\"");

WriteLiteral(" class=\"form-prepopped\"");

WriteLiteral(">");

            
            #line 10 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\ApprenticeshipCandidateViewModel.cshtml"
                                                            Write(Html.DisplayFor(model => model.FullName));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group date-input\"");

WriteLiteral(">\r\n            <p");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Date of birth</p>\r\n");

WriteLiteral("            ");

            
            #line 14 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\ApprenticeshipCandidateViewModel.cshtml"
       Write(Html.HiddenFor(m => m.DateOfBirth));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" id=\"candidate-dob\"");

WriteLiteral(" class=\"form-prepopped\"");

WriteLiteral(">");

            
            #line 15 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\ApprenticeshipCandidateViewModel.cshtml"
                                                       Write(Html.DisplayFor(model => model.DateOfBirth, "Date"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Address</span>\r\n            <ul");

WriteLiteral(" class=\"list-text form-prepopped\"");

WriteLiteral(">\r\n                <li");

WriteLiteral(" id=\"candidate-address-line1\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 21 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\ApprenticeshipCandidateViewModel.cshtml"
               Write(Html.HiddenFor(m => m.Address.AddressLine1));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 22 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\ApprenticeshipCandidateViewModel.cshtml"
               Write(Model.Address.AddressLine1);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li");

WriteLiteral(" id=\"candidate-address-line2\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 25 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\ApprenticeshipCandidateViewModel.cshtml"
               Write(Html.HiddenFor(m => m.Address.AddressLine2));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 26 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\ApprenticeshipCandidateViewModel.cshtml"
               Write(Model.Address.AddressLine2);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li");

WriteLiteral(" id=\"candidate-address-line3\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 29 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\ApprenticeshipCandidateViewModel.cshtml"
               Write(Html.HiddenFor(m => m.Address.AddressLine3));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 30 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\ApprenticeshipCandidateViewModel.cshtml"
               Write(Model.Address.AddressLine3);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li");

WriteLiteral(" id=\"candidate-address-line4\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 33 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\ApprenticeshipCandidateViewModel.cshtml"
               Write(Html.HiddenFor(m => m.Address.AddressLine4));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 34 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\ApprenticeshipCandidateViewModel.cshtml"
               Write(Model.Address.AddressLine4);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li");

WriteLiteral(" id=\"candidate-address-postcode\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 37 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\ApprenticeshipCandidateViewModel.cshtml"
               Write(Html.HiddenFor(m => m.Address.Postcode));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 38 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\ApprenticeshipCandidateViewModel.cshtml"
               Write(Model.Address.Postcode);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"grid grid-1-2\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <p");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Email address</p>\r\n");

WriteLiteral("            ");

            
            #line 46 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\ApprenticeshipCandidateViewModel.cshtml"
       Write(Html.HiddenFor(m => m.EmailAddress));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" id=\"candidate-email\"");

WriteLiteral(" class=\"form-prepopped\"");

WriteLiteral(">");

            
            #line 47 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\ApprenticeshipCandidateViewModel.cshtml"
                                                         Write(Model.EmailAddress);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <p");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Phone</p>\r\n");

WriteLiteral("            ");

            
            #line 51 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\ApprenticeshipCandidateViewModel.cshtml"
       Write(Html.HiddenFor(m => m.PhoneNumber));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" id=\"candidate-phone\"");

WriteLiteral(" class=\"form-prepopped\"");

WriteLiteral(">");

            
            #line 52 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\ApprenticeshipCandidateViewModel.cshtml"
                                                         Write(Model.PhoneNumber);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n</section>");

        }
    }
}
#pragma warning restore 1591
