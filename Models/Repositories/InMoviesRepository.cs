using System;
using System.Collections.Generic;
using New_with_Views.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace New_with_Views.Models.Repositories
{
    public class InMoviesRepository : IInMoviesRepository
    {
        private MyDbContext _db;
        private DbSet<InMovies> _inMovies;
        // private DbSet<Enrollment> _enrollment;
        public InMoviesRepository(MyDbContext db)
        {
            _db = db;
            _inMovies = db.InMovies;

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Get(int id)
        {
            Actor actor =  _db.Actors.Find(id);
            return actor;
        }

        public IEnumerable<InMovies> GetAll()
        {
            IEnumerable<InMovies> inMovies = _db.InMovies;
            return inMovies;
        }

        public void Save(InMovies actor)
        {
            _inMovies.Add(actor);
            _db.SaveChanges();
        }

        public void Update(InMovies actor)
        {
            throw new NotImplementedException();
        }
    }
}