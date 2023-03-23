using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBoom
{
    internal class User
    {
        FreeFilms frFilm = new FreeFilms();
        PaidFilms pdFilm = new PaidFilms();

        public int Balance = 5000;
        bool CodeBreaker = true;
        public void UserInterface()
        {
            frFilm.GreenBook();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                pdFilm.Mission_Impossible();
                pdFilm.Top_Gun();
                pdFilm.Agent_007();
                sb.Append(pdFilm.Name);
            }
            Console.WriteLine(sb);
            Console.WriteLine("Welcome to Cinema! Lets see what we have");
            Console.WriteLine($"In free films we have \"{frFilm.Name}\"\nIn Paid we have {pdFilm.Name} {pdFilm.Name} {pdFilm.Name}");
        }
    }
}
