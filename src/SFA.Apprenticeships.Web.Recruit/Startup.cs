﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SFA.Apprenticeships.Web.Recruit.Startup))]
namespace SFA.Apprenticeships.Web.Recruit
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            AuthenticationConfig.RegisterProvider(app);
        }
    }
}
