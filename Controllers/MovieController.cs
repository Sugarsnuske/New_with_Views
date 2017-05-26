using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using New_with_Views.Models.Repositories;
using New_with_Views.Models.Entities;

namespace New_with_Views.Controllers
{
    public class MoviesController : Controller
    {
        private IMovieRepository _movieRepository;
        public MoviesController(IMovieRepository movieRepository){
            _movieRepository = movieRepository;
            
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            var movies = _movieRepository.GetAll();
          //  _todoList.Add(new TodoItem{TodoItemID = 1, Task = "First Task", IsComplete = false});
            return new OkObjectResult(movies);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            //return NotFound();
            return new OkObjectResult(_movieRepository.Get(id));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Movie mo)
        {
            _movieRepository.Delete(mo);
            return NoContent();
            
        }
    }
}
