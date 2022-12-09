using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI
{
    internal class Topbar
    {
        // Properties
        public List<Option> options;
        public const int TOPBAR_HEIGHT = 7;
        public int selectedPosition;

        // Constructor
        public Topbar() 
        {
            this.options = new List<Option>();
        }


        public void AddOption(string text, Screen? nextScreen, Action onEnter)
        {
            options.Add(new Option(text, nextScreen, onEnter));
        }


        public void Draw(ScreenWithTopbar screen)
        {
            // ---------------- 1º Line ---------------- \\
            Console.Write("*------------------");
            for (int i = 0; i < options.Count + 1; i++)
            {
                Console.Write("------------------");
                
                if (i == options.Count)
                    Console.WriteLine("*");
            }

            // ---------------- 2º Line ---------------- \\
            Console.Write("|  Username        ");
            for (int i = 0; i < options.Count + 1; i++)
            {
                if (i == selectedPosition && screen.menuMode == MenuMode.Up)
                    Console.Write("|     [X]     |   ");
                else
                    Console.Write("|     [ ]     |   ");

                if (i == options.Count)
                    Console.WriteLine("|");
            }

            // ---------------- 3º Line ---------------- \\
            Console.Write("|                  ");
            for (int i = 0; i < options.Count + 1; i++)
            {
                if (i == selectedPosition)
                    Console.Write("|             |   ");
                else
                    Console.Write("|             |   ");

                if (i == options.Count)
                    Console.WriteLine("|");
            }

            // ---------------- 4º Line ---------------- \\
            Console.Write("|  10 €            ");
            for (int i = 0; i < options.Count + 1; i++)
            {
                string name = (i == options.Count) ? "Back" : options[i].text;
                name = name.PadLeft((13 / 2) + (name.Length / 2)).PadRight(12);
                Console.Write("| " + name + "|   ");
                
                if (i == options.Count)
                    Console.WriteLine("|");
            }

            // ---------------- 5º Line ---------------- \\
            Console.Write("|                  ");
            for (int i = 0; i < options.Count + 1; i++)
            {
                if (i == selectedPosition)
                    Console.Write("|             |   ");
                else
                    Console.Write("|             |   ");

                if (i == options.Count)
                    Console.WriteLine("|");
            }

            // ---------------- 6º Line ---------------- \\
            Console.Write("|  10/02/2022      ");
            for (int i = 0; i < options.Count + 1; i++)
            {
                Console.Write("|             |   ");
                
                if (i == options.Count)
                    Console.WriteLine("|");
            }

            // ---------------- 7º Line ---------------- \\
            Console.Write("*------------------");
            for (int i = 0; i < options.Count + 1; i++)
            {
                Console.Write("------------------");
                
                if (i == options.Count)
                    Console.WriteLine("*");
            }
        }

    }
}
