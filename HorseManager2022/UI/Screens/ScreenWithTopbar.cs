using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI
{
    internal class ScreenWithTopbar : Screen
    {
        // Properties
        public MenuMode menuMode;
        public Topbar topbar;

        public override int selectedPosition
        {
            get
            {
                return base.selectedPosition;
            }
            set
            {

                if (menuMode == MenuMode.Down && value > options.Count)
                    value = options.Count;

                if (menuMode == MenuMode.Up && value > topbar.options.Count)
                    value = topbar.options.Count;

                topbar.selectedPosition = value;
                base.selectedPosition = value;
            }
        }

        
        // Constructor
        public ScreenWithTopbar(string title, Topbar topbar, Screen? previousScreen = null)
            : base(title, previousScreen)
        {
            this.topbar = topbar;
            menuMode = MenuMode.Down;
        }


        // Verify option selected is available
        override public Option? SelectOption()
        {
            // Read key
            ConsoleKeyInfo selectedOption = Console.ReadKey();

            // Check for up / down / enter / esc keys
            switch (selectedOption.Key)
            {
                case ConsoleKey.LeftArrow:

                    if (this.selectedPosition > 0)
                        this.selectedPosition--;
                    else
                        this.selectedPosition = this.options.Count - 1;
                    break;

                case ConsoleKey.RightArrow:

                    if (menuMode == MenuMode.Down && this.selectedPosition < this.options.Count - 1)
                        this.selectedPosition++;
                    else
                    {
                        if (menuMode == MenuMode.Up && this.selectedPosition < this.topbar.options.Count)
                            this.selectedPosition++;
                        else
                            this.selectedPosition = 0;
                    }
                    break;

                case ConsoleKey.UpArrow:
                case ConsoleKey.DownArrow:
                    menuMode = (menuMode == MenuMode.Up) ? MenuMode.Down : MenuMode.Up;
                    this.selectedPosition = 0;
                    break;

                case ConsoleKey.Enter:

                    if (menuMode == MenuMode.Down)
                    {
                        if (this.selectedPosition == this.options.Count)
                        {
                            return Option.GetBackOption(this.previousScreen);
                        }
                        else
                            return this.options[this.selectedPosition];
                    }
                    else
                    {

                        if (this.selectedPosition == this.topbar.options.Count)
                        {
                            return Option.GetBackOption(this.previousScreen);
                        }
                        else
                            return this.topbar.options[this.selectedPosition];

                    }

                default:
                    break;
            }

            return null;
        }
    }
}
