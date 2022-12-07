using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI
{
    internal class Option
    {
        // Properties
        public string text { get; set; }
        public Action<Screen> onEnter { get; set; }

        // Constructor
        public Option(string text, Action<Screen> onEnter)
        {
            this.text = text;
            this.onEnter = onEnter;
        }

        static public Option GetBackOption(bool isInitialScreen = false)
        {
            if (isInitialScreen)
                return new Option("Exit", (_) => { Environment.Exit(0); });
            else
                return new Option("Back", (screen) => { screen.previousScreen?.Show(); });
        }
    }
}
