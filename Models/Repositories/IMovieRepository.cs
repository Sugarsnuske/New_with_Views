using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using New_with_Views.Models.Entities;

namespace New_with_Views.Models.Repositories
{
    public interface IMovieRepository
    {
        Movie Get(int id);
        IEnumerable<Movie> GetAll();
        void Update(Movie item);
        void Delete(Movie mo);
        void Save(Movie movie);
    }
}
