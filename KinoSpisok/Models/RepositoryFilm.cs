using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinoSpisok.Models
{
    public class RepositoryFilm : IRepository
    {
        public IQueryable<Films> Film => context.Film;

        FilmDataContext context;
        public RepositoryFilm(FilmDataContext ctx) => context = ctx;
    }
}
