using System.ComponentModel.DataAnnotations;

namespace Portfolio_API.Models
{
    public class Langage
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string ImgLink { get; set; } = null!;
        public bool Background { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
