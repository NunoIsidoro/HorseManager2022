using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI.Dialogs
{
    internal abstract class Dialog : SelectableObject
    {
        // Constants
        protected const int WIDTH = 40;

        // Properties
        protected int x { get; set; }
        protected int y { get; set; }
        private string title { get; set; }
        protected Screen? previousScreen { get; set; }

        // Constructor
        public Dialog(int x, int y, string title, Screen? previousScreen, List<Option> options)
        {
            this.x = x;
            this.y = y;
            this.title = title;
            this.previousScreen = previousScreen;
            this.options = options;
        }

        // Methods
        abstract public Screen? Show();

        protected void DrawHeader()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("+--------------------------------------+");

            // Write title
            Console.SetCursorPosition(x, y+1);
            Console.Write("| ");
            Console.Write(title.PadLeft((WIDTH / 2) + (title.Length / 2) - 1).PadRight(WIDTH - 11));
            Console.WriteLine(" - [] X |");

            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("|--------------------------------------|");
        }
    }
}
