namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            Friends = new HashSet<Friends>();
        }

        [Key]
        public Guid UserId { get; set; }

        [StringLength(50)]
        public string login { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public int? role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Friends> Friends { get; set; }

        public virtual Profiles Profiles { get; set; }
    }
}
