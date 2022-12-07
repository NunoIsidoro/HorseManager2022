using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI
{
    static class UI
    {
        // Show Load Game Screen
        public static void ShowLoadGameScreen(Screen lastScreen)
        {
            Console.Clear();
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("|             Saves             |");
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("|                               |");
            Console.WriteLine("| No saves found! :(            |");
            Console.WriteLine("|                               |");
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine();
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadLine();

            // Return to previous screenMenu
            lastScreen.Show();
        }

        // Show New Game Screen
        public static void ShowNewGameScreen(Screen nextScreen)
        {
            Console.Clear();
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("|      Choose a save name       |");
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("|                               |");
            Console.WriteLine("| No saves found! :(            |");
            Console.WriteLine("|                               |");
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine();
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadLine();

            // Return to previous screenMenu
            nextScreen.Show();
        }

        // Show Credit Screen
        public static void ShowCreditScreen(Screen lastScreen)
        {
            // Menu
            Console.Clear();
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("|       Game Developed by       |");
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("|                               |");
            Console.WriteLine("| 20115 - André Cerqueira       |");
            Console.WriteLine("|                               |");
            Console.WriteLine("| 20116 - Nuno Fernandes        |");
            Console.WriteLine("|                               |");
            Console.WriteLine("| 25968 - Alexandre Marques     |");
            Console.WriteLine("|                               |");
            Console.WriteLine("| 25977 - Miguel Sousa          |");
            Console.WriteLine("|                               |");
            Console.WriteLine("| 26531 - Gonçalo Gaspar        |");
            Console.WriteLine("|                               |");
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine();
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadLine();

            // Return to previous screenMenu
            lastScreen.Show();
        }

        
        // Show Create new save Screen
        public static void ShowCreateNewSaveScreen(Action<string> onComplete)
        {
            // Menu
            Console.Clear();
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("|     Create new save game      |");
            Console.WriteLine("+-------------------------------+");

            // Get data
            Console.Write("Save name: ");
            string savename = Console.ReadLine();

            onComplete(savename);
        }

        
        /*
        // Show Login Screen
        public static void ShowLoginScreen(ScreenMenu lastScreen)
        {
            // Menu
            Console.Clear();
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("|             Login             |");
            Console.WriteLine("+-------------------------------+");

            // Get data
            Console.Write("Username: ");
            string? username = Console.ReadLine();
            Console.Write("Password: ");
            string? password = Console.ReadLine();

            // Return to previous screenMenu
            lastScreen.Show();
        }

        // Show Register Screen
        public static void ShowRegisterScreen(ScreenMenu lastScreen)
        {
            // Menu
            Console.Clear();
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("|            Register           |");
            Console.WriteLine("+-------------------------------+");

            // Get data
            Console.Write("Username: ");
            string? username = Console.ReadLine();
            Console.Write("Password: ");
            string? password = Console.ReadLine();

            // Return to previous screenMenu
            lastScreen.Show();
        }
        */

    }
}
