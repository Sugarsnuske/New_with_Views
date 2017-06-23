using System;
using System.Collections.Generic;
using System.Linq;
using New_with_Views.Models;
using New_with_Views.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace New_with_Views.Controllers
{
    public class HomeController : Controller
    {

        MyDbContext db = new MyDbContext();

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Movie> movies = db.Movies.ToList();
            ViewBag.Y = movies;
            return View();
        }
        [HttpGet] 
        public IActionResult About()
        {
            return View();
        }
    }
}
