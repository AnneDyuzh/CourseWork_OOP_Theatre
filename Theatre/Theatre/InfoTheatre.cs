using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre
{
    abstract class InfoTheatre
    {
        public string Rating { get; set; } // Рейтинг
    }

    class InfoEvents : InfoTheatre
    {
        public string NameEvent { get; set; }// Название мероприятия
        public string TypeEvent { get; set; }// Тип мероприятия
        public uint CountActors { get; set; }// Количество актёров
        public uint CountTickets { get; set; }// Количество мест
        public uint Price { get; set; }// Цена билета

        public InfoEvents(string nameEvent, string typeEvent, uint countActors, uint countTickets, uint price, string rating)
        {
            NameEvent = nameEvent;
            TypeEvent = typeEvent;
            CountActors = countActors;
            CountTickets = countTickets;
            Price = price;
            Rating = rating;
        }
    }

    class InfoActors : InfoTheatre
    {
        public string Actor { get; set; }// ФИО актёра
        public uint Age { get; set; }// Возраст
        public uint Work { get; set; }// Стаж

        public InfoActors(string actor, uint age, uint work, string rating)
        {
            Actor = actor;
            Age = age;
            Work = work;
            Rating = rating;
        }
    }

}