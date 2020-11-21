namespace W.F.P
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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
