using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio_API.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string ImgLink { get; set; } = null!;

        public string ShortDesc { get; set; } = null!;

        public string LongDesc { get; set; } = null!;

        public virtual ICollection<Langage> Langages { get; set; }

        public virtual ICollection<Mission> Missions { get; set; }

        public string Job { get; set; } = null!;
    }
}
