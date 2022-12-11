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

        
        // File Crud Methods
        static public void CreateSave()
        {
            // Create default player
            Player player = new();
            string path = Game.playerPath;
            string D = Game.DELIMITER;

            // Add user to file
            File.AppendAllText(path, player.money + D + player.date.ToSaveFormat() + Environment.NewLine);
        }

        
        static public Player GetSave()
        {
            string path = Game.playerPath;
            string D = Game.DELIMITER;
            string[] data = File.ReadAllLines(path).First().Split(D);

            return new Player(int.Parse(data[0]), new Date(int.Parse(data[1]), (Month)int.Parse(data[2]), int.Parse(data[3])));
        }

        
        public void UpdateSave()
        {
            string path = Game.playerPath;
            string D = Game.DELIMITER;

            // Delete all lines
            File.WriteAllText(path, "");

            // Add user to file
            File.AppendAllText(path, money + D + date.ToSaveFormat() + Environment.NewLine);
        }
    }
}
