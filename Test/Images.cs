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

    public partial class Images
    {
        [Key]

        public System.Guid ImageId { get; set; }
        public Nullable<System.Guid> PhotobookId { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
        public string fileName { get; set; }
        public Nullable<System.DateTime> DateOfLoad { get; set; }
    
        public virtual Photobooks Photobooks { get; set; }
    }
}
