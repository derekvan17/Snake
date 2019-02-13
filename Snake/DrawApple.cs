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
    class DrawApple
    {
        public static bool appleGot = false;
        public static int appleX;
        public static int appleY;
        public static int appleGotCtr;

        public static void Draw()
        {
            if ((DrawSnake.snakeLength == 0) || appleGot) //randomly place apple
            {
                Random snake = new Random();
                int startX = snake.Next(1, Game.limitX - 1);
                int startY = snake.Next(1, Game.limitY - 1);
                appleX = startX;
                appleY = startY;
                appleGot = false;
            }
            SetCursorPosition(appleX, appleY);
            Write("■");
        }
    }
}
