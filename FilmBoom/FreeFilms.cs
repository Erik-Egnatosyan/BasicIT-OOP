using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBoom
{
    internal class FreeFilms : IFilms
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public float StarCount { get; set; }
        public int WatchCount { get; set; }
        public DateTime FilmDate { get; set; }

        public void DisplayActors(Actors actors)
        {

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
            DisplayActors(Actors.Вигго_Мортенсен);
            DisplayActors(Actors.Махершала_Али);
        }
        public void Changeable()
        {
            Console.WriteLine($"The movie name is {Name}.\nThe genre is {Genre}.\nMain actor is {DisplayActors}.\nThe category of movie is {Category}.\nDescription: {Description};\nThe rating is {StarCount}.\nWatch count is {WatchCount} and film date is {FilmDate}.");
        }
    }
}
