using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DleiveryProj
{
    internal class UserInterface
    {
        public const string YES = "YES";
        public const string NO = "NO";
        public int money { get; set; } = 5000;
        public void userInterface()
        {
            AirPlane airPlane = new AirPlane();
            Ship ship = new Ship();
            Truck truck = new Truck();
            Console.WriteLine("Pls add your item weight!");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight < 0)
            {
                Console.WriteLine("Invalid input");
                System.Environment.Exit(0);
            }  
            if (weight <= truck.MaxWeight && weight >= ship.MinWeight && weight >= airPlane.MinWeight)
            {
                Console.WriteLine("You can use 1)Truck 2)Airplane 3)Ship!\nWhich one you want use?");
                int numberCheck = Convert.ToInt32(Console.ReadLine());
                switch (numberCheck)
                {
                    case 1:
                        truck.Checker();
                        break;
                    case 2:
                        airPlane.Checker();
                        break;
                    case 3:
                        ship.Checker();
                        break;
                    default:
                        Console.WriteLine("Sorry i dont understand :(");
                        break;
                }
            }
            else if (weight <= airPlane.MinWeight)
            {
                Console.WriteLine("You can use Truck");
                truck.Checker();
            }
            else if (weight <= ship.MinWeight)
            {
                Console.WriteLine("You can use 1)Truck or 2)Airplane\nWhich one you want use?");
                int numberCheck = Convert.ToInt32(Console.ReadLine());
                switch (numberCheck)
                {
                    case 1:
                        truck.Checker();
                        break;
                    case 2:
                        airPlane.Checker();
                        break;
                    default:
                        Console.WriteLine("Sorry i dont understand :(");
                        break;
                }
            }
            else if (weight >= airPlane.MinWeight && weight <= airPlane.MaxWeight)
            {
                Console.WriteLine("You can use 1)Airplane or 2)Ship\nWhich one you want use?");
                int numberCheck = Convert.ToInt32(Console.ReadLine());
                switch (numberCheck)
                {
                    case 1:
                        airPlane.Checker();
                        break;
                    case 2:
                        ship.Checker();
                        break;
                    default:
                        Console.WriteLine("Sorry i dont understand :(");
                        break;
                }
            }
            else if (weight >= ship.MinWeight && weight <= ship.MaxWeight)
            {
                Console.WriteLine("You can use Airplane or Ship");
                airPlane.Checker();
            }
        }
    }
}
