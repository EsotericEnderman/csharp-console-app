#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace CSharpConsoleApp.Classes
#pragma warning restore IDE0130 // Namespace does not match folder structure
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
