using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI
{
    static class Canvas
    {
        public static int option { get; set; }
        
        public static void ShowScreen()
        {
            
        }

        // Show Initial Screen
        public static void ShowInitialScreen(bool isOptionInvalid = false)
        {
            // Menu
            Console.Clear();
            Console.WriteLine("+---------------------------------------+");
            Console.WriteLine("|     Welcome to Horse Manager 2022!    |");
            Console.WriteLine("+---------------------------------------+");
            Console.WriteLine("|                                       |");
            Console.WriteLine("| 1- Login                              |");
            Console.WriteLine("|                                       |");
            Console.WriteLine("| 2- Create account                     |");
            Console.WriteLine("|                                       |");
            Console.WriteLine("| 3- Credits                            |");
            Console.WriteLine("|                                       |");
            Console.WriteLine("| 0- Leave                              |");
            Console.WriteLine("|                                       |");
            Console.WriteLine("+---------------------------------------+");

            Utils.SelectOption(ShowInitialScreen, 3, isOptionInvalid);
        }

        // Show Login Screen
        public static void ShowLoginScreen()
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

        }
    }
}
