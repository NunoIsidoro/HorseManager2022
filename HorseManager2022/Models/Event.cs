using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.Models
{
    internal class Event
    {
        // Properties
        public string name;
        public EventType type;
        public Date date;

        // Constructor
        public Event(string name, EventType type, Date date)
        {
            this.name = name;
            this.type = type;
            this.date = date;
        }

        // Methods
        static public ConsoleColor GetEventTypeColor(EventType? eventType)
        {
            switch (eventType)
            {
                case EventType.Race:
                    return ConsoleColor.Red;
                case EventType.Demostration:
                    return ConsoleColor.Magenta;
                case EventType.Holiday:
                    return ConsoleColor.Yellow;
                default:
                    return ConsoleColor.White;
            }
        }

    }
}