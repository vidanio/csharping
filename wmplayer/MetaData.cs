using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wmplayer
{
    class MetaData
    {
        public string Album { get; set; }
        public string Author { get; set; }
        public string Track { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int BitRate { get; set; }
        public int AvgLevel { get; set; }

        public MetaData()
        {
            this.Album = "";
            this.Author = "";
            this.Track = "";
            this.Title = "";
            this.Genre = "";
            this.BitRate = 0;
            this.AvgLevel = 0;
        }

        public void SetMetaData(string album, string author, string track, string title, string genre, int bitrate, int avglevel)
        {
            this.Album = album;
            this.Author = author;
            this.Track = track;
            this.Title = title;
            this.Genre = genre;
            this.BitRate = bitrate;
            this.AvgLevel = avglevel;
        }

    }
}
