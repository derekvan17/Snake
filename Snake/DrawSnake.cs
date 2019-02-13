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
    class DrawSnake
    {
        public static int snakeLength = 0;
        public static int writeDirection = 0;
        public static int[] snakeBodyX = new int[99];
        public static int[] snakeBodyY = new int[99];

        public static void Init() //places snake randomly
        {
            Random start = new Random();
            int StartX = start.Next(1, Game.limitX - 1);
            int StartY = start.Next(1, Game.limitY - 1);
            Game.currentX = StartX;
            Game.currentY = StartY;
        }            

        public static void Draw() //draws the snake
        {
            Clear();

            //console writes for debug
            //Write("currentX: {0} ", Game.currentX);
            //Write("currentY: {0} ", Game.currentY);
            Write("snakeLength: {0} ", snakeLength);
            Write("snakeBody[{0}],[{1}]", snakeBodyX[snakeLength], snakeBodyY[snakeLength]);
            //

            DrawApple.Draw(); //places apple randomly

            SetCursorPosition(Game.currentX, Game.currentY); //draws the snake's head
            Write("■");

            /* old code where snake body incremented but didn't move veritcally
            for (i = 1; i <= snakeLength; i++)
            {
                Write("■");
            } */
        }
    }
}
