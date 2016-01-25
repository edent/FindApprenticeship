namespace SFA.Apprenticeships.Infrastructure.Repositories.Sql.Schemas.Vacancy.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Vacancy.WageInterval")]
    public class WageInterval
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WageInterval()
        {
            Vacancies = new HashSet<Vacancy>();
        }

        [Key]
        [StringLength(3)]
        public string WageIntervalCode { get; set; }

        [Required]
        public string FullName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vacancy> Vacancies { get; set; }
    }
}
