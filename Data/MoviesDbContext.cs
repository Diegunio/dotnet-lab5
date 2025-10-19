using Microsoft.EntityFrameworkCore;
using lab5.Models;

namespace lab5.Data;

public class MoviesDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; } = null!;

    public MoviesDbContext(DbContextOptions options) : base(options)
    {
    }
}
