namespace W.F.P
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Mau")]
    public partial class Mau
    {
        [Key]
        [StringLength(10)]
        public string MaMau { get; set; }

        [Required]
        [StringLength(50)]
        public string TenMau { get; set; }
    }
}
