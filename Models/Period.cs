using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Portfolio_API.Models
{
    public class Period
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int YearsStart { get; set; }

        public int YearsEnd { get; set; }

        public List<Experience> Experiences { get; set; } = new List<Experience>();
    }
}
