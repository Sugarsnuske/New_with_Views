using System.Collections.Generic;
using New_with_Views.Models.Entities;

namespace New_with_Views.Models.Repositories
{
    public interface IInMoviesRepository
    {
        // basicc CRUD for Enrollment
        void Save(InMovies actor);
        Actor Get(int id);
        IEnumerable<InMovies> GetAll();
        void Update(InMovies actor);
        void Delete(int id);
    }
}