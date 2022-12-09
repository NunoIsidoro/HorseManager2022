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
        public EventType type;
        public Date date;

        // Constructor
        public Event(EventType type, Date date)
        {
            this.type = type;
            this.date = date;
        }
    }
}
