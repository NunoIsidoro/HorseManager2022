using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI
{
    class Arrow
    {
        public int offsetX { get; set; }
        public int offsetY { get; set; }
        public int selectedPosition { get; set; }
        public int margin { get; set; }

        public Arrow(int margin, int offsetX = 0, int offsetY = 0)
        {
            this.margin = margin;
            this.offsetX = offsetX;
            this.offsetY = offsetY;
            this.selectedPosition = 0;
        }

        public void Draw()
        {
            int x = ((selectedPosition + 1) * margin) + offsetX;
            int y = offsetY;
            
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
            Console.SetCursorPosition(x, y);
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
