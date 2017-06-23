namespace New_with_Views.Models.Entities
{
    public class InMovies{
        public int InMoviesID{get;set;}
        public int ActorID { get; set; }
        public int MovieItemID { get; set; }

        // Navigation prop
        public Actor Actor { get; set; }
        public Movie Movie { get; set; }
    }
}