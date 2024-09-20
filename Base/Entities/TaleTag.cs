using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Entities
{
    [Table("TaleTags", Schema = "")]
    public class TaleTag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public int TaleID { get; set; }
        [ForeignKey(nameof(TaleID))]
        public Tale Tale { get; set; } = new Tale();

        [Required]
        public int TagID { get; set; }
        [ForeignKey(nameof(TagID))]
        public Tag Tag { get; set; } = new Tag();
    }
}
