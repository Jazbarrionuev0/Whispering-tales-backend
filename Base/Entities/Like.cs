using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DB.Entities
{
    [Table("Likes", Schema = "")]
    public class Like
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public int UserID { get; set; }

        [ForeignKey(nameof(UserID))]
        public User User { get; set; } = new User();
        
        [Required]
        public int TaleID { get; set; }

        [ForeignKey(nameof(TaleID))]
        public Tale Tale { get; set; } = new Tale();
  
    }
}
