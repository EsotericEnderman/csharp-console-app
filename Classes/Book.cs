namespace CSharpConsoleApp.Classes
{

    internal class Book
    {

        public string title;
        public string authorName;
        public string genre;
        public int pageCount;

        public Book(string title, string authorName, int pageCount, string genre = "Not specified")
        {
            Console.WriteLine("Creating new book! " + title);

            this.title = title;
            this.authorName = authorName;
            this.genre = genre;
            this.pageCount = pageCount;
        }
    }
}
