﻿namespace SFA.Apprenticeships.Data.Migrate.Faa.Entities.Mongo
{
    using System;
    using MongoDB.Bson.Serialization.Attributes;

    [BsonIgnoreExtraElements]
    public class Candidate : CandidateSummary
    {
        public DateTime DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }
    }
}