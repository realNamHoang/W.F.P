namespace W.F.P
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHDB")]
    public partial class ChiTietHDB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string SoHDB { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaGiayDep { get; set; }

        public int SoLuong { get; set; }

        public long GiamGia { get; set; }

        public long ThanhTien { get; set; }
    }
}
