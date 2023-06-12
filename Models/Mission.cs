using System.ComponentModel.DataAnnotations;

namespace Portfolio_API.Models
{
    public class Mission
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
    }
}
