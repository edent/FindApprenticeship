﻿namespace SFA.Apprenticeships.Infrastructure.Repositories.Sql.Schemas.Provider.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    // TODO: SQL: AG: remove unused fields.

    [Table("dbo.Provider")]
    public class Provider
    {
        [Key]
        public int ProviderId { get; set; }

        // [Required]
        // public int Upin { get; set; }

        [Required]
        public int Ukprn { get; set; }

        public string FullName { get; set; }

        // public string TradingName { get; set; }

        // [Required]
        // public bool IsContracted { get; set; }

        // [Column(TypeName = "datetime2")]
        // public DateTime ContractedFrom { get; set; }

        // [Column(TypeName = "datetime2")]
        // public DateTime ContractedTo { get; set; }

        // [Required]
        // public int ProviderStatusTypeId { get; set; }

        // [Required]
        // [Column(TypeName = "datetime2")]
        // public bool IsNasProvider { get; set; }

        // [Column(TypeName = "datetime2")]
        // public int OriginalUpin { get; set; }

        // TODO: SQL: AG: remove dead code below.

        /*
        public int ProviderId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateUpdated { get; set; }

        [Required]
        public int Ukprn { get; set; }

        [Required]
        public string FullName { get; set; }
        */
    }
}
