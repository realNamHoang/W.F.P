namespace W.F.P
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("NuocSanXuat")]
    public partial class NuocSanXuat
    {
        [Key]
        [StringLength(10)]
        public string MaNuocSX { get; set; }

        [StringLength(50)]
        public string TenNuocSX { get; set; }
    }
}
