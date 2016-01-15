namespace SFA.Apprenticeships.Avms.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApplicationUnsuccessfulReasonType")]
    public partial class ApplicationUnsuccessfulReasonType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ApplicationUnsuccessfulReasonType()
        {
            Applications = new HashSet<Application>();
        }

        public int ApplicationUnsuccessfulReasonTypeId { get; set; }

        [Required]
        [StringLength(3)]
        public string CodeName { get; set; }

        [Required]
        [StringLength(10)]
        public string ShortName { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        public int ReferralPoints { get; set; }

        [Required]
        [StringLength(900)]
        public string CandidateDisplayText { get; set; }

        [StringLength(100)]
        public string CandidateFullName { get; set; }

        public bool? Withdrawn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Application> Applications { get; set; }
    }
}