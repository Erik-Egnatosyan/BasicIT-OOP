using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBoom
{
    internal class PaidFilms
    {
        Hashtable moviesTable = new Hashtable();
        decimal Balance = 5000;
        public void Top_Gun()
        {
            Hashtable movie = new Hashtable();
            movie.Add("Name", "Top Gun: Maverick 2");
            movie.Add("Genre", "Action");
            movie.Add("Category", "Movie");
            movie.Add("Description", "After more than 30 years of service as one of the Navy's top aviators, Pete \"Maverick\" Mitchell is where he belongs, pushing the envelope as a courageous test pilot and dodging the advancement in rank that would ground him.");
            movie.Add("StarCount", 4.5f);
            movie.Add("WatchCount", 150000);
            movie.Add("FilmDate", new DateTime(2022, 05, 27));
            movie.Add("Price", 300m);
            moviesTable.Add("Top Gun", movie);
        }

        public void Agent_007()
        {
            Hashtable movie = new Hashtable();
            movie.Add("Name", "James Bond: No Time to Die");
            movie.Add("Genre", "Action");
            movie.Add("Category", "Movie");
            movie.Add("Description", "James Bond has left active service. His peace is short-lived when Felix Leiter, an old friend from the CIA, turns up asking for help, leading Bond onto the trail of a mysterious villain armed with dangerous new technology.");
            movie.Add("StarCount", 4.6f);
            movie.Add("WatchCount", 200000);
            movie.Add("FilmDate", new DateTime(2022, 09, 30));
            movie.Add("Price", 250m);
            moviesTable.Add("Agent 007", movie);
        }

        public void Mission_Impossible()
        {
            Hashtable movie = new Hashtable();
            movie.Add("Name", "Mission: Impossible 7");
            movie.Add("Genre", "Action");
            movie.Add("Category", "Movie");
            movie.Add("Description", "Ethan Hunt and his team race against time to prevent a global catastrophe as they go on a new mission impossible.");
            movie.Add("StarCount", 4.8f);
            movie.Add("WatchCount", 250000);
            movie.Add("FilmDate", new DateTime(2022, 11, 04));
            movie.Add("Price", 500m);
            moviesTable.Add("Mission Impossible", movie);
        }
        public void GreenBook()
        {
            Hashtable movie = new Hashtable();
            movie.Add("Name", "Green Book");
            movie.Add("Genre", "Drama");
            movie.Add("Category", "Movie");
            movie.Add("Description", "A working-class Italian-American bouncer becomes the driver of an African-American classical pianist on a tour of venues through the 1960s American South.");
            movie.Add("StarCount", 4.8f);
            movie.Add("WatchCount", 100000);
            movie.Add("FilmDate", new DateTime(2018, 11, 16));
            movie.Add("Price", 0m);
            moviesTable.Add("Green Book", movie);
        }
        public void Start()
        {
            bool checker = true;
            Top_Gun();
            Agent_007();
            Mission_Impossible();
            GreenBook();
            int i = 1;
            Console.WriteLine($"Приветствую вас в синема стар.\nВаш текущий баланс {Balance}$\nДавайте я вам предложу список фильмов.\nВыберите и я вам дам описание фильма!\n");
            List<string> sortedMovieNames = new List<string>(moviesTable.Keys.Cast<string>());
            sortedMovieNames.Sort();
            while (checker)
            {
                foreach (string movieName in sortedMovieNames)
                {
                    Hashtable movie = (Hashtable)moviesTable[movieName];
                    Console.WriteLine($"{i}){movie["Name"]}");
                    i++;
                }
                Console.WriteLine("Введите номер фильма ниже либо наберите 0 для выхода");
                int numberCheck = Convert.ToInt32(Console.ReadLine());
                if (numberCheck == 1)
                {
                    Hashtable Agent_007Movie = (Hashtable)moviesTable["Agent 007"];
                    foreach (DictionaryEntry entry in Agent_007Movie.Cast<DictionaryEntry>().OrderBy(e => e.Key))
                    {
                        Console.WriteLine($"{entry.Key}: {entry.Value}");
                    }
                    Console.WriteLine("\nВы хотите купить?\n1)Yes\n2)No");
                    int buyNumberCheck = Convert.ToInt32(Console.ReadLine());
                    decimal Agent_007Price = (decimal)Agent_007Movie["Price"];
                    if (buyNumberCheck == 1 && Balance > Agent_007Price)
                    {
                        Console.WriteLine("Вы купили фильм! Можете посмотреь ваш фильм.\n");
                    }
                    else if (buyNumberCheck == 2)
                        Console.WriteLine("Хорош давайте продолжим искать что то другое\n");
                    else
                        Console.WriteLine("У вас нет столько денег либо ввод был не правильным!");
                }
                else if (numberCheck == 2)
                {
                    Hashtable GreenBookMovie = (Hashtable)moviesTable["Green Book"];
                    foreach (DictionaryEntry entry in GreenBookMovie.Cast<DictionaryEntry>().OrderBy(e => e.Key))
                    {
                        Console.WriteLine($"{entry.Key}: {entry.Value}");
                    }
                    Console.WriteLine("\nВы хотите купить?\n1)Yes\n2)No");
                    int buyNumberCheck = Convert.ToInt32(Console.ReadLine());
                    decimal GreenBookPrice = (decimal)GreenBookMovie["Price"];
                    if (buyNumberCheck == 1 && Balance > GreenBookPrice)
                    {
                        Console.WriteLine("Вы купили фильм! Можете посмотреь ваш фильм.\n");
                    }
                    else if (buyNumberCheck == 2)
                        Console.WriteLine("Хорош давайте продолжим искать что то другое\n");
                    else
                        Console.WriteLine("У вас нет столько денег либо ввод был не правильным!");
                }
                else if (numberCheck == 3)
                {
                    Hashtable Mission_ImpossibleMovie = (Hashtable)moviesTable["Mission Impossible"];
                    foreach (DictionaryEntry entry in Mission_ImpossibleMovie.Cast<DictionaryEntry>().OrderBy(e => e.Key))
                    {
                        Console.WriteLine($"{entry.Key}: {entry.Value}");
                    }
                    Console.WriteLine("\nВы хотите купить?\n1)Yes\n2)No");
                    int buyNumberCheck = Convert.ToInt32(Console.ReadLine());
                    decimal Mission_ImpossiblePrice = (decimal)Mission_ImpossibleMovie["Price"];
                    if (buyNumberCheck == 1 && Balance > Mission_ImpossiblePrice)
                    {
                        Console.WriteLine("Вы купили фильм! Можете посмотреь ваш фильм.\n");
                    }
                    else if(buyNumberCheck == 2)
                        Console.WriteLine("Хорош давайте продолжим искать что то другое\n");
                    else
                        Console.WriteLine("У вас нет столько денег либо ввод был не правильным!");
                }
                else if (numberCheck == 4)
                {
                    Hashtable topGunMovie = (Hashtable)moviesTable["Top Gun"];
                    foreach (DictionaryEntry entry in topGunMovie.Cast<DictionaryEntry>().OrderBy(e => e.Key))
                    {
                        Console.WriteLine($"{entry.Key}: {entry.Value}");
                    }
                    Console.WriteLine("\nВы хотите купить?\n1)Yes\n2)No");
                    int buyNumberCheck = Convert.ToInt32(Console.ReadLine());
                    decimal topGunPrice = (decimal)topGunMovie["Price"];
                    if (buyNumberCheck == 1 && Balance > topGunPrice)
                    {
                        Console.WriteLine("Вы купили фильм! Можете посмотреь ваш фильм.\n");
                    }
                    else if (buyNumberCheck == 2)
                        Console.WriteLine("Хорош давайте продолжим искать что то другое\n");
                    else
                        Console.WriteLine("У вас нет столько денег либо ввод был не правильным!");
                }
                else if (numberCheck == 0)
                    checker = false;
                else
                    Console.WriteLine("Wrong Input!\n");
            }
        }
    }
}
