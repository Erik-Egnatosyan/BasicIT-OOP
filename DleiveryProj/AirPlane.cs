using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DleiveryProj
{
    internal class AirPlane : ITransport
    {
        public int MaxWeight { get; set; } = 1500;
        public int MinWeight { get; set; } = 300;
        public ITransport.Loaction LoactionDelivery { get; set; } = ITransport.Loaction.France;

        public int ShipTime { get; set; } = 2;
        public long TrackId { get; set; } = 78459574;
        public decimal ShipCost { get; set; } = 2800;
        public DateTime StartDate { get; set; } = new DateTime(2023, 3, 16);
        public DateTime EndDate { get; set; } = new DateTime(2023, 5, 16);
        public decimal Sale { get; set; } = 20;

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
