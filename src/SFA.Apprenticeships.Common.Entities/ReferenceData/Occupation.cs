﻿
namespace SFA.Apprenticeships.Common.Entities.ReferenceData
{
    public class Occupation : ILegacyReferenceData
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string ShortName { get; set; }
    }
}
