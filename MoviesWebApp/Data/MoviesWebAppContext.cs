using Microsoft.EntityFrameworkCore;
using MoviesWebApp.Models;

namespace MoviesWebApp.Data;

public class MoviesWebAppContext(DbContextOptions<MoviesWebAppContext> options) : DbContext(options)
{
    public DbSet<Movie> Movies { get; set; } = default!;
}
