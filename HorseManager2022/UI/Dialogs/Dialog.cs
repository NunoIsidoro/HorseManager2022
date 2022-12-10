using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI.Dialogs
{
    internal abstract class Dialog : ISelectable
    {
        // Constants
        protected const int WIDTH = 40;

        // Properties
        protected int x { get; set; }
        protected int y { get; set; }
        private string title { get; set; }
        protected Screen? previousScreen { get; set; }
        public int selectedPosition { get; set; }
        public List<Option> options { get; set; }

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

        virtual public Screen? Show()
        {
            return null;
        }


        public void ClearOptions() => options.Clear();
        

        public void AddOption(string text, Screen? nextScreen, Action onEnter)
        {
            options.Add(new Option(text, nextScreen, onEnter));
        }


        public Option WaitForOption(Action onWait)
        {
            Option? selectedOption = null;

            do
            {
                onWait();

                // Get option
                selectedOption = SelectOption();

            } while (selectedOption == null);

            return selectedOption;
        }

        
        virtual public Option? SelectOption() => null;


        protected void DrawHeader()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("*--------------------------------------*");

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
