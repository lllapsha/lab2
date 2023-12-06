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

        public IEnumerable<Track> AllTrack { get; set; }

        public void AddTrack(Track track)
        {
            if (tracks.Contains(track)) 
            {
                throw new ArgumentException("Такой трек уже есть в каталоге");
            }
            tracks.Add(track);

        }
        public void RemoveTrack(Track track)
        {
            Track existingTrack = tracks.FirstOrDefault(t => t.Title == track.Title && t.Author == track.Author);

            if (existingTrack != null)
            {
                tracks.Remove(existingTrack);
            }
            else
            {
                throw new ArgumentException("Такого трека нет в каталоге");
            }

        }

        public void SearchTrack(Track track)
        {
            Track existingTrack = tracks.FirstOrDefault(t => t.Title == track.Title && t.Author == track.Author);

            if (existingTrack != null)
            {
                track = existingTrack;
            }
            else
            {
                throw new ArgumentException("Такого трека нет в каталоге");
            }
        }
        
        public IEnumerable<Track> AllTracks
        {
            get
            {
                return tracks;
            }
        }

    }
}
