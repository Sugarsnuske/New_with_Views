using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using New_with_Views.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace New_with_Views.Models.Repositories
{
    public class ActorRepository : IActorRepository
    {
        private MyDbContext _dbA;
        private DbSet<Actor> _actors;

        public ActorRepository(MyDbContext db)
        {
            _dbA = db;
            _actors = db.Actors;
        }


        public void Delete(Actor ac)
            {
             Actor actor = _dbA.Actors.Find(ac.ActorID);
             _dbA.Actors.Remove(actor);
             _dbA.SaveChanges();
            }

        public Actor Get(int id)
        {
            Actor actor =  _dbA.Actors.Find(id);
            return actor;
        }

        public IEnumerable<Actor> GetAll()
        {
            IEnumerable<Actor> actors = _dbA.Actors;
            return actors;
        }

        public void Save(Actor actor)
        {
            _dbA.Actors.Add(actor);
            _dbA.SaveChanges();
        }

        public void Update(Actor actor)
        {
            _dbA.Actors.Update(actor);
            _dbA.SaveChanges();
        }
    }
}
