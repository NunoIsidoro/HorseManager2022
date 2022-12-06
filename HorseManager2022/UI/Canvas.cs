using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI
{
    static class Canvas
    {
        static public List<ScreenMenu> screens { get; set; }

        static Canvas()
        {
            screens = new List<ScreenMenu>();
        }

        static public void AddScreen(ScreenMenu screen)
        {
            screens.Add(screen);
        }

        static public void ShowInitialScreen()
        {
            ScreenMenu? initialScreen = screens.Find((screen) => screen.isInitialScreen);
            if (initialScreen != null)
                initialScreen.Show();
            else
                throw new Exception("No initial screen found");
        }

    }
}
