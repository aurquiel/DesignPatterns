using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Composite
{
    public class Song : SongComponent
    {
        string songName;
        string bandName;
        int releaseYear;

        public Song(string songName, string bandName, int releaseYear)
        {
            this.songName = songName;
            this.bandName = bandName;
            this.releaseYear = releaseYear;
        }

        public override string GetSongName()
        {
            return songName;
        }

        public override string GetBandName()
        {
            return bandName;
        }

        public override int GetReleaseYear()
        {
            return releaseYear;
        }

        public override void DisplaySongInfo()
        {
            Console.WriteLine(songName + " was recorder by " + bandName + " in release year " + releaseYear);
        }
    }
}
