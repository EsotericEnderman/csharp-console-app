namespace CSharpConsoleApp.Classes
{

    internal class Song
    {

        private static int songCount; // = 0

        public string title;
        public string[] artists;
        public int durationSeconds;

        public static int SongCount
        {
            get { return songCount; }
        }

        public Song(string title, string[] artists, int durationSeconds)
        {
            this.title = title;
            this.artists = artists;
            this.durationSeconds = durationSeconds;

            songCount++;
        }
    }
}
