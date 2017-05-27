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
                    Director ="The Stupid Idiot", MovieLength = "1 hour 00 minutes", MoviePlot ="some looooooooong text", Rating = 5 },
                new Movie{MovieItemID = 3, MovieTitle = "Second task", YearPublished = 2017, Genre ="Fiction",
                    Director ="The Other Stupid Idiot", MovieLength = "1 hour 55 minutes", MoviePlot ="some looooooooong text", Rating = 1 },
                new Movie{MovieItemID = 4, MovieTitle = "Third task", YearPublished = 2007, Genre ="Romance",
                    Director ="The Stupidest Idiot", MovieLength = "3 hour 09 minutes", MoviePlot ="some looooooooong text", Rating = 3 },
            };
            foreach (Movie m in movies)
            {
                context.Movies.Add(m);
            }
            context.SaveChanges();
        }
    }
}
