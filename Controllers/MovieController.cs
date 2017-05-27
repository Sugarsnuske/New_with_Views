using System.Collections.Generic;
using System.Linq;
using New_with_Views.Models;
using New_with_Views.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using New_with_Views.Models.Entities;
using New_with_Views.Models.ViewModels;

namespace ConsoleApplication.Controllers
{
    public class MovieController : Controller
    {
        // Loosly Coupled
        private IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            this._movieRepository = movieRepository;   
        }

        // Read
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Movie> movies = _movieRepository.GetAll();
            return View(movies);
        }

        // Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //Create
        [HttpPost]
        public IActionResult Create(Movie mo)
        {
            if (ModelState.IsValid)
            {
                _movieRepository.Save(mo);

                // Moved to the repo
                // db.Students.Add(st);
                // db.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
                return View();
            }
        }

        // Update
        public IActionResult Update(int id)
        {
            //Student student = db.Students.Find(id);
            Movie movie =  _movieRepository.Get(id);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Update(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movieRepository.Update(movie);
                //db.Students.Update(student);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        //Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            //Student student = db.Students.Find(id);
            Movie movie =  _movieRepository.Get(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Movie mo)
        {
            _movieRepository.Delete(mo);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var movie = _movieRepository.Get(id);
            return View(movie);
        }

    }
}
