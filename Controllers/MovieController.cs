using System.Collections.Generic;
using System.Linq;
using New_with_Views.Models;
using New_with_Views.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using New_with_Views.Models.Entities;
using New_with_Views.Models.ViewModels;
using System;

namespace New_with_Views.Controllers
{
    public class MovieController : Controller
    {
        // Loosly Coupled
        private IMovieRepository _movieRepository;
        private IActorRepository _actorRepository;

        public MovieController(IMovieRepository movieRepository, IActorRepository actorRepository)
        {
            this._movieRepository = movieRepository;
            this._actorRepository = actorRepository;
            
        }

        // Read
        [HttpGet]
        public IActionResult Index(string searchString)
        {
            /*IEnumerable<Movie> movies = _movieRepository.GetAll();
            return View(movies);*/
            
            var movies = from m in _movieRepository.GetAll() 
                 select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(m => m.MovieTitle.Contains(searchString));
            }

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
            Movie movie =  _movieRepository.Get(id);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Update(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movieRepository.Update(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        //Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
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

        public IActionResult InMovie(int id){
            MovieActorViewModel mavm = new MovieActorViewModel();
            mavm.Movie = _movieRepository.Get(id);
            mavm.Actors = _actorRepository.GetAll();

            return View(mavm);
        }
        /*public IActionResult Search(string searchString)
        {
        }*/

    }
}
