using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio_API.Models
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Content { get; set; } = null!;

        public string Img_Location { get; set; } = null!;

        public Type_Experience Type_Experience { get; set; } = null!;

        public List<Mission> Missions { get; set; } = null!;
    }
}
