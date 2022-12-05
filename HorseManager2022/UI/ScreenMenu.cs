﻿using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI
{
    internal class ScreenMenu
    {
        // Properties
        public string title { get; set; }
        public List<Option> options;
        public bool isInitialScreen;


        public ScreenMenu(string title, bool isInitialScreen = false)
        {
            this.title = title;
            options = new List<Option>();
            this.isInitialScreen = isInitialScreen;
        }


        public void AddOption(Option option)
        {
            options.Add(option);
        }


        public void Show()
        {
            // Variables
            Option? selectedOption = null;
            bool isOptionInvalid = false;
            string title = this.title;
            title = title.PadLeft((38 / 2) + (title.Length / 2)).PadRight(37);

            // Wait for option
            do
            {
                // Display Title
                Console.Clear();
                Console.WriteLine("+---------------------------------------+");
                Console.WriteLine("| " + title + " |");
                Console.WriteLine("+---------------------------------------+");
                Console.WriteLine("|                                       |");

                // Display Options
                for (int i = 0; i < this.options.Count; i++)
                {
                    string text = this.options[i].text.PadRight(34, ' ');
                    Console.WriteLine("| " + (i + 1) + " - " + text + "|");
                    Console.WriteLine("|                                       |");
                }

                // Display Back / Exit Option
                if (this.isInitialScreen)
                    Console.WriteLine("| 0 - Exit                              |");
                else
                    Console.WriteLine("| 0 - Back                              |");

                // Close Menu
                Console.WriteLine("|                                       |");
                Console.WriteLine("+---------------------------------------+");

                // Get option
                selectedOption = SelectOption(ref isOptionInvalid);

            } while (selectedOption == null);

            selectedOption.onEnter(this);

        }
        
        
        // Verify option selected is available
        public Option? SelectOption(ref bool isOptionInvalid)
        {
            int selectedOption = -1;

            if (isOptionInvalid)
                Console.WriteLine("Invalid option. Please, try again.\n");
            Console.Write("Select an option: ");

            try
            {
                selectedOption = Convert.ToInt32(Console.ReadLine());
                
                if (selectedOption < 0 || selectedOption > this.options.Count)
                    throw new Exception();
            }
            catch
            {
                isOptionInvalid = true;
                return null;
            }
            
            return GetOption(selectedOption);
        }

        
        public Option? GetOption(int selectedOption)
        {
            try
            {
                return this.options[selectedOption - 1];
            }
            catch
            {
                if (selectedOption == 0 && this.isInitialScreen)
                    return Option.GetExitOption();
                else
                    return null;

                /*
                 
                else if (selectedOption == 0)
                    return null;
                 */
            }
        }
    }
}
