using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Catalog
    {
        private readonly List<Track> tracks = new List<Track>();

        public IEnumerable<object> AllTrack { get; set; }

        public void AddTrack(Track track)
        {
            if (tracks.Contains(track)) // если уже есть такой трек
            {
                throw new ArgumentException("Такой трек уже есть в каталоге");
            }
            tracks.Add(track);
        }
        public void RemoveTrack(Track track)
        {
            if (tracks.Contains(track) == false)
            {
                throw new ArgumentException("Такого трека нет в каталоге");
            }
            tracks.Remove(track);

        }
        public IEnumerable<Track> AllTracks
        {
            get
            {
                return tracks; //сделать вывод списка
            }
        }
    }
}
