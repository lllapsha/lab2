using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Track //internal
    {
        private string title;
        private string author;

        public Track(string title, string author) {
            this.title = title; 
            this.author = author;  
        }
        public string Title { get { return title; } set { } }
        public string Author { get { return author; } set { } }



        //private readonly List<Track> tracks = new List<Track>();

        //public void Add(Track track)
        //{
        //    if (tracks.Contains(track)) // если уже есть такой трек
        //    {
        //        throw new ArgumentException("Такой трек уже есть в каталоге");
        //    }
        //    tracks.Add(track);
        //}

        //public void Remove(Track track)
        //{
        //    if (tracks.Contains(track) == false)
        //    {
        //        throw new ArgumentException("Такого трека нет в каталоге");
        //    }
        //    tracks.Remove(track);

        //}

        //public IEnumerable<Track> AllTracks
        //{
        //    get
        //    {
        //        return tracks;
        //    }
        //}
    }
}
