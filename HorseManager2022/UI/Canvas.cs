using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI
{
    internal class Canvas
    {
        public List<Screen> screens { get; set; }

        public Canvas()
        {
            screens = new List<Screen>();
        }

        public void AddScreen(Screen screen)
        {
            screens.Add(screen);
        }

        public void ShowInitialScreen()
        {
            Screen? initialScreen = screens.Find((screen) => screen.isInitialScreen);
            if (initialScreen != null)
                initialScreen.Show();
            else
                throw new Exception("No initial screen found");
        }

    }
}
