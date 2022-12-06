using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI
{
    class Arrow
    {
        public int x { get; set; }
        public int y { get; set; }
        public int selectedPosition { get; set; }
        public int margin { get; set; }

        public Arrow(int y, int margin)
        {
            this.x = 0;
            this.y = y;
            this.margin = margin;
            this.selectedPosition = 0;
        }

        public void Draw()
        {
            this.x = (selectedPosition+1) * margin;
            Console.SetCursorPosition(x, y);
            Console.Write("__");
            Console.SetCursorPosition(x, y + 1);
            Console.Write("||");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("||");
            Console.SetCursorPosition(x - 2, y + 3);
            Console.Write("__||__");
            Console.SetCursorPosition(x - 2, y + 4);
            Console.Write("\\ || /");
            Console.SetCursorPosition(x - 1, y + 5);
            Console.Write("\\  /");
            Console.SetCursorPosition(x, y + 6);
            Console.Write("\\/");
            Console.SetCursorPosition(0, 0);
        }


        /*
        public void Erase()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("  ");
            Console.SetCursorPosition(x, y + 1);
            Console.Write("  ");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("  ");
            Console.SetCursorPosition(x - 2, y + 3);
            Console.Write("      ");
            Console.SetCursorPosition(x - 2, y + 4);
            Console.Write("       ");
            Console.SetCursorPosition(x - 1, y + 5);
            Console.Write("     ");
            Console.SetCursorPosition(x, y + 6);
            Console.Write("   ");
            Console.SetCursorPosition(0, 0);
        }
        public void MoveLeft()
        {
            if (x > 0)
            {
                Erase();
                x--;
                Draw();
            }
        }

        public void MoveRight()
        {
            Erase();
            x++;
            Draw();
        }*/
    }
}
