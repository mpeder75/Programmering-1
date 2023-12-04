using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_X___DatabaseSQLMusicApp
{
    internal class Album
    {
        public int ID { get; set; }
        public string AlbumName { get; set; }
        public string ArtistName { get; set; }
        public int Year { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }

        // List<Track> songs - Denne er FORIGN KEY i C# delen
        public List<Track> Tracks { get; set; }


    }
}
