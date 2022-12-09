using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI
{
    internal class ScreenHouse : ScreenWithTopbar
    {
        // Properties
        public BoardMenu boardMenu;

        // Constructor
        public ScreenHouse(string title, Topbar topbar, Screen? previousScreen = null)
            : base(title, topbar, previousScreen)
        {
            boardMenu = new BoardMenu("Board Menu", this, previousScreen);
        }

        override public Screen? Show()
        {
            // Wait for option
            Option? selectedOption = WaitForOption(() =>
            {
                Console.Clear();
                
                topbar.Draw(this);
                DrawHouse();

                boardMenu.Show();

            });

            selectedOption.onEnter();
            return selectedOption.nextScreen;

        }


        public void DrawHouse() 
        {
            Console.WriteLine("                                                                                                   ");
            Console.WriteLine("   ___________________________________________________________________________________________");
            Console.WriteLine("  /        |             .-.                                                         |        \\       ");
            Console.WriteLine(" /         |       .-.   | |-.                                                       |         \\      ");
            Console.WriteLine("|          |       | |.-.|*| |                             .-.     .-.               |          |     ");
            Console.WriteLine("|          |       |º|| || |.|<\\                     .-.   | |-.   | |-.             |          |     ");
            Console.WriteLine("|          |       | ||-|| | | \\                     | |.-.|*| |.-.|*| |             |          |     ");
            Console.WriteLine("|          |       |º||-||+|.|  \\                    |º|| || |.|| || |.|             |          |     ");
            Console.WriteLine("|          |       | || || | |   \\>                  | ||-|| | ||-||+|.|             |          |     ");
            Console.WriteLine("|          |     \"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"                |º||-||+|.||-||+|.|             |          |     ");
            Console.WriteLine("|          |                                         | || || | || || | |             |          |     ");
            Console.WriteLine("|          |                                        \"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"            |          |     ");
            Console.WriteLine("|          |                                                                         |          |     ");
            Console.WriteLine("|          |                                               ,,,,,                     |          |     ");
            Console.WriteLine("|          |                                              (wwwww)                    |          |     ");
            Console.WriteLine("|          |                                             .` 0 0 `.                   |          |     ");
            Console.WriteLine("|          |                                              |  ^  |                    |          |     ");
            Console.WriteLine("|          |                                              _\\`-´/_                    |          |     ");
            Console.WriteLine("|          |                                          _.-´\\_____/`-.                 |          |     ");
            Console.WriteLine("|          |                                         /  _ \\     / _ \\                |          |     ");
            Console.WriteLine("|          |_______________                          | | | \\   / | | |               |          |     ");
            Console.WriteLine("|         /               /|                         | | |  \\ /  | | |               |          |     ");
            Console.WriteLine("|        /               / |                         | \\ |  N.B  | | |               |          |     ");
            Console.WriteLine("|       /               /  |                          \\ \\|_______| | |               |          |     ");
            Console.WriteLine("|      /               /   |                           \\_|_|_|_|_| |_|               |          |     ");
        }
    }
}
