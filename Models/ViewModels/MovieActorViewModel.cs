using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using New_with_Views.Models.Entities;

namespace New_with_Views.Models.ViewModels
{
    public class MovieActorViewModel
    {
       public Movie Movie { get; set; }
       public IEnumerable<Actor> Actors { get; set; }

    }
}