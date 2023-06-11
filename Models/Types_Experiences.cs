using System.ComponentModel.DataAnnotations;

namespace Portfolio_API.Models
{
    public class Types_Experiences
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Libelle { get; set; }
    }
}
