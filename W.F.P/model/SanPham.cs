namespace W.F.P
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        [StringLength(10)]
        public string MaGiayDep { get; set; }

        [Required]
        [StringLength(50)]
        public string TenGiayDep { get; set; }

        [Required]
        [StringLength(10)]
        public string MaLoai { get; set; }

        [Required]
        [StringLength(10)]
        public string MaCo { get; set; }

        [Required]
        [StringLength(10)]
        public string MaChatLieu { get; set; }

        [Required]
        [StringLength(10)]
        public string MaMau { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNuocSX { get; set; }

        [Required]
        [StringLength(10)]
        public string SoLuong { get; set; }

        [Required]
        [StringLength(50)]
        public string Anh { get; set; }

        public long DonGiaNhap { get; set; }

        public long DonGiaBan { get; set; }
    }
}
