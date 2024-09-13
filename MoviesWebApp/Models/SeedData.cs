using Microsoft.EntityFrameworkCore;
using MoviesWebApp.Data;

namespace MoviesWebApp.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new MoviesWebAppContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MoviesWebAppContext>>());
        if (context == null || context.Movies == null)
        {
            throw new ArgumentNullException("Null RazorPagesMovieContext");
        }

        // Look for any movies.
        if (context.Movies.Any())
        {
            return;   // DB has been seeded
        }

        context.Movies.AddRange(
            new Movie
            {
                Title = "When Harry Met Sally",
                ReleaseDate = DateTime.Parse("1989-2-12"),
                Genre = "Romantic Comedy",
                Price = 7.99M,
                Rating = "R"
            },

            new Movie
            {
                Title = "Ghostbusters ",
                ReleaseDate = DateTime.Parse("1984-3-13"),
                Genre = "Comedy",
                Price = 8.99M,
                Rating = "G"
            },

            new Movie
            {
                Title = "Ghostbusters 2",
                ReleaseDate = DateTime.Parse("1986-2-23"),
                Genre = "Comedy",
                Price = 9.99M,
                Rating = "G"
            },

            new Movie
            {
                Title = "Rio Bravo",
                ReleaseDate = DateTime.Parse("1959-4-15"),
                Genre = "Western",
                Price = 3.99M,
                Rating = "NA"
            },

            new Movie
            {
                Title = "The Magnificent Seven",
                ReleaseDate = DateTime.Parse("1960-4-23"),
                Genre = "Western",
                Price = 3.99M,
                Rating = "NA"
            },

            new Movie
            {
                Title = "The Big Country",
                ReleaseDate = DateTime.Parse("1958-10-1"),
                Genre = "Western",
                Price = 3.99M,
                Rating = "NA"
            },

            new Movie
            {
                Title = "The Long Riders",
                ReleaseDate = DateTime.Parse("1980-5-16"),
                Genre = "Western",
                Price = 3.99M,
                Rating = "NA"
            },

            new Movie
            {
                Title = "Tombstone",
                ReleaseDate = DateTime.Parse("1993-12-25"),
                Genre = "Western",
                Price = 3.99M,
                Rating = "NA"
            },

            new Movie
            {
                Title = "The Good, the Bad and the Ugly",
                ReleaseDate = DateTime.Parse("1966-12-23"),
                Genre = "Western",
                Price = 3.99M,
                Rating = "NA"
            }
        );
        context.SaveChanges();
    }
}
