﻿namespace SFA.Apprenticeships.Web.Candidate.Controllers
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Threading;
    using System.Web.Mvc;
    using Attributes;
    using Common.Attributes;
    using Common.Configuration;
    using Common.Constants;
    using Common.Controllers;
    using SFA.Infrastructure.Interfaces;
    using Infrastructure.Logging;
    using NLog.Contrib;
    using Providers;

    [ApplyWebTrends,
    DefaultSessionTimeout,
    CookiesEnabled,
    OutputCache(CacheProfile = CacheProfiles.None),
    AllowReturnUrl(Allow = true),
    ClearSearchReturnUrl,
    PlannedOutageMessage,
    UserJourneyContext(UserJourney.None, Order = 1),
    RobotsIndexPage]
    public abstract class CandidateControllerBase : ControllerBase<CandidateUserContext>
    {
        public readonly IConfigurationService ConfigurationService;
        public readonly ILogService _logService;

        protected CandidateControllerBase(IConfigurationService configurationService, ILogService loggingService)
        {
            ConfigurationService = configurationService;
            _logService = loggingService;
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            SetLoggingIds();
            SetRequestInfo();

            _logService.Info("OnActionExecuting {0} {1} {2}", filterContext.HttpContext.Request.Url, User.Identity.Name, Thread.CurrentThread.ManagedThreadId);
            UserContext = null;

            if (!string.IsNullOrWhiteSpace(User.Identity.Name))
            {
                var context = UserData.GetUserContext();

                if (context != null)
                {
                    var candidateContext = new CandidateUserContext
                    {
                        CandidateId = new Guid(User.Identity.Name),
                        FullName = context.FullName,
                        UserName = context.UserName,
                        AcceptedTermsAndConditionsVersion = context.AcceptedTermsAndConditionsVersion
                    };

                    UserContext = candidateContext;
                }
            }

            SetAbout();
            SetCandidate();

            base.OnActionExecuting(filterContext);
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            _logService.Info("OnActionExecuted {0} {1} {2}", filterContext.HttpContext.Request.Url, User.Identity.Name, Thread.CurrentThread.ManagedThreadId);

            base.OnActionExecuted(filterContext);
        }

        private void SetAbout()
        {
            var webConfiguration = ConfigurationService.Get<CommonWebConfiguration>();
            ViewBag.ShowAbout = webConfiguration.ShowAbout;

            if (!webConfiguration.ShowAbout) return;

            ViewBag.Version = VersionLogging.GetVersion();
            ViewBag.Environment = webConfiguration.Environment;
        }

        private void SetLoggingIds()
        {
            var sessionId = UserData.Get(UserDataItemNames.LoggingSessionId);
            if (sessionId == null)
            {
                sessionId = Guid.NewGuid().ToString("N");
                UserData.Push(UserDataItemNames.LoggingSessionId, sessionId);
            }

            MappedDiagnosticsLogicalContext.Set("sessionId", sessionId);
            MappedDiagnosticsLogicalContext.Set("userId", UserContext != null ? UserContext.CandidateId.ToString() : "<none>");
        }

        private void SetRequestInfo()
        {
            MappedDiagnosticsLogicalContext.Set("UserAgent", Request.UserAgent);
            MappedDiagnosticsLogicalContext.Set("UrlReferrer", Request.UrlReferrer == null ? "<unknown>" : Request.UrlReferrer.ToString());
            MappedDiagnosticsLogicalContext.Set("UserLanguages", Request.UserLanguages == null ? "<unknown>" : string.Join(",", Request.UserLanguages));
            MappedDiagnosticsLogicalContext.Set("CurrentCulture", CultureInfo.CurrentCulture.ToString());
            MappedDiagnosticsLogicalContext.Set("CurrentUICulture", CultureInfo.CurrentUICulture.ToString());
            var headers = Request.Headers.AllKeys.Select(key => string.Format("{0}={1}", key, Request.Headers[key]));
            MappedDiagnosticsLogicalContext.Set("Headers", string.Join(",", headers));
        }

        private void SetCandidate()
        {
            var user = HttpContext.User;

            if (user != null)
            {
                ViewBag.IsCandidateActivated = user.Identity.IsAuthenticated && user.IsInRole(UserRoleNames.Activated);
            }
        }

        protected Guid? GetCandidateId()
        {
            Guid? candidateId = null;

            if (Request.IsAuthenticated && UserContext != null)
            {
                candidateId = UserContext.CandidateId;
            }

            return candidateId;
        }
    }
}
