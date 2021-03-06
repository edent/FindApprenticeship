﻿namespace SFA.Apprenticeships.Web.Recruit.Attributes
{
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.Mvc.Filters;
    using System.Web.Routing;
    using Constants;

    public class AuthorizeUserAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);

            if (filterContext.Result is HttpUnauthorizedResult)
            {
                var user = filterContext.RequestContext.HttpContext.User;

                if (user.Identity.IsAuthenticated)
                {
                    var requireVerifiedEmail = Roles.Contains(Domain.Entities.Raa.Roles.VerifiedEmail);
                    if (requireVerifiedEmail && !user.IsInRole(Domain.Entities.Raa.Roles.VerifiedEmail))
                    {
                        filterContext.Result = new RedirectToRouteResult(RecruitmentRouteNames.VerifyEmail, null);
                    }
                }
                else
                {
                    var routeValues = new RouteValueDictionary {{"ReturnUrl", GetReturnUrl(filterContext)}};

                    //Session timeout detection
                    if (filterContext.HttpContext.Request.Cookies.AllKeys.Contains(AuthenticationConfig.CookieName))
                    {
                        filterContext.Result = new RedirectToRouteResult(RecruitmentRouteNames.SessionTimeout, routeValues);
                    }
                    else
                    {
                        filterContext.Result = new RedirectToRouteResult(RecruitmentRouteNames.SignIn, routeValues);
                    }
                }
            }
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {

        }

        private static string GetReturnUrl(AuthorizationContext filterContext)
        {
            if (filterContext.RequestContext.HttpContext.Request.HttpMethod == "GET")
            {
                var url = filterContext.RequestContext.HttpContext.Request.Url;

                if (url != null)
                {
                   return url.PathAndQuery;
                }
            }

            return string.Empty;
        }
    }
}