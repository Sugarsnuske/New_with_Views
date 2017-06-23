using System.Collections.Generic;
using System.Linq;
using New_with_Views.Models;
using New_with_Views.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using New_with_Views.Models.Entities;
using New_with_Views.Models.ViewModels;

namespace New_with_Views.Controllers
{
    public class ActorController : Controller
    {
        // Loosly Coupled
        private IActorRepository _actorRepository;
        private IMovieRepository _movieRepository;

        public ActorController(IActorRepository actorRepository, IMovieRepository movieRepository)
        {
            this._actorRepository = actorRepository;
            this._movieRepository = movieRepository;
        }

        // Read
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Actor> actors = _actorRepository.GetAll();
            return View(actors);
            
        }

        // Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //Create
        [HttpPost]
        public IActionResult Create(Actor ac)
        {
            if (ModelState.IsValid)
            {
                _actorRepository.Save(ac);
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
            Actor actor =  _actorRepository.Get(id);
            
            return View(actor);
        }
        [HttpPost]
        public IActionResult Update(Actor actor)
        {
            if (ModelState.IsValid)
            {
                _actorRepository.Update(actor);
                return RedirectToAction("Index");
            }
            return View(actor);
        }

        //Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Actor actor =  _actorRepository.Get(id);
            return View(actor);
        }

        [HttpPost]
        public IActionResult Delete(Actor ac)
        {
            _actorRepository.Delete(ac);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var actor = _actorRepository.Get(id);
            return View(actor);
        }
    }
}
