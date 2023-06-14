using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio_API.Models
{
    public class Stack
    {
        [Key]
        public int Id { get; set; }
        public string Category { get; set; } = null!;

        public virtual ICollection<Langage> Langages { get; set; }

    }
}
