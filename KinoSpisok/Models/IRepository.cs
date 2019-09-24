using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinoSpisok.Models
{
    public interface IRepository
    {
        IQueryable<Films> Film { get; }

    }
}
