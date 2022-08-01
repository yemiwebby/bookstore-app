using System.ComponentModel.DataAnnotations;

namespace RazorPagesBookstore.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string Bio { get; set; } = string.Empty;
        public List<Book>? Books { get; set; }
    }
}