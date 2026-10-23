namespace MovieCollectionManager
{
    public class MovieCollection
    {
        // Properties and methods for managing the movie library can be added here.
        private readonly List<Movie> movies;

        public MovieCollection()
        {
            movies = new List<Movie>();
        }

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public void RemoveMovie(string title)
        {
            Movie? movie =
                movies.FirstOrDefault(
                    m => m.Title.Equals(
                        title,
                        StringComparison.OrdinalIgnoreCase));

            if (movie != null)
            {
                movies.Remove(movie);
            }
        }

        public Movie? FindMovieByTitle(string title)
        {
            return movies != null
                ? movies.FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                : null;
        }

        public List<Movie> FindMovieByGenre(string genre)
        {
            return movies != null
                ? movies.Where(m => m.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase)).ToList()
                : new List<Movie>();
        }

        public void GetHighestRatedMovie()
        {
            if (movies != null && movies.Count > 0)
            {
                var highestRatedMovie = movies.OrderByDescending(m => m.Rating).FirstOrDefault();
                if (highestRatedMovie != null)
                {
                    Console.WriteLine($"Highest Rated Movie: {highestRatedMovie}");
                }
            }
            else
            {
                Console.WriteLine("No movies in the collection.");
            }
        }

        public List<Movie> GetAllMovies()
        {
            return new List<Movie>(movies);
        }
    }
}
