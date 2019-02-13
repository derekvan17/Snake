using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using static System.ConsoleKey;
using static Snake.Game;
using static Snake.DrawSnake;



namespace Snake
{
    class HungryForApples
    {
        public static int movement;

        public static void Run()
        {

            movement = 0; //always start going right
            

            while (true) //main game loop
            {
                Thread.Sleep(speed); //takes speed from Game.cs
                
                if (currentX == 0 || currentY == 0 || currentX == limitX || currentY == limitY) //ends game if hits border
                {
                    break;
                }

                if (DrawApple.appleX == currentX && DrawApple.appleY == currentY) //apple got logic
                {
                    DrawApple.appleGot = true;
                    DrawApple.appleGotCtr++;
                    DrawSnake.snakeLength++;
                    snakeBodyX[snakeLength] = currentX;
                    snakeBodyY[snakeLength] = currentY;
                }

                DrawSnake.Draw(); //draws the snake

                if (KeyAvailable)
                {
                    while (true)
                    {
                        ConsoleKeyInfo turn = ReadKey(true);
                        if (turn.Key.Equals(RightArrow) && movement != 1)
                        {
                            movement = 0;
                            //break;
                        }
                        else if (turn.Key.Equals(LeftArrow) && movement != 0)
                        {
                            movement = 1;
                            //break;
                        }
                        else if (turn.Key.Equals(DownArrow) && movement !=3)
                        {
                            movement = 2;
                            //break;
                        }
                        else if (turn.Key.Equals(UpArrow) && movement !=2)
                        {
                            movement = 3;
                            //break;
                        }
                        break;
                        
                    }
                }
                DrawSnake.writeDirection = movement;
                switch (movement)
                {
                    case 0:
                        currentX++;
                        break;
                    case 1:
                        currentX--; 
                        break;
                    case 2:
                        currentY++;
                        break;
                    case 3:
                        currentY--;
                        break;
                }               
            }
        }
    }
}
