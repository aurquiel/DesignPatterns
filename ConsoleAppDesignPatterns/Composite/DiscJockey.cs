using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Composite
{
    public class DiscJockey
    {
        SongComponent songList;

        public DiscJockey(SongComponent songList)
        {
            this.songList = songList;
        }

        public void GetSongList()
        {
            songList.DisplaySongInfo();
        }
    }
}
