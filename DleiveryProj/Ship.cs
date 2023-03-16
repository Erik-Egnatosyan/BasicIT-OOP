using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DleiveryProj
{
    internal class Ship : ITransport
    {
        public int MaxWeight { get; set; } = 5000;
        public int MinWeight { get; set; } = 500;
        public ITransport.Loaction LoactionDelivery { get; set; } = ITransport.Loaction.Germany;

        public int ShipTime { get; set; } = 5;
        public long TrackId { get; set; } = 65498569;
        public decimal ShipCost { get; set; } = 1800;
        public DateTime StartDate { get; set; } = new DateTime(2023, 3, 16);
        public DateTime EndDate { get; set; } = new DateTime(2023, 8, 16);
        public decimal Sale { get; set; } = 30;

        public void Checker()
        {
            UserInterface user = new UserInterface();
            Console.WriteLine($"Shiptime is {ShipTime} month\nShip cost is {ShipCost}$ and your sale is {Sale}%");
            Console.WriteLine("Do you want to buy? YES or NO");
            string checkInputYesOrNO = Console.ReadLine();
            if (checkInputYesOrNO == "YES" && user.money >= ShipCost)
            {
                Console.WriteLine($"Congratulation!!! You buy your item. Now get your track ID -> {TrackId}.\nThere is your StartDate ->{StartDate} and EndDate ->{EndDate}");
            }
            else
                Console.WriteLine("Sorry you cant do that :(");
        }
    }
}
