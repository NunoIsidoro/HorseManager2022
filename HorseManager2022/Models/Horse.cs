using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.Models
{
    internal class Horse
    {
        // Properties
        public int id;
        public string name;
        public Rarity rarity;
        public int price;
        public int speed;
        public int resistance;
        public int stamina;
        public int age;

        // Constructor
        public Horse(int id, string name, Rarity rarity, int price, int speed, int resistance, int stamina, int age)
        {
            this.id = id;
            this.name = name;
            this.rarity = rarity;
            this.price = price;
            this.speed = speed;
            this.resistance = resistance;
            this.stamina = stamina;
            this.age = age;
        }
    }
}
