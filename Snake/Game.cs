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
    class Game
    {
        public static int speed;
        public static string diffSel;
        public static int limitX;
        public static int limitY;
        public static int currentX;
        public static int currentY;

        static void Main(string[] args)
        {
            WriteLine("Welcome to Ssssssnake!");
            begin:
            WriteLine("Select Difficulty:");
            WriteLine("e (Easy), m (Medium), h (Hard), i (Impossible)");

            diffSel = ReadLine();

            if (diffSel == "e" || diffSel == "E")  //difficulty speed
            {
                speed = 200;
                limitX = 75;
                limitY = 50;
            }
            else if (diffSel == "m" || diffSel == "M")
            {
                speed = 100;
                limitX = 75;
                limitY = 50;
            }
            else if (diffSel == "h" || diffSel == "H")
            {
                speed = 50;
                limitX = 50;
                limitY = 25;
            }
            else if (diffSel == "i" || diffSel == "I")
            {
                speed = 25;
                limitX = 50;
                limitY = 25;
            }
            else
            {
                WriteLine("Invalid choice");
                goto begin;
            }

            Clear(); //may be redundant
            DrawBoard.Init();
            DrawSnake.Init();
            DrawSnake.Draw(); //initial drawing of snake and apple
            HungryForApples.Run(); //main loop

            Clear();
            WriteLine("Game Over! Play Again?"); //after main loop exits
            WriteLine("y for yes or any other key to exit");
            string gameOver = ReadLine();
            if (gameOver == "Y" || gameOver == "y")
            {
                Clear();
                diffSel = "";
                DrawSnake.snakeLength = 0;
                DrawApple.appleGotCtr = 0;
                goto begin;
            }
        }
    }
}
