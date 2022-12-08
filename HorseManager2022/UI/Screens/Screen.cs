using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI
{
    internal class Screen : ISelectable
    {
        // Properties
        public string title;
        public List<Option> options { get; set; }
        public Screen? previousScreen { get; set; }
        public virtual int selectedPosition { get; set; }
        
        public bool isInitialScreen
        {
            get
            {
                return previousScreen == null;
            }
        }


        // Constructor
        public Screen(string title, Screen? previousScreen = null)
        {
            this.title = title;
            options = new List<Option>();
            this.previousScreen = previousScreen;

            Canvas.AddScreen(this);
        }


        public void AddOption(Option option)
        {
            options.Add(option);
        }


        public void ClearOptions()
        {
            options.Clear();
        }
        

        virtual public void Show()
        { 
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
        
        
        // Verify option selected is available
        virtual public Option? SelectOption()
        {
            // Read key
            // Console.Write("Select an option: ");
            ConsoleKeyInfo selectedOption = Console.ReadKey();

            // Check for up / down / enter / esc keys
            switch (selectedOption.Key)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    if (this.selectedPosition > 0)
                        this.selectedPosition--;
                    else
                        this.selectedPosition = this.options.Count;
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    if (this.selectedPosition < this.options.Count)
                        this.selectedPosition++;
                    else
                        this.selectedPosition = 0;
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.Enter:
                    if (this.selectedPosition == this.options.Count)
                    {
                        return Option.GetBackOption();
                    }
                    else
                        return this.options[this.selectedPosition];
                case ConsoleKey.LeftArrow:
                    return Option.GetBackOption();
                default:
                    break;
            }

            return null;
        }
    }
}
