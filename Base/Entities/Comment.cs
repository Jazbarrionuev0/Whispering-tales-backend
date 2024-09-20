using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Entities
{
    [Table("Tales", Schema = "")]
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Content { get; set; } = string.Empty;
        [Required]
        public int UserID { get; set; }

        [ForeignKey(nameof(UserID))]
        public User User { get; set; } = new User();
        [Required]
        public int TaleID { get; set; }

        [ForeignKey(nameof(TaleID))]
        public Tale Tale { get; set; } = new Tale();

        public int? ParentCommentID { get; set; }

        [ForeignKey(nameof(ParentCommentID))]
        public Comment? ParentComment { get; set; }
    }
}
