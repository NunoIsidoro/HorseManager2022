using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI
{
    static class Utils
    {
        // Verify option selected is available
        public static void SelectOption(Action<bool> screen, int optionMax, bool isOptionInvalid = false)
        {
            if (isOptionInvalid)
                Console.WriteLine("Invalid option. Please, try again.\n");

            try
            {
                Console.Write("Select an option: ");
                Canvas.option = Convert.ToInt32(Console.ReadLine());
                
                if (Canvas.option < 0 || Canvas.option > optionMax)
                    throw new Exception();
            }
            catch
            {
                screen.Invoke(true);
            }
        }
    }
}
