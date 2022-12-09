using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.Models
{
    internal class HorseJockey
    {
        // Properties
        public Horse horse;
        public Jockey jockey;
        public int afinnity;

        // Constructor
        public HorseJockey(Horse horse, Jockey jockey, int afinnity)
        {
            this.horse = horse;
            this.jockey = jockey;
            this.afinnity = afinnity;
        }
    }
}
