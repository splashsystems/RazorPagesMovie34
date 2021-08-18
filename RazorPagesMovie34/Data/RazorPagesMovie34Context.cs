using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie34.Models;

namespace RazorPagesMovie34.Data
{
    public class RazorPagesMovie34Context : DbContext
    {
        public RazorPagesMovie34Context (DbContextOptions<RazorPagesMovie34Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie34.Models.Movie> Movie { get; set; }
    }
}
