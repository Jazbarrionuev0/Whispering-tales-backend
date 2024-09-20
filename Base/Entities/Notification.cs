using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Entities
{
    [Table("Nofications", Schema = "")]
    public class Nofication
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Message { get; set; } = string.Empty;
        [Required]
        public int UserID { get; set; }

        [ForeignKey(nameof(UserID))]
        public User User { get; set; } = new User();
        [Required]
        public int NotificationTypeID { get; set; }

        [ForeignKey(nameof(NotificationTypeID))]
        public NotificationType NotificationType { get; set; } = new NotificationType();
    }
}
