using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBoom
{
    internal class User
    {
        PaidFilms pdFilm = new PaidFilms();

        public decimal Balance = 5000;
        bool CodeBreaker = true;
        int numberChoice = 0;
        public void FeelFilm()
        {
            Hashtable filmGenre = new Hashtable();
            filmGenre.Add("Top Gun: Maverick 2", "Action");
            filmGenre.Add("James Bond: No Time to Die", "Action");
            filmGenre.Add("Mission Impossible 7", "Action");
            filmGenre.Add("Green Book", "Drama");
        }
        public Hashtable PriceFilm()
        {
            Hashtable filmPrice = new Hashtable();
            filmPrice.Add("Top Gun: Maverick 2", 300);
            filmPrice.Add("James Bond: No Time to Die", 500);
            filmPrice.Add("Mission Impossible 7", 700);
            filmPrice.Add("Green Book", null);
            return filmPrice;
        }
        public void UserInterface()
        {
            Hashtable filmPrice = PriceFilm();
            foreach (var item in filmPrice.Keys)
            {
                if (filmPrice[item] != null)
                    Console.WriteLine($"{item} : {filmPrice[item]}");
            }
            
                

        }
    }
}
