using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinoSpisok.Models
{
    public class FilmDataContext : DbContext
    {
        public FilmDataContext(DbContextOptions<FilmDataContext> opts) : base(opts) { }

        public DbSet<Films> Film { get; set; } 
    }
}
