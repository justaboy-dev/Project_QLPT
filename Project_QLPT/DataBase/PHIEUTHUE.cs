namespace Project_QLPT.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUTHUE")]
    public partial class PHIEUTHUE
    {
        [Key]
        [StringLength(4)]
        public string IDPHIEU { get; set; }

        [StringLength(4)]
        public string IDPHONG { get; set; }

        [StringLength(4)]
        public string IDNGUOITHUE { get; set; }

        public DateTime? NGAYTHUE { get; set; }

        public DateTime? NGAYTRA { get; set; }

        [StringLength(200)]
        public string GHICHU { get; set; }

        public virtual NGUOITHUE NGUOITHUE { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
