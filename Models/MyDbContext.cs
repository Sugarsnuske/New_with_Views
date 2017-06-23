using New_with_Views.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace New_with_Views.Models 
{ 
    public class MyDbContext : DbContext 
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<InMovies> InMovies {get; set;}
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite("Filename=./mydb.db");
        } 

    }
}