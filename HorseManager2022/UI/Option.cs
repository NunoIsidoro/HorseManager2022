using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI
{
    internal class Option
    {
        public string text { get; set; }
        public Action onEnter { get; set; }

        public Option(string text, Action onEnter)
        {
            this.text = text;
            this.onEnter = onEnter;
        }
    }
}
