using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBoom
{
    interface IFilms
    {
        string Name { get; set; }
        string Genre { get; set; }
        string Category { get; set; }
        string Description { get; set; }
        float StarCount { get; set; }
        int WatchCount { get; set; }
        DateTime FilmDate { get; set; }
        void DisplayActors(Actors actors);
        void Changeable();
    }
    public enum Actors
    {
        Том_Круз,
        Майлз_Теллер,
        Саймон_Пегг,
        Ребека_Фергюсон,
        Дэниел_Крейг,
        Рами_Малек,
        Вигго_Мортенсен,
        Махершала_Али
    }
}
