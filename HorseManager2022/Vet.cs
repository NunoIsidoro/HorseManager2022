using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022
{
    public class Vet
    {

        //Atributos
        public int id;
        public string name;
        public int level;
        public int upgradeCost;
        public int proficiency;

        //construtores
        public Vet()
        {
            this.id = 80;
            this.name = "Doctor Gustavo Fring";
            this.level = 1;
            this.upgradeCost = 40;
            this.proficiency = 5;
        }

        public Vet(int id, string name, int level, int upgradeCost, int proficiency)
        {
            this.id = id;
            this.name = name;
            this.level = level;
            this.upgradeCost = upgradeCost;
            this.proficiency = proficiency;
        }

        //Metodo
        public void Upgrade()
        {
            this.level++;
            this.upgradeCost = (int)(this.upgradeCost * 1.3);
        }
    }
}
