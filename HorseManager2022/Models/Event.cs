using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.Models
{
    internal class Event
    {
        // Constants
        private const int EVENT_QUANTITY_YEAR = 30;
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
        

        // File Crud Methods
        static public void CreateSave()
        {
            string D = Game.DELIMITER;
            string path = Game.eventPath;
            string saveData = "";
            List<Event> events = new();

            // Add Holiday Events
            events.Add(new("New Year", EventType.Holiday, new(1, Month.Spring, 1)));
            events.Add(new("Easter", EventType.Holiday, new(15, Month.Spring, 1)));
            events.Add(new("Thanksgiving", EventType.Holiday, new(23, Month.Summer, 1)));
            events.Add(new("Diwali", EventType.Holiday, new(7, Month.Summer, 1)));
            events.Add(new("Halloween", EventType.Holiday, new(21, Month.Autumn, 1)));
            events.Add(new("Black Friday", EventType.Holiday, new(28, Month.Autumn, 1)));
            events.Add(new("Hanukkah", EventType.Holiday, new(18, Month.Winter, 1)));
            events.Add(new("Christmas", EventType.Holiday, new(25, Month.Winter, 1)));

            // Add Random Events
            for (int i = 0; i < EVENT_QUANTITY_YEAR; i++)
            {
                Event randomEvent;
                do
                {
                    randomEvent = GenerateRandomEvent();
                } while (!hasEventsOnDate(events, randomEvent.date));

                events.Add(randomEvent);
            }

            // Transform events in saveData
            foreach (Event @event in events)
                saveData += @event.name + D + (int)@event.type + D + @event.date.day + D + (int)@event.date.month + D + @event.date.year + Environment.NewLine;

            // Add user to file
            File.WriteAllText(path, saveData);
        }


        static private bool hasEventsOnDate(List<Event> events, Date date) => !events.Any(e => e.date == date);
        

        static public List<Event> GetEventsSave()
        {
            string path = Game.eventPath;
            string D = Game.DELIMITER;
            string[] lines = File.ReadAllLines(path);
            List<Event> events = new();

            foreach (string line in lines)
            {
                string[] data = line.Split(D);
                string name = data[0];
                EventType type = (EventType)int.Parse(data[1]);
                Date date = new(int.Parse(data[2]), (Month)int.Parse(data[3]), int.Parse(data[4]));

                events.Add(new Event(name, type, date));
            }
                
            return events;

        }


        // Randomize Methods
        static private Event GenerateRandomEvent()
        {
            // Generate random event
            Random random = new();
            int randomType = random.Next(1, 3);
            string randomName = GenerateEventName(); //data[random.Next(0, data.Length)];
            Date randomDate = GenerateEventDate();

            // Create event
            Event randomEvent = new(randomName, (EventType)randomType, randomDate);
            return randomEvent;
        }

        
        static private Date GenerateEventDate()
        {
            // Generate random date
            Random random = new();
            int randomDay = random.Next(1, 29);
            int randomMonth = random.Next(0, 5);
            
            // Create date
            Date randomDate = new(randomDay, (Month)randomMonth, 1);
            return randomDate;
        }

        static private string GenerateEventName()
        {
            // Variables
            Random random = new Random();

            string[] list = {
                "Maverick Team",
                "Five Go Event",
                "Sage Glamorous Encore",
                "Fête Gold Happen",
                "Bonfire Green Ranch",
                "Perfect Sensations",
                "Proteus Live Entertainment",
                "Scenario Productions",
                "Crystal Eventualities",
                "Fête Bird",
                "Organically Attainment",
                "Fête Gold Happen",
                "Bonfire Red Living",
                "Every Science",
                "Land Planning",
                "Dazzling Of Evermore",
                "Divine Scenes",
                "Prince Lucky",
                "Glowing Happen",
                "Fourplan Event InStyle",
                "Little Happen",
                "Carpe Diem By Company",
                "Shindig Red Inc",
                "The Circumstances",
                "Seven Delight",
                "Sunset Good Logic",
                "Pomp Company",
                "Vintage Team",
                "Blowout Your Tree",
                "Proteus Live Entertainment",
                "Castles Together Prep",
                "Enchanting The Eventerprises",
                "Divine Main Paradise",
                "Famous Blue Touch",
                "Cirque Bird",
                "Dreams Big Factor",
                "Princess Curators",
                "Staging Shindigger",
                "Classy Factor",
                "Gold Décor",
                "Princess Touch",
                "Classy Factor",
                "Oh How Scenarios",
                "Organization Dream Sensations",
                "Crystal Your InStyle",
                "Dreams Gurus",
                "Big E Up Scenes",
            };

            return list[random.Next(0, list.Length)];
        }

    }
}