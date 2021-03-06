namespace W.F.P
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ChatLieu")]
    public partial class ChatLieu
    {
        [Key]
        [StringLength(10)]
        public string MaChatLieu { get; set; }

        [Required]
        [StringLength(40)]
        public string TenChatLieu { get; set; }
    }
}
