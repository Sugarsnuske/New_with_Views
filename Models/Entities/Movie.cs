using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace New_with_Views.Models.Entities
{
    public class Movie
    {
        [Key]
        public int MovieItemID{get;set;}
        [Required]
        [Display(Name = "Movie Title")]
        public string MovieTitle{get;set;}
        [Display(Name = "Year Published")]
        public int YearPublished{get;set;}
        [Display(Name = "Genre")]
        public string Genre{get;set;}
        [Display(Name = "Director")]
        public string Director{get;set;}
        [Display(Name = "Movie Length")]
        public string MovieLength{get;set;}
        [Display(Name = "Movie Plot")]
        public string MoviePlot{get;set;}
        [Display(Name = "Movie Rating")]
        public int Rating{get;set;}

    }
}