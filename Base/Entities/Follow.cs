using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DB.Entities
{
    [Table("Follows", Schema = "")]
    public class Follow
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public int FollowID { get; set; }
        [ForeignKey(nameof(FollowID))]
        public User UserFollow { get; set; } = new User();

        [Required]
        public int FollowerID { get; set; }
        [ForeignKey(nameof(FollowerID))]
        public User UserFollower { get; set; } = new User();

    }
}
