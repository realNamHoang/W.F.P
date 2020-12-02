namespace W.F.P
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TheLoai")]
    public partial class TheLoai
    {
        [Key]
        [StringLength(10)]
        public string Maloai { get; set; }

        [StringLength(40)]
        public string TenLoai { get; set; }
    }
}
