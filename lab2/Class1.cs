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

            bool isTrue = true;

            do
            {
                Console.WriteLine("1. Показать все треки");
                Console.WriteLine("2. Добавить трек");
                Console.WriteLine("3. Удалить трек");
                Console.WriteLine("4. Поиск трека");
                Console.WriteLine("q. Выйти");

                Console.WriteLine();
                var key = Console.ReadKey().KeyChar;

                switch (key)
                {
                    case '1':
                        {
                            Console.WriteLine();
                            foreach (Track tr in catalog.AllTracks)
                            {
                                PrintTrack(tr);
                            }
                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine();
                            var track = ReadTrack();
                            catalog.AddTrack(track);
                            break;
                        }
                    case '3':
                        {
                            Console.WriteLine();
                            var track = ReadTrack();
                            catalog.RemoveTrack(track);
                            break;
                        }
                    case '4':
                        {
                            Console.WriteLine();
                            var track = ReadTrack();
                            catalog.SearchTrack(track);
                            PrintTrack(track);
                            break;
                        }
                    case 'q':
                        {
                            isTrue = false;
                            break;
                        }
                }
                Console.WriteLine();
            }
            while (isTrue);

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
