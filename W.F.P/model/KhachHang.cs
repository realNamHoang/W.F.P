namespace W.F.P
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [Key]
        [StringLength(10)]
        public string MaKhach { get; set; }

        [Required]
        [StringLength(50)]
        public string TenKhach { get; set; }

        [Required]
        [StringLength(50)]
        public string DiaChi { get; set; }

        [Required]
        public long? DienThoai { get; set; }
    }
}
