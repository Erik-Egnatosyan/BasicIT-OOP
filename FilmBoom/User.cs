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

        public decimal Balance = 5000;
        bool CodeBreaker = true;
        int numberChoice = 0;
        public void UserInterface()
        {
            frFilm.GreenBook();
            pdFilm.Mission_Impossible();
            string name1 = pdFilm.Name;
            decimal price1 = pdFilm.Price;
            pdFilm.Top_Gun();
            string name2 = pdFilm.Name;
            decimal price2 = pdFilm.Price;
            pdFilm.Agent_007();
            string name3 = pdFilm.Name;
            decimal price3 = pdFilm.Price;
            Console.WriteLine("Welcome to Cinema! Lets see what we have:");
            Console.WriteLine($"In free films we have \"{frFilm.Name}\"\nIn Paid we have \"{name1}\", \"{name2}\", \"{name3}\"");
            while (CodeBreaker == true)
            {
                Console.WriteLine($"\nYour Balance is {Balance}$.\nWhich one do you want see?\n1)Paid\n2)Free");
                numberChoice = Convert.ToInt32(Console.ReadLine());
                if (numberChoice == 1)
                {
                    Console.WriteLine($"Which one do you want to see?\n1){name1}\n2){name2}\n3){name3}");
                    int saveNumberChoice = Convert.ToInt32(Console.ReadLine());
                    if (saveNumberChoice == 1)
                    {
                        pdFilm.Mission_Impossible();
                        pdFilm.Changeable();
                    }
                    else if(saveNumberChoice == 2)
                    {
                        pdFilm.Top_Gun();
                        pdFilm.Changeable();
                    }
                    else if (saveNumberChoice == 3)
                    {
                        pdFilm.Agent_007();
                        pdFilm.Changeable();
                    }
                    else
                        Console.WriteLine("Try again");
                    Console.WriteLine("Do you want to buy it?\n1)Yes\n2)No");
                    numberChoice = Convert.ToInt32(Console.ReadLine());
                    if(numberChoice == 1)
                    {
                        if(saveNumberChoice == 1 && Balance > price1)
                        {
                            Console.WriteLine($"Congratulation you buy {name1}!");
                            Balance -= price1;
                        }
                        else if(saveNumberChoice == 2 && Balance > price2)
                        {
                            Console.WriteLine($"Congratulation you buy {name2}!");
                            Balance -= price2;
                        }
                        else if (saveNumberChoice == 2 && Balance > price3)
                        {
                            Console.WriteLine($"Congratulation you buy {name3}!");
                            Balance -= price3;
                        }
                        else
                            Console.WriteLine("You don't have enough money");
                    }
                    else
                    {
                        Console.WriteLine("Do you want to exit?\n1)Yes\n2)No");
                        numberChoice = Convert.ToInt32(Console.ReadLine());
                        if(numberChoice == 1)
                        {
                            CodeBreaker = false;
                        }
                        else
                            Console.WriteLine("Lets try to find another movie");
                    }
                }
                else if (numberChoice == 2)
                    frFilm.Changeable();
                else
                    Console.WriteLine("Try again");
            }
        }
    }
}
