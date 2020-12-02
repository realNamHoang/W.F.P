namespace W.F.P
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Co")]
    public partial class Co
    {
        [Key]
        [StringLength(10)]
        public string MaCo { get; set; }

        [StringLength(30)]
        public string TenCo { get; set; }
    }
}
