namespace W.F.P
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("HoaDonNhap")]
    public partial class HoaDonNhap
    {
        [Key]
        [StringLength(10)]
        public string SoHDN { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNV { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayNhap { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNCC { get; set; }

        public long? TongTien { get; set; }
    }
}
