﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.UI.Dialogs
{
    internal class DialogCounter
    {
        // Constants
        private const int DELAY_TIME = 1000;
        private const int MAX_VALUE = 3;
        
        // Properties
        private int x { get; set; }
        private int y { get; set; }

        // Constructor
        public DialogCounter(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // Methods
        public void Show()
        {
            int value = MAX_VALUE;
            while (value > 0)
            {
                switch (value)
                {
                    case 1:
                        Show1();
                        break;

                    case 2:
                        Show2();
                        break;

                    case 3:
                        Show3();
                        break;

                    default:
                        break;
                }
                value--;
                Thread.Sleep(DELAY_TIME);
            }

            ShowGo();
            Thread.Sleep(DELAY_TIME);

        }

        public void Show1()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("+--------------------------------------+");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("|         The Race starts in...        |");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("|--------------------------------------|");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine("|                                      |");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine("|                                      |");
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine("|                 __                   |");
            Console.SetCursorPosition(x, y + 6);
            Console.WriteLine("|            ...-'  |`.                |");
            Console.SetCursorPosition(x, y + 7);
            Console.WriteLine("|            |      |  |               |");
            Console.SetCursorPosition(x, y + 8);
            Console.WriteLine("|            ....   |  |               |");
            Console.SetCursorPosition(x, y + 9);
            Console.WriteLine("|              -|   |  |               |");
            Console.SetCursorPosition(x, y + 10);
            Console.WriteLine("|               |   |  |               |");
            Console.SetCursorPosition(x, y + 11);
            Console.WriteLine("|            ...'   `--'               |");
            Console.SetCursorPosition(x, y + 12);
            Console.WriteLine("|            |         |`.             |");
            Console.SetCursorPosition(x, y + 13);
            Console.WriteLine("|            ` --------\\ |             |");
            Console.SetCursorPosition(x, y + 14);
            Console.WriteLine("|             `---------'              |");
            Console.SetCursorPosition(x, y + 15);
            Console.WriteLine("|                                      |");
            Console.SetCursorPosition(x, y + 16);
            Console.WriteLine("|                                      |");
            Console.SetCursorPosition(x, y + 17);
            Console.WriteLine("|                                      |");
            Console.SetCursorPosition(x, y + 18);
            Console.WriteLine("+--------------------------------------+");
        }

        public void Show2()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("+--------------------------------------+");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("|         The Race starts in...        |");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("|--------------------------------------|");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine("|                                      |");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine("|                  .-''-.              |");
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine("|                .' .-.  )             |");
            Console.SetCursorPosition(x, y + 6);
            Console.WriteLine("|               / .'  / /              |");
            Console.SetCursorPosition(x, y + 7);
            Console.WriteLine("|              (_/   / /               |");
            Console.SetCursorPosition(x, y + 8);
            Console.WriteLine("|                   / /                |");
            Console.SetCursorPosition(x, y + 9);
            Console.WriteLine("|                  / /                 |");
            Console.SetCursorPosition(x, y + 10);
            Console.WriteLine("|                 . '                  |");
            Console.SetCursorPosition(x, y + 11);
            Console.WriteLine("|                / /    _.-')          |");
            Console.SetCursorPosition(x, y + 12);
            Console.WriteLine("|              .' '  _.'.-''           |");
            Console.SetCursorPosition(x, y + 13);
            Console.WriteLine("|             /  /.-'_.'               |");
            Console.SetCursorPosition(x, y + 14);
            Console.WriteLine("|            /    _.'                  |");
            Console.SetCursorPosition(x, y + 15);
            Console.WriteLine("|           ( _.-'                     |");
            Console.SetCursorPosition(x, y + 16);
            Console.WriteLine("|                                      |");
            Console.SetCursorPosition(x, y + 17);
            Console.WriteLine("|                                      |");
            Console.SetCursorPosition(x, y + 18);
            Console.WriteLine("+--------------------------------------+");
        }

        public void Show3()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("+--------------------------------------+");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("|         The Race starts in...        |");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("|--------------------------------------|");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine("|                                      |");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine("|           ..-'''-.                   |");
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine("|           \\.-'''\\ \\                  |");
            Console.SetCursorPosition(x, y + 6);
            Console.WriteLine("|                  | |                 |");
            Console.SetCursorPosition(x, y + 7);
            Console.WriteLine("|               __/ /                  |");
            Console.SetCursorPosition(x, y + 8);
            Console.WriteLine("|              |_  '.                  |");
            Console.SetCursorPosition(x, y + 9);
            Console.WriteLine("|                 `.  \\                |");
            Console.SetCursorPosition(x, y + 10);
            Console.WriteLine("|                   \\ '.               |");
            Console.SetCursorPosition(x, y + 11);
            Console.WriteLine("|                    , |               |");
            Console.SetCursorPosition(x, y + 12);
            Console.WriteLine("|                    | |               |");
            Console.SetCursorPosition(x, y + 13);
            Console.WriteLine("|                   / ,'               |");
            Console.SetCursorPosition(x, y + 14);
            Console.WriteLine("|           -....--'  /                |");
            Console.SetCursorPosition(x, y + 15);
            Console.WriteLine("|           `.. __..-'                 |");
            Console.SetCursorPosition(x, y + 16);
            Console.WriteLine("|                                      |");
            Console.SetCursorPosition(x, y + 17);
            Console.WriteLine("|                                      |");
            Console.SetCursorPosition(x, y + 18);
            Console.WriteLine("+--------------------------------------+");
        }
    
        public void ShowGo()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("+--------------------------------------+");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("|                 Run!!!               |");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("|--------------------------------------|");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine("|             .-'''-.        ___       |");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine("|            '   _    \\   .'/   \\      |");
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine("|          /   /` '.   \\ / /     \\     |");
            Console.SetCursorPosition(x, y + 6);
            Console.WriteLine("|   .--./).   |     \\  ' | |     |     |");
            Console.SetCursorPosition(x, y + 7);
            Console.WriteLine("|  /.''\\\\ |   '      |  '| |     |     |");
            Console.SetCursorPosition(x, y + 8);
            Console.WriteLine("| | |  | |\\    \\     / / |/`.   .'     |");
            Console.SetCursorPosition(x, y + 9);
            Console.WriteLine("|  \\`-' /  `.   ` ..' /   `.|   |      |");
            Console.SetCursorPosition(x, y + 10);
            Console.WriteLine("|  /(\"'`      '-...-'`     ||___|      |");
            Console.SetCursorPosition(x, y + 11);
            Console.WriteLine("|  \\ '---.                 |/___/      |");
            Console.SetCursorPosition(x, y + 12);
            Console.WriteLine("|  /(\"'`      '-...-'`     ||___|      |");
            Console.SetCursorPosition(x, y + 13);
            Console.WriteLine("|  \\ '---.                 |/___/      |");
            Console.SetCursorPosition(x, y + 14);
            Console.WriteLine("|   /'\"\"'.\\                .'.--.      |");
            Console.SetCursorPosition(x, y + 15);
            Console.WriteLine("|  ||     ||              | |    |     |");
            Console.SetCursorPosition(x, y + 16);
            Console.WriteLine("|  \\'. __//               \\_\\    /     |");
            Console.SetCursorPosition(x, y + 17);
            Console.WriteLine("|   `'---'                 `''--'      |");
            Console.SetCursorPosition(x, y + 18);
            Console.WriteLine("+--------------------------------------+");
        }
    }
}
