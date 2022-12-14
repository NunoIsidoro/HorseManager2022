using HorseManager2022.Enums;
using HorseManager2022.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.Models
{
    internal class Player : IDefinable
    {
        // Properties
        public int id { get; set; }
        public int money;
        public Date date;

        // Constructor
        public Player(int id,  int money, Date date)
        {
            this.id = id;
            this.money = money;
            this.date = date;
        }

        // Constructor for starting player
        public Player()
        {
            id = 0;
            this.money = 10;
            this.date = new Date();
        }

        public Player(string save)
        {
            string D = Game.DELIMITER;
            string[] parts = save.Split(D);

            id = int.Parse(parts[0]);
            money = int.Parse(parts[1]);
            date = new Date(int.Parse(parts[2]), (Month)int.Parse(parts[3]), int.Parse(parts[4]));
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

        /*
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
        */
        public string ToSaveFormat() => id + Game.DELIMITER + money + Game.DELIMITER + date.ToSaveFormat();
    }
}
