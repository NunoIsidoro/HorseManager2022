using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI
{
    interface ISelectable
    {
        // Properties
        public List<Option> options { get; set; }
        public Screen? previousScreen { get; set; }
        public int selectedPosition { get; set; }

        public bool isInitialScreen
        {
            get
            {
                return previousScreen == null;
            }
        }

        // Methods
        public void AddOption(string text, Screen? nextScreen, Action onEnter);
        public void ClearOptions();
        public Option WaitForOption(Action onWait);
        public Option? SelectOption();

    }
}
