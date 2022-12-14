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
        
        public string ToSaveFormat() => id + Game.DELIMITER + money + Game.DELIMITER + date.ToSaveFormat();
    }
}
