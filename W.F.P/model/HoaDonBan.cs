namespace W.F.P
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("HoaDonBan")]
    public partial class HoaDonBan
    {
        [Key]
        [StringLength(10)]
        public string SoHDB { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNV { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayBan { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKhach { get; set; }

        public long? TongTien { get; set; }
    }
}
