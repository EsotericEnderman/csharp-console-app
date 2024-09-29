namespace CSharpConsoleApp.Classes
{

    internal class Movie(string title, string director, Rating rating, MovieAgeRating ageRating)
    {

        public string title = title;
        public string director = director;
        public Rating rating = rating;
        public MovieAgeRating ageRating = ageRating;
    }

    internal enum MovieAgeRating
    {
        G,
        PG,
        PG_13,
        R,
        NR
    }
}
