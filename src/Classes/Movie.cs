#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace CSharpConsoleApp.Classes
#pragma warning restore IDE0130 // Namespace does not match folder structure
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
