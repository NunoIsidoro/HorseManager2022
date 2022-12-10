using HorseManager2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI
{
    internal class CalendarScreen : ScreenWithTopbar
    {
        // Properties
        public Calendar calendar;
        private int selectedPage;
        private int selectedYearPage;
        private Month selectedMonthPage => (Month)selectedPage;

        // Constructor
        public CalendarScreen(string title, Topbar topbar, Screen? previousScreen = null) 
            : base(title, topbar, previousScreen)
        {
            // calendar = new Calendar(new Date(3, Month.Summer, 1));
            calendar = new();
            calendar.AddEvent(calendar.events); // Event.GetEventsSave();

            // Add options to calendar (months) all months do nothing, just return to previous screen
            for (int i = 0; i < 4; i++)
                AddOption(Option.GetBackOption(previousScreen));

        }
        
        // Methods
        override public Screen? Show(Player? player)
        {
            // Reset positions / Start at the current month page
            selectedPosition = 0;
            selectedPage = (int)calendar.currentDate.month;
            selectedYearPage = calendar.currentDate.year;

            // Wait for option
            Option? selectedOption = WaitForOption(() =>
            {
                Console.Clear();

                topbar.Draw(this, player);
                calendar.Show(selectedMonthPage, selectedYearPage, selectedPage);
            });

            selectedOption.onEnter();
            return selectedOption.nextScreen;
        }

        
        override public Option? SelectOption()
        {
            // Read key
            ConsoleKeyInfo selectedOption = Console.ReadKey();

            // Check for up / down / enter / esc keys
            switch (selectedOption.Key)
            {
                case ConsoleKey.LeftArrow:

                    if (menuMode == MenuMode.Up) 
                    { 
                        if (selectedPosition > 0)
                            selectedPosition--;
                        else
                            selectedPosition = topbar.options.Count;
                    }

                    if (menuMode == MenuMode.Down)
                    {
                        if (selectedPage > 0)
                            selectedPage--;
                        else
                            selectedPage = options.Count - 1;
                    }
                    
                    break;

                case ConsoleKey.RightArrow:

                    if (menuMode == MenuMode.Up)
                    {
                        if (selectedPosition < topbar.options.Count)
                            selectedPosition++;
                        else
                            selectedPosition = 0;
                    }

                    if (menuMode == MenuMode.Down)
                    {
                        if (selectedPage < options.Count - 1)
                            selectedPage++;
                        else
                            selectedPage = 0;
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
