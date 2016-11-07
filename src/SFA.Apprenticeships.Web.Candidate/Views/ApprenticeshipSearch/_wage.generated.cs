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

namespace SFA.Apprenticeships.Web.Candidate.Views.ApprenticeshipSearch
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
    
    #line 1 "..\..\Views\ApprenticeshipSearch\_wage.cshtml"
    using SFA.Apprenticeships.Domain.Entities.Vacancies;
    
    #line default
    #line hidden
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ApprenticeshipSearch/_wage.cshtml")]
    public partial class wage : System.Web.Mvc.WebViewPage<ApprenticeshipVacancyDetailViewModel>
    {
        public wage()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div>\r\n    <h3");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">");

            
            #line 6 "..\..\Views\ApprenticeshipSearch\_wage.cshtml"
                      Write(Model.Wage.Unit.GetHeaderDisplayText());

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n    <p");

WriteLiteral(" id=\"vacancy-wage\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 8 "..\..\Views\ApprenticeshipSearch\_wage.cshtml"
   Write(WagePresenter.GetDisplayAmount(Model.Wage.Type, Model.Wage.Amount, Model.Wage.AmountLowerBound, Model.Wage.AmountUpperBound, Model.Wage.Text, Model.Wage.HoursPerWeek, Model.StartDate));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n</div>\r\n\r\n");

            
            #line 12 "..\..\Views\ApprenticeshipSearch\_wage.cshtml"
 if (Model.Wage.Type == WageType.ApprenticeshipMinimum)
{
    
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\ApprenticeshipSearch\_wage.cshtml"
Write(Html.Partial("_ApprenticeMinimumWageExplained", Model.StartDate));

            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\ApprenticeshipSearch\_wage.cshtml"
                                                                     
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 17 "..\..\Views\ApprenticeshipSearch\_wage.cshtml"
 if (Model.Wage.Type == WageType.NationalMinimum)
{
    
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\ApprenticeshipSearch\_wage.cshtml"
Write(Html.Partial("_NationalMinimumWageExplained", Model.StartDate));

            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\ApprenticeshipSearch\_wage.cshtml"
                                                                   
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
