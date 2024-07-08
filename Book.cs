using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Book
    {
        public string title;
        public string authorName;

        public string genre;

        public int pageNumber;

        public Book(string title, string authorName, int pageNumber, string genre = "Not Specified")
        {
            Console.WriteLine("Creating new book! " + title);

            this.title = title;
            this.authorName = authorName;
            this.genre = genre;
            this.pageNumber = pageNumber;
        }
    }
}
