namespace W.F.P
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CongViec")]
    public partial class CongViec
    {
        [Key]
        [StringLength(10)]
        public string MaCongViec { get; set; }

        [Required]
        [StringLength(40)]
        public string TenCongViec { get; set; }
    }
}
