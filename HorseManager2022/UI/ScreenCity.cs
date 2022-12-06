using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI
{
    internal class ScreenCity : Screen
    {
        // Constructor
        public ScreenCity(string title, Screen? previousScreen = null) 
            : base(title, previousScreen)
        {
        }

        override public void Show()
        {

            // Wait for option
            Option? selectedOption = WaitForOption(() =>
            {
                Console.Clear();
                Console.WriteLine("                                                                                                        ");
                Console.WriteLine("                                                                                                        ");
                Console.WriteLine("                                                                                                        ");
                Console.WriteLine("                                                                                                        ");
                Console.WriteLine("            			                                                                                      ");
                Console.WriteLine("                           _||____                                                                      ");
                Console.WriteLine("                           /- - - -\\                                                                     ");
                Console.WriteLine("                         /_________\\                                                                    ");
                Console.WriteLine("                         /|         |\\                                                                   ");
                Console.WriteLine("                         |  []  [] |    8888                                                            ");
                Console.WriteLine("       _||_____          |         |   888888      _||______            ____||_                         ");
                Console.WriteLine("      /- - - - \\         |   LOJA  |  88888888    /- - - - -\\          /- - - -\\                        ");
                Console.WriteLine("     /__________\\        |         |    || |     /___________\\        /_________\\                       ");
                Console.WriteLine("    /| [] ____  |\\       |    ____ |    |  |    /| ____  []  |\\      /| [] ____ |\\                      ");
                Console.WriteLine("     |    |. |  |        |    |. | |    | ||     | |. |      |        |    |. | |                       ");
                Console.WriteLine("_____|____|__|__|________|____|__|_|____|__|_____|_|__|______|________|____|__|_|___                    ");
                Console.WriteLine("                                                                                                        ");
                Console.WriteLine("      _||______            _____          _________                                                     ");
                Console.WriteLine("_____/-|| - - -\\__________/- - -\\________/- - - - -\\__________________________________                  ");
                Console.WriteLine("    /___________\\ -      /_______\\      /___________\\               ____                                ");
                Console.WriteLine("   /|           |\\      /|       |\\ -  /|           |\\  -    ____.-\"    \\___    -                       ");
                Console.WriteLine("    |           |        |       |      |           |    ___/              (_____   |    -        -     ");
                Console.WriteLine("    |___________|    -   |_______|   -  |___________|   (                        \"-.!||                 ");
                Console.WriteLine("                                                         \\       ~~          ~     ( !!|||  -  -    -   ");
                Console.WriteLine("  -         -                                     -    - :                         \"-.!!! |             ");
                Console.WriteLine("       -                -          -                      /               ~~            \\___!        -  ");
                Console.WriteLine("                                            -        ____)      ~                          \"-           ");
                Console.WriteLine("      -        -     -                              (     ~~                   ~~            \"-.  -     ");
                Console.WriteLine("                             -                       \\   ~         ~~                      __.-\"        ");
                Console.WriteLine("           -           -                 -            \\_____                    ~~      .-\"             ");
                Console.WriteLine("   -           -               -                            \"-.    ~                   \\        -       ");
                Console.WriteLine("                                                               \"-.______  ~        _____)     -         ");
                Console.WriteLine("                                                                        ´-.____.-´                      ");
                Console.WriteLine();

                // Draw arrow
                Arrow arrow = new Arrow(0, 10);

                arrow.Draw();


                Console.ReadLine();
            });
            
            this.previousScreen?.Show();
        }
        
    }
}
