using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public virtual ICollection<Experience> Experiences { get; set; }
    }
}
