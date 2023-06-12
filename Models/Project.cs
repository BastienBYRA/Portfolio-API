using System.ComponentModel.DataAnnotations;

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

        public List<Langage> Langages { get; set; } = new List<Langage>();

        public List<Mission> Missions { get; set; } = new List<Mission>();

        public string Job { get; set; } = null!;
    }
}
