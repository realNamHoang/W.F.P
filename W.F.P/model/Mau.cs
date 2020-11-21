namespace W.F.P
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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
