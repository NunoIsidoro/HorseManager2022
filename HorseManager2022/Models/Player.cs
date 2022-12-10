using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.Models
{
    internal class Player
    {
        // Properties
        public int money;
        public Date date;

        // Inventory
        // public List<Horse> horses;
        // public List<Jockey> jockeys;
        // public List<HorseJockey> horseJockeys;
        // public List<Event> events;

        // Constructor
        public Player(int money, Date date)
        {
            this.money = money;
            this.date = date;

            // this.horses = new List<Horse>();
            // this.jockeys = new List<Jockey>();
            // this.horseJockeys = new List<HorseJockey>();
            // this.events = new List<Event>();
        }

        // Constructor for starting player
        public Player()
        {
            this.money = 10;
            this.date = new Date();

            // this.horses = new List<Horse>();
            // this.jockeys = new List<Jockey>();
            // this.horseJockeys = new List<HorseJockey>();
            // this.events = new List<Event>();
        }
    }
}
