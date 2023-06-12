using System.ComponentModel.DataAnnotations;

namespace Portfolio_API.Models
{
    public class Stack
    {
        [Key]
        public int Id { get; set; }
        public string Category { get; set; } = null!;
        public List<Langage> Langages { get; set; } = null!;

    }
}
