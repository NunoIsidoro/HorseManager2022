using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.Models
{
    internal class Jockey
    {
        // Properties
        public int id;
        public string name;
        public Rarity rarity;
        public int handling;

        // Constructor
        public Jockey(int id, string name, Rarity rarity, int handling)
        {
            this.id = id;
            this.name = name;
            this.rarity = rarity;
            this.handling = handling;
        }
    }
}
