namespace MovieCollectionManager
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }

        public double Rating { get; set; } // Assuming a rating property is added for the highest-rated movie functionality.
        public Movie(string title, string director, int releaseYear, string genre, double rating)
        {
            Title = title;
            Director = director;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }
        public override string ToString()
        {
            return $"{Title} ({ReleaseYear}), directed by {Director}, Genre: {Genre}, Rating: {Rating}";
        }
    }
}
