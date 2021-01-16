namespace Project_QLPT.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONG")]
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            PHIEUTHUEs = new HashSet<PHIEUTHUE>();
        }

        [Key]
        [StringLength(4)]
        public string IDPHONG { get; set; }

        [StringLength(100)]
        public string TENPHONG { get; set; }

        [StringLength(20)]
        public string TRANGTHAI { get; set; }

        public int? GIAPHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHUE> PHIEUTHUEs { get; set; }
    }
}
