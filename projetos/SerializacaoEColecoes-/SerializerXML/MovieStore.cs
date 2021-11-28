using System.Collections.Generic;

namespace moviestore
{
    public class MovieStore
    {
        private static MovieStore mstore;
        public List<Director> Directors = new List<Director>();
        public List<Movie> Movies = new List<Movie>();
        public static MovieStore AddMovie(Movie movie)
        {
            
            if(mstore == null){
                mstore = new MovieStore();
            }

            mstore.Movies.Add(movie);

            return mstore;
        }
    }

    public class Director
    {
        public string Name { get; set; }
        public int NumberOfMovies;
    }

    public class Movie
    {
        public Director Director { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
    }
}
