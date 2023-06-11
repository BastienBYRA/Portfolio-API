using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio_API.Models
{
    public class Experiences
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Content { get; set; } = null!;

        public string Img_Location { get; set; } = null!;

        public Types_Experiences Type_Experience { get; set; } = null!;

        public List<Missions> Missions { get; set; } = null!;
    }
}
