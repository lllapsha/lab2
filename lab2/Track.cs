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

        public Track(string title, string author)
        {
            this.title = title;
            this.author = author;
        }
        public string Title { get { return title; } }
        public string Author { get { return author; } }
    }
}
