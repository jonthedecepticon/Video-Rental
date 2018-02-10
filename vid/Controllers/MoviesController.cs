using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vid.Models;

namespace vid.Controllers
{
    public class MoviesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };

            return View(movie);
        }
    }
}
