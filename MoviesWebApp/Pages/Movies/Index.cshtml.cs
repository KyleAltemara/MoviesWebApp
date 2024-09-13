using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesWebApp.Data;
using MoviesWebApp.Models;

namespace MoviesWebApp.Pages.Movies;

public class IndexModel(MoviesWebAppContext context) : PageModel
{
    private readonly MoviesWebAppContext _context = context;

    public IList<Movie> Movies { get;set; } = default!;

    public async Task OnGetAsync()
    {
        Movies = await _context.Movies.ToListAsync();
    }
}
