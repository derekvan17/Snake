using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using static System.ConsoleKey;

namespace Snake
{
    class DrawBoard
    {
        public static void Init()
        {           
            WindowHeight = Game.limitY;
            WindowWidth = Game.limitX;
            SetCursorPosition(0, 0); //this is needed for larger to smaller screen changes
        }
    }
}
