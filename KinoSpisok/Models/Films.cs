using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinoSpisok.Models
{
    public class Films
    {
        /// <summary>
        /// Номер фильма
        /// </summary>
        public long Id { get; set; }
        
        /// <summary>
        /// Название фильма
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Жанр фильма
        /// </summary>
        public string FilmGenre { get; set; }
        /// <summary>
        /// Рейтинг фильма
        /// </summary>
        public float Rating { get; set; }
        /// <summary>
        /// Год выхода фильма
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// Описание фильма
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Постер фильма
        /// </summary>
        //public object Image { get; set; }
    }
}
