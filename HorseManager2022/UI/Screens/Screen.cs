using HorseManager2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI
{
    internal abstract class Screen : SelectionableObject
    {
        // Properties
        public string title;
        protected Screen? previousScreen { get; set; }
        
        protected bool isInitialScreen
        {
            get
            {
                return previousScreen == null;
            }
        }
        
        
        // Constructor
        public Screen(string title, Screen? previousScreen = null)
        {
            this.title = title;
            options = new List<Option>();
            this.previousScreen = previousScreen;
        }

        
        // Methods
        abstract public Screen? Show(Player? player);
        
    }
}
