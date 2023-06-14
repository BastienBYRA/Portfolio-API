using System.ComponentModel.DataAnnotations;

namespace Portfolio_API.Models
{
    public class Mission
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public virtual ICollection<Project> Projects { get; set; }

        public virtual ICollection<Experience> Experience { get; set; }
    }
}
