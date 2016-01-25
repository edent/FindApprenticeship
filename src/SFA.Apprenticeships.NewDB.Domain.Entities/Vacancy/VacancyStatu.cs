namespace SFA.Apprenticeships.NewDB.Domain.Entities.Vacancy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vacancy.VacancyStatus")]
    public partial class VacancyStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VacancyStatu()
        {
            Vacancies = new HashSet<Vacancy>();
        }

        [Key]
        [StringLength(3)]
        public string VacancyStatusCode { get; set; }

        [Required]
        public string FullName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vacancy> Vacancies { get; set; }
    }
}
