namespace Project_QLPT.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGUOITHUE")]
    public partial class NGUOITHUE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGUOITHUE()
        {
            PHIEUTHUEs = new HashSet<PHIEUTHUE>();
        }

        [Key]
        [StringLength(4)]
        public string IDNGUOITHUE { get; set; }

        [StringLength(50)]
        public string TENNGUOITHUE { get; set; }

        [StringLength(4)]
        public string NAMSINH { get; set; }

        [StringLength(15)]
        public string CMND { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHUE> PHIEUTHUEs { get; set; }
    }
}
