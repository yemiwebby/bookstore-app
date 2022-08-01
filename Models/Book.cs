using System.ComponentModel.DataAnnotations;

namespace RazorPagesBookstore.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;

        public Author? Author { get; set; }
        public string Synopsis { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public int AverageRating { get; set; }
        public int CopiesSold { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}