namespace W.F.P
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoiTuong")]
    public partial class DoiTuong
    {
        [Key]
        [StringLength(10)]
        public string MaDoiTuong { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDoiTuong { get; set; }
    }
}
