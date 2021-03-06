//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Profiles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profiles()
        {
            this.Messages = new HashSet<Messages>();
            this.Messages1 = new HashSet<Messages>();
            this.Talks = new HashSet<Talks>();
            this.Talks1 = new HashSet<Talks>();
        }

        [Key]

        public System.Guid ProfileId { get; set; }
        public string fName { get; set; }
        public Nullable<System.DateTime> dob { get; set; }
        public string Gender { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
        public string lName { get; set; }
        public string mName { get; set; }
        public Nullable<System.Guid> AvatarImageId { get; set; }
        public string country { get; set; }
        public string language { get; set; }
        public string Annotation { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Messages> Messages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Messages> Messages1 { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Talks> Talks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Talks> Talks1 { get; set; }
    }
}
