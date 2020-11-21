namespace W.F.P
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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
