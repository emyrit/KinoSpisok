using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using KinoSpisok.Models;

namespace KinoSpisok.Controllers
{
    public class FilmController : Controller
    {
        public Films films;
        IRepository repository;
        public FilmController(IRepository repo) => repository = repo;
  

        public IActionResult HomeFilm()
        {
            return View();
        }
        public IActionResult Films()
        {

            return View(repository.Film);
        }

        public IActionResult Show(long id)
        {
            return View(repository.Film.Where(r=>r.Id==id));
        }

        [HttpPost]
        public IActionResult Show(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return View("Error");

            return View(repository.Film.Where(r => r.Name == name));
        }
        
        

        public IActionResult Error() => View();
        
    }
}
