using System.ComponentModel.DataAnnotations;

namespace MovieArchive.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public int ReleaseYear { get; set; }

        [Required]
        [Range(1, 10)]
        public double Rating { get; set; }
    }
}