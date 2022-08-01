using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesBookstore.Models;

    public class AppContext : DbContext
    {
        public AppContext (DbContextOptions<AppContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesBookstore.Models.Book> Book { get; set; } = default!;

        public DbSet<RazorPagesBookstore.Models.Author>? Author { get; set; }
    }
