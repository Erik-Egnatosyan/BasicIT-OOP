using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBoom
{
    internal class PaidFilms : IFilms
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public float StarCount { get; set; }
        public int WatchCount { get; set; }
        public DateTime FilmDate { get; set; }
        public decimal Price { get; set; }
        public void DisplayActors(Actors actors)
        {
            
        }
        public void Top_Gun()
        {
            Name = "Top Gun: Maverick 2";
            Genre = "Action";
            Category = "Movie";
            Description = "After more than 30 years of service as one of the Navy's top aviators, Pete \"Maverick\" Mitchell is where he belongs, pushing the envelope as a courageous test pilot and dodging the advancement in rank that would ground him.";
            StarCount = 4.5f;
            WatchCount = 150000;
            FilmDate = new DateTime(2022, 05, 27);
        }
        public void Agent_007()
        {
            Name = "James Bond: No Time to Die";
            Genre = "Action";
            Category = "Movie";
            Description = "James Bond has left active service. His peace is short-lived when Felix Leiter, an old friend from the CIA, turns up asking for help, leading Bond onto the trail of a mysterious villain armed with dangerous new technology.";
            StarCount = 4.6f;
            WatchCount = 200000;
            FilmDate = new DateTime(2022, 09, 30);
        }
        public void Mission_Impossible()
        {
            Name = "Mission: Impossible 7";
            Genre = "Action";
            Category = "Movie";
            Description = "Ethan Hunt and his team race against time to prevent a global catastrophe as they go on a new mission impossible.";
            StarCount = 4.8f;
            WatchCount = 250000;
            FilmDate = new DateTime(2022, 11, 04);
        }
        public void GreenBook()
        {
            Name = "Green Book";
            Genre = "Drama";
            Category = "Movie";
            Description = "A working-class Italian-American bouncer becomes the driver of an African-American classical pianist on a tour of venues through the 1960s American South.";
            StarCount = 4.8f;
            WatchCount = 100000;
            FilmDate = new DateTime(2018, 11, 16);
        }
        public void Changeable()
        {
            Console.WriteLine($"The movie name is {Name}.\nThe genre is {Genre}.\nMain actor is {DisplayActors}.\nThe category of movie is {Category}.\nDescription: {Description};\nThe rating is {StarCount}.\nWatch count is {WatchCount} and film date is {FilmDate}.\nPrice is {Price}$");
        }
    }
}
