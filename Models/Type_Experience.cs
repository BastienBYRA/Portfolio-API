using System.ComponentModel.DataAnnotations;

namespace Portfolio_API.Models
{
    public class Type_Experience
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Libelle { get; set; }

        public virtual ICollection<Experience> Experiences { get; set; }
    }
}
