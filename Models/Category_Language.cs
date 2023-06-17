using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio_API.Models
{
    public class Category_Language
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<Langage> Langages { get; set; }

    }
}
