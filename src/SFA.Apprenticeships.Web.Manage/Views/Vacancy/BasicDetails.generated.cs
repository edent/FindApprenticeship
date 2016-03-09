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

namespace SFA.Apprenticeships.Web.Manage.Views.Vacancy
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
    
    #line 2 "..\..\Views\Vacancy\BasicDetails.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using SFA.Apprenticeships.Infrastructure.Presentation;
    using SFA.Apprenticeships.Web.Common.Constants;
    using SFA.Apprenticeships.Web.Common.Framework;
    using SFA.Apprenticeships.Web.Common.Models.Common;
    using SFA.Apprenticeships.Web.Manage;
    
    #line 3 "..\..\Views\Vacancy\BasicDetails.cshtml"
    using SFA.Apprenticeships.Web.Manage.Constants;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Vacancy\BasicDetails.cshtml"
    using SFA.Apprenticeships.Web.Raa.Common.ViewModels.Vacancy;
    
    #line default
    #line hidden
    using SFA.Apprenticeships.Web.Raa.Common.Views.Shared.DisplayTemplates;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Vacancy/BasicDetails.cshtml")]
    public partial class BasicDetails : System.Web.Mvc.WebViewPage<NewVacancyViewModel>
    {
        public BasicDetails()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 6 "..\..\Views\Vacancy\BasicDetails.cshtml"
 using (Html.BeginRouteForm(ManagementRouteNames.BasicDetails, FormMethod.Post))
{
    
            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\Vacancy\BasicDetails.cshtml"
Write(Html.DisplayFor(m => m, NewVacancyViewModel.PartialView));

            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\Vacancy\BasicDetails.cshtml"
                                                             


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Save</button>\r\n");

WriteLiteral("        ");

            
            #line 12 "..\..\Views\Vacancy\BasicDetails.cshtml"
   Write(Html.RouteLink("Cancel", ManagementRouteNames.ReviewVacancy, new { vacancyReferenceNumber = Model.VacancyReferenceNumber }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 14 "..\..\Views\Vacancy\BasicDetails.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("scripts", () => {

WriteLiteral(@"
    <script>
        $(""input[name='OfflineVacancy']"").change(function () {
            var selectedValue = $(""input[name='OfflineVacancy']:checked"").val();
            if (selectedValue === ""False"") {
                $(""#apprenticeship-offline-application-url"").val("""");
                $(""#apprenticheship-offline-application-instructions"").val("""");
            }
        });
    </script>
");

});

        }
    }
}
#pragma warning restore 1591
