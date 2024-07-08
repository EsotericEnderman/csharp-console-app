using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_App
{
    internal class Song
    {
        public string title;
        public string artists;
        public int durationSeconds;

        public static int songCount; // = 0

        public Song(string title, string artists, int durationSeconds) {
            this.title = title;
            this.artists = artists;
            this.durationSeconds = durationSeconds;

            songCount++;
        }

        public int GetSongCount() { return songCount; }

        public int SongCount
        {
            get { return songCount; } // In reality, songCount would have been made private.
        }
    }
}
