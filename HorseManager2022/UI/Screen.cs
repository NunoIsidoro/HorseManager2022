using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI
{
    internal class Screen
    {
        public List<Option> options;

        public Screen()
        {
            options = new List<Option>();
        }

        public void AddOption(Option option)
        {
            options.Add(option);
        }
    }
}
