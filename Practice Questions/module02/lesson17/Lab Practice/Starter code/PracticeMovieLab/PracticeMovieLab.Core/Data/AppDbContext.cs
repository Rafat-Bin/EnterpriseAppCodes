using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using PracticeMovieLab.Core.Models;

namespace PracticeMovieLab.Core.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Movie> Movies => Set<Movie>();

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
