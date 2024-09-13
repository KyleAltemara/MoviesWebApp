using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesWebApp.Data;
using MoviesWebApp.Models;

namespace MoviesWebApp.Pages.Movies;

public class IndexModel(MoviesWebAppContext context) : PageModel
{
    private readonly MoviesWebAppContext _context = context;

    public IList<Movie> Movies { get; set; } = default!;

    public IList<string> Genres { get; set; } = default!;

    public IList<string> Ratings { get; set; } = default!;

    [BindProperty(SupportsGet = true)]
    public string? SearchString { get; set; }

    [BindProperty(SupportsGet = true)]
    public string? SortOrder { get; set; }

    [BindProperty(SupportsGet = true)]
    public string? GenreFilter { get; set; }

    [BindProperty(SupportsGet = true)]
    public string? RatingFilter { get; set; }

    public async Task OnGetAsync()
    {
        var movies = from m in _context.Movies
                     select m;

        if (!string.IsNullOrEmpty(SearchString))
        {
            movies = movies.Where(s => s.Title.Contains(SearchString));
        }

        if (!string.IsNullOrEmpty(GenreFilter))
        {
            movies = movies.Where(x => x.Genre == GenreFilter);
        }

        if (!string.IsNullOrEmpty(RatingFilter))
        {
            movies = movies.Where(x => x.Rating.Contains(RatingFilter));
        }

        movies = SortOrder switch
        {
            "title_desc" => movies.OrderByDescending(s => s.Title),
            "date" => movies.OrderBy(s => s.ReleaseDate),
            "date_desc" => movies.OrderByDescending(s => s.ReleaseDate),
            "price" => movies.OrderBy(s => s.Price),
            "price_desc" => movies.OrderByDescending(s => s.Price),
            "genre" => movies.OrderBy(s => s.Genre),
            "genre_desc" => movies.OrderByDescending(s => s.Genre),
            "rating" => movies.OrderBy(s => s.Rating),
            "rating_desc" => movies.OrderByDescending(s => s.Rating),
            _ => movies.OrderBy(s => s.Title),
        };

        Movies = await movies.ToListAsync();
        Genres = await _context.Movies.Select(m => m.Genre).Distinct().ToListAsync();
        Ratings = await _context.Movies.Select(m => m.Rating).Distinct().ToListAsync();
    }
}
