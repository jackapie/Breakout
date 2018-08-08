using Breakout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(GameArea.MaxX, GameArea.MaxY);
            var game = new GameArea();

            Task.Run(() =>
            {
                KeyHandling();
            });

            while (true)
            {
                Console.CursorVisible = false;

                Console.Clear();

                game.PlayTurn();

                switch (currentAction)
                {
                    case "LEFT":
                        game.bat.Move(-1, 0);
                        break;
                    case "RIGHT":
                        game.bat.Move(1, 0);
                        break;
                    case "FIRE":
                        game.FireBall();
                        break;
                }

                currentAction = "";
                foreach (var brick in game.brickArray.Bricks)
                {
                    Console.SetCursorPosition(brick.PositionX, brick.PositionY);

                    Console.Write(brick.Colour.Substring(0, brick.SizeX));
                }

                Console.SetCursorPosition(game.bat.PositionX, game.bat.PositionY);
                Console.Write("Bat");

             
                {
                    Console.SetCursorPosition(game.ball.PositionX, game.ball.PositionY);
                    Console.Write("O");
                }

                System.Threading.Thread.Sleep(300);
            }
        }

        static string currentAction = "";



        static void KeyHandling()
            {


                while (true)
                {
                    var result = Console.ReadKey(true);

                    switch (result.KeyChar)
                    {
                        case 'z':
                        case 'Z':
                            currentAction = "LEFT";
                            break;
                        case 'x':
                        case 'X':
                            currentAction = "RIGHT";
                            break;
                        case ' ':
                            currentAction = "FIRE";
                            break;
                    }
                }
            }
    }
}
