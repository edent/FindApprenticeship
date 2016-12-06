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

namespace SFA.Apprenticeships.Web.Candidate.Views.TraineeshipSearch
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/TraineeshipSearch/_pagination.cshtml")]
    public partial class pagination : System.Web.Mvc.WebViewPage<TraineeshipSearchResponseViewModel>
    {
        public pagination()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\TraineeshipSearch\_pagination.cshtml"
  
    var pages = Model.Pages;
    var prevLink = Model.VacancySearch.PageNumber > 1 ? Url.RouteUrl(CandidateRouteNames.TraineeshipResults, new TraineeshipSearchViewModel(Model.VacancySearch) { PageNumber = Model.PrevPage, SearchAction = SearchAction.Sort }) : "#";
    var nextLink = Model.VacancySearch.PageNumber < pages ? Url.RouteUrl(CandidateRouteNames.TraineeshipResults, new TraineeshipSearchViewModel(Model.VacancySearch) { PageNumber = Model.NextPage, SearchAction = SearchAction.Sort }) : "#";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 9 "..\..\Views\TraineeshipSearch\_pagination.cshtml"
 if (Model.TotalHits > 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"page-navigation\"");

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 635), Tuple.Create("\"", 651)
            
            #line 12 "..\..\Views\TraineeshipSearch\_pagination.cshtml"
, Tuple.Create(Tuple.Create("", 642), Tuple.Create<System.Object, System.Int32>(prevLink
            
            #line default
            #line hidden
, 642), false)
);

WriteAttribute("style", Tuple.Create("\r\n           style=\"", 652), Tuple.Create("\"", 745)
, Tuple.Create(Tuple.Create("", 672), Tuple.Create("visibility:", 672), true)
            
            #line 13 "..\..\Views\TraineeshipSearch\_pagination.cshtml"
, Tuple.Create(Tuple.Create(" ", 683), Tuple.Create<System.Object, System.Int32>(Model.VacancySearch.PageNumber == 1 ? "hidden" : "visible"
            
            #line default
            #line hidden
, 684), false)
);

WriteLiteral("\r\n           class=\"page-navigation__btn previous\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"arrow-button fa fa-angle-left\"");

WriteLiteral("></i>\r\n            <span");

WriteLiteral(" class=\"description\"");

WriteLiteral(">Previous <span");

WriteLiteral(" class=\"sfa-hide-mobile\"");

WriteLiteral(">page</span></span>\r\n            <span");

WriteLiteral(" class=\"counter\"");

WriteLiteral(">");

            
            #line 17 "..\..\Views\TraineeshipSearch\_pagination.cshtml"
                             Write(Model.PrevPage);

            
            #line default
            #line hidden
WriteLiteral(" of ");

            
            #line 17 "..\..\Views\TraineeshipSearch\_pagination.cshtml"
                                                Write(pages);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </a>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1047), Tuple.Create("\"", 1063)
            
            #line 19 "..\..\Views\TraineeshipSearch\_pagination.cshtml"
, Tuple.Create(Tuple.Create("", 1054), Tuple.Create<System.Object, System.Int32>(nextLink
            
            #line default
            #line hidden
, 1054), false)
);

WriteAttribute("style", Tuple.Create("\r\n           style=\"", 1064), Tuple.Create("\"", 1161)
, Tuple.Create(Tuple.Create("", 1084), Tuple.Create("visibility:", 1084), true)
            
            #line 20 "..\..\Views\TraineeshipSearch\_pagination.cshtml"
, Tuple.Create(Tuple.Create(" ", 1095), Tuple.Create<System.Object, System.Int32>(Model.VacancySearch.PageNumber == pages ? "hidden" : "visible"
            
            #line default
            #line hidden
, 1096), false)
);

WriteLiteral("\r\n           class=\"page-navigation__btn next\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"arrow-button fa fa-angle-right\"");

WriteLiteral("></i>\r\n            <span");

WriteLiteral(" class=\"description\"");

WriteLiteral(">Next <span");

WriteLiteral(" class=\"sfa-hide-mobile\"");

WriteLiteral(">page</span></span>\r\n            <span");

WriteLiteral(" class=\"counter\"");

WriteLiteral(">");

            
            #line 24 "..\..\Views\TraineeshipSearch\_pagination.cshtml"
                             Write(Model.NextPage);

            
            #line default
            #line hidden
WriteLiteral(" of ");

            
            #line 24 "..\..\Views\TraineeshipSearch\_pagination.cshtml"
                                                Write(pages);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </a>\r\n    </div>\r\n");

            
            #line 27 "..\..\Views\TraineeshipSearch\_pagination.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
