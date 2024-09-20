using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Entities
{
    [Table("NotificationTypes", Schema = "")]
    public class NotificationType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public NotificationTypes Type { get; set; }
    }

    public enum NotificationTypes
    {
        FOLLOW,
        LIKE,
        COMMENT,
        INFORMATION
    }
}
