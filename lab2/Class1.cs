using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            var catalog = new Catalog();

            do
            {
                Console.WriteLine("1. Показать все треки");
                Console.WriteLine("2. Добавить трек");
                Console.WriteLine("3. Удалить трек");
                Console.WriteLine("4. Поиск трека");


                var key = Console.ReadKey();

                switch (key.KeyChar)
                {
                    case '1':
                        {
                            foreach (Track tr in catalog.AllTracks)
                            {
                                PrintTrack(tr);
                            }
                            break;
                        }
                    case '2':
                        {
                            var track = ReadTrack();
                            catalog.AddTrack(track);
                            break;
                        }
                    case '3':
                        {
                            var track = ReadTrack();
                            catalog.RemoveTrack(track);
                            break;
                        }
                    case '4':
                        {
                            var track = ReadTrack();
                            break;
                        }
                }
            }
            while (Console.ReadKey().KeyChar != 'q');
        }
        public static void PrintTrack(Track track)
        {
            Console.WriteLine(track.Title + " - " + track.Author);
        }

        public static Track ReadTrack()
        {
            Console.Write("Введите название композиции: ");
            string songName = Console.ReadLine();

            Console.Write("Введите автора композиции: ");
            string authorName = Console.ReadLine();

            return new Track(songName, authorName);

        }
    }
}
