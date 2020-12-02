namespace W.F.P
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Mua")]
    public partial class Mua
    {
        [Key]
        [StringLength(10)]
        public string MaMua { get; set; }

        [Required]
        [StringLength(50)]
        public string TenMua { get; set; }
    }
}
