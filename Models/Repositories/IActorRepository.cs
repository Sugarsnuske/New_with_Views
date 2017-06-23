using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using New_with_Views.Models.Entities;

namespace New_with_Views.Models.Repositories
{
    public interface IActorRepository
    {
        Actor Get(int id);
        IEnumerable<Actor> GetAll();
        void Update(Actor item);
        void Delete(Actor ac);
        void Save(Actor actor);
    }
}
