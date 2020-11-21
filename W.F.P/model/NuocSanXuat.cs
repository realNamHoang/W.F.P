namespace W.F.P
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NuocSanXuat")]
    public partial class NuocSanXuat
    {
        [Key]
        [StringLength(10)]
        public string MaNuocSX { get; set; }

        [StringLength(50)]
        public string TenNuocSX { get; set; }
    }
}
