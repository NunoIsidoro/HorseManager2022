using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI
{
    internal abstract class SelectionableObject : ISelectable
    {
        // Properties
        public List<Option> options { get; set; }
        virtual public int selectedPosition { get; set; }

        
        // Constructor
        public SelectionableObject()
        {
            options = new List<Option>();
        }

        
        // Methods
        public void AddOption(string text, Screen? nextScreen, Action onEnter) =>
            options.Add(new Option(text, nextScreen, onEnter));

        
        public void AddOption(Option option) => options.Add(option);
        

        public void ClearOptions() => options.Clear();

        
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

        
        // Select option from the list
        abstract public Option? SelectOption();
    }

}
