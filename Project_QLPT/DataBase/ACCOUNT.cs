namespace Project_QLPT.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNT")]
    public partial class ACCOUNT
    {
        [Key]
        [StringLength(20)]
        public string USR { get; set; }

        [StringLength(20)]
        public string PWD { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }
    }
}
