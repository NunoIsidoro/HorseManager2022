using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI
{
    static class Canvas
    {
        static public List<Screen> screens { get; set; }

        static Canvas()
        {
            screens = new List<Screen>();
        }

        static public void AddScreen(Screen screen)
        {
            screens.Add(screen);
        }

        static public void ShowInitialScreen()
        {
            Screen? initialScreen = screens.Find((screen) => screen.isInitialScreen);
            if (initialScreen != null)
                initialScreen.Show();
            else
                throw new Exception("No initial screen found");
        }

    }
}
