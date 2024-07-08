using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_App
{
    internal class Movie
    {
        public string title;
        public string director;
        public Rating rating;
        private string ageRating; // Set property to private when using getters and setters.

        public Movie(string title, string director, Rating rating, string ageRating)
        {
            this.title = title;
            this.director = director;
            this.rating = rating;
            
            AgeRating = ageRating;
        }

        public string AgeRating
        {
            get { return ageRating; }
            // Value is the value that the user has set the property to.
            set {
                if (value != "G" && value != "PG" && value != "PG-13" && value != "R" && value != "NR")
                {
                    throw new ArgumentException("Invalid age rating, must be one of the following: 'G', 'PG', 'PG-13', 'R' or 'NR'.");
                }

                ageRating = value;
            }
        }
    }
}
