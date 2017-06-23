using System;
using System.Linq;
using New_with_Views.Models.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace New_with_Views.Models 
{
    public static class DbInitializer
    {
        public static void Initialize(MyDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Movies.Any())
            {
                return;
            }

            var movies = new Movie[]
            {
                new Movie{MovieItemID = 1, MovieTitle = "First Movie", YearPublished = 1999, Genre ="Horror", 
                    Director = "Lars Larsen", MovieLength = "1 hours 00 minutes", MoviePlot ="some looooooooong text", Rating = 5 },
                new Movie{MovieItemID = 3, MovieTitle = "Second task", YearPublished = 2017, Genre ="Fiction",
                    Director = "Hans Hansen", MovieLength = "1 hours 55 minutes", MoviePlot ="some looooooooong text", Rating = 1 },
                new Movie{MovieItemID = 4, MovieTitle = "Third task", YearPublished = 2007, Genre ="Romance",
                    Director = "Peter Petersen", MovieLength = "3 hours 09 minutes", MoviePlot ="some looooooooong text", Rating = 3 },
                new Movie{MovieItemID = 5, MovieTitle = "5th Movie", YearPublished = 2017, Genre ="Horrer",
                    Director = "Morten Mortensen", MovieLength = "4 hours 21 minutes", MoviePlot ="some looooooooong text", Rating = 4 },
            };
            foreach (Movie m in movies)
            {
                context.Movies.Add(m);
            }

            if (context.Actors.Any())
            {
                return;
            }
            var actors = new Actor[]
            {
                new Actor{ActorID = 1, FirstName = "Fred", LastName = "Flintstone", Birthday = Convert.ToDateTime( "1984/08/22 21:07:00")},
                new Actor{ActorID = 2, FirstName = "Justin", LastName = "Case", Birthday = Convert.ToDateTime( "1980/07/21 21:07:00")},
                new Actor{ActorID = 3, FirstName = "Frederik", LastName = "Rumble", Birthday = Convert.ToDateTime( "1980/07/21 00:00:00")},
                new Actor{ActorID = 4, FirstName = "Charlotte", LastName = "Noth", Birthday = Convert.ToDateTime( "1966/05/31 00:00:00")}
            };
            foreach (Actor a in actors)
            {
                context.Actors.Add(a);
            }

             if (context.InMovies.Any())
            {
                return;
            }
            var inMovies = new InMovies[]
            {
                new InMovies{MovieItemID=1,ActorID=1},
                new InMovies{MovieItemID=3,ActorID=1},
                new InMovies{MovieItemID=1,ActorID=2},
                new InMovies{MovieItemID=4,ActorID=3},
                new InMovies{MovieItemID=5,ActorID=4},
                new InMovies{MovieItemID=4,ActorID=4},
                new InMovies{MovieItemID=3,ActorID=3},
                new InMovies{MovieItemID=5,ActorID=2},
            };
            foreach (InMovies i in inMovies)
            {
                context.InMovies.Add(i);
            }
            
            context.SaveChanges();
        }
    }
}
