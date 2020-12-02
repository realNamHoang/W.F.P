namespace W.F.P
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

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
