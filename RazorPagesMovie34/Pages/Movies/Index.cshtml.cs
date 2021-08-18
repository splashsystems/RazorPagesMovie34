using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie34.Data;
using RazorPagesMovie34.Models;

namespace RazorPagesMovie34.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie34.Data.RazorPagesMovie34Context _context;

        public IndexModel(RazorPagesMovie34.Data.RazorPagesMovie34Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
