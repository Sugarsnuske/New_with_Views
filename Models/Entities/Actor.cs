using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace New_with_Views.Models.Entities
{
    public class Actor{
        [Key]
        public int ActorID{get;set;}
        [Display(Name="First name")]
        public string FirstName{get;set;}
        [Display(Name="Last name")]
        public string LastName{get;set;}
        public DateTime Birthday{get;set;}

        public virtual IEnumerable<InMovies> InMovies { get; set; }
    }
}