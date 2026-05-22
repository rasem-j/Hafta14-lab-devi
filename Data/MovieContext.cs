using Microsoft.EntityFrameworkCore;
using MovieArchive.Models;

namespace MovieArchive.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options) { }

        public DbSet<Movie> Movies { get; set; }
    }
}