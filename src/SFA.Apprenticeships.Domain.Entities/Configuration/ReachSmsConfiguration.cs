﻿namespace SFA.Apprenticeships.Domain.Entities.Configuration
{
    using System.Collections.Generic;

    public class ReachSmsConfiguration
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Originator { get; set; }

        public string Url { get; set; }

        public string CallbackUrl { get; set; }

        public IEnumerable<SmsTemplate> Templates { get; set; } 
    }

    public class SmsTemplate
    {
        public string Name { get; set; }

        public string Message { get; set; }
    }
}
