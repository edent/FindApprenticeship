﻿namespace SFA.Apprenticeships.Web.Common.Services
{
    using System;
    using System.Linq;
    using System.Web;
    using System.Web.Security;
    using NLog;

    public class AuthenticationTicketService : IAuthenticationTicketService
    {
        private static readonly string CookieName = FormsAuthentication.FormsCookieName;

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public FormsAuthenticationTicket GetTicket(HttpCookieCollection cookies)
        {
            if (!cookies.AllKeys.Contains(CookieName))
            {
                return null;
            }

            var cookie = cookies[CookieName];

            if (cookie == null || string.IsNullOrWhiteSpace(cookie.Value) || cookie.Expires < DateTime.Now)
            {
                return null;
            }

            return FormsAuthentication.Decrypt(cookie.Value);
        }

        public void RefreshTicket(HttpCookieCollection cookies)
        {
            var ticket = GetTicket(cookies);

            if (ticket == null)
            {
                return;
            }

            var timeToExpiry = (ticket.Expiration - DateTime.Now).TotalSeconds;

            // Is the expiration within the update window?
            var expiring = timeToExpiry < (FormsAuthentication.Timeout.TotalSeconds / 2);

            if (!expiring)
            {
                return;
            }

            var newTicket = CreateTicket(ticket.Name, ArrayifyClaims(ticket));

            AddTicket(cookies, newTicket);

            Logger.Debug("Ticket issued for {0} because it only had {1}s to expire and the update window is {2}s",
                ticket.Name, timeToExpiry, (FormsAuthentication.Timeout.TotalSeconds / 2));
        }

        public string[] GetClaims(FormsAuthenticationTicket ticket)
        {
            return ArrayifyClaims(ticket);
        }

        public void Clear(HttpCookieCollection cookies)
        {
            if (!cookies.AllKeys.Contains(CookieName))
            {
                return;
            }

            cookies.Remove(CookieName);
        }

        public void SetAuthenticationCookie(HttpCookieCollection cookies, string userName, params string[] claims)
        {
            var ticket = CreateTicket(userName, claims);

            AddTicket(cookies, ticket);
        }

        #region Helpers
        private static void AddTicket(HttpCookieCollection cookies, FormsAuthenticationTicket ticket)
        {
            cookies.Add(new HttpCookie(CookieName, FormsAuthentication.Encrypt(ticket))
            {
                HttpOnly = true,
                Expires = ticket.Expiration
            });
        }

        private static FormsAuthenticationTicket CreateTicket(string userName, params string[] claims)
        {
            var ticket = new FormsAuthenticationTicket(
                version: 1,
                name: userName,
                issueDate: DateTime.Now,
                expiration: DateTime.Now.AddSeconds(FormsAuthentication.Timeout.TotalSeconds),
                isPersistent: false,
                userData: StringifyClaims(claims));

            Logger.Debug("Ticket created for {0} with {1} at {2} expires {3}",
                ticket.Name, ticket.UserData, ticket.IssueDate, ticket.Expiration);

            return ticket;
        }

        private static string StringifyClaims(string[] claims)
        {
            return string.Join(",", claims);
        }

        private static string[] ArrayifyClaims(FormsAuthenticationTicket ticket)
        {
            if (ticket.UserData == null)
            {
                return new string[] { };
            }

            return ticket.UserData.Split(new[] { ',' });
        }
        #endregion
    }
}
