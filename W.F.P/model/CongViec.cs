namespace W.F.P
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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
