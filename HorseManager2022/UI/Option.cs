﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI
{
    internal class Option
    {
        public string text { get; set; }
        public Action<ScreenMenu> onEnter { get; set; }

        public Option(string text, Action<ScreenMenu> onEnter)
        {
            this.text = text;
            this.onEnter = onEnter;
        }
        
        static public Option GetExitOption()
        {
            return new Option("Exit", (_) => { Environment.Exit(0); });
        }

        static public Option GetBackOption(ScreenMenu lastScreen)
        {
            return new Option("Back", (_) => { lastScreen.Show(); });
        }
    }
}
