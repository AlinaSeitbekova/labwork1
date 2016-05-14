using Example3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example3
{

    class Program
    {
        public static Thread Progress = new Thread(new ParameterizedThreadStart(MainGame));
        public static Thread Direction = new Thread(new ParameterizedThreadStart(Itstime));
        public static Thread forTimer = new Thread(new ParameterizedThreadStart(timer));
        public static int Level = 1;
        public static int second = 0, minute = 0;
        static void Main(string[] args)
        {

            Game.Init();// game is active .создаем экземпляры фигур,задаем положение,цвет  змейки,еды
            Game.LoadlLevel(1);// включаем первую карту,рисуем стены
            Game.isActive = true;
            Game.snake.Draw();// один раз рисуем
            Game.food.Draw();

            Game.wall.Draw();
            Progress.Start();
            forTimer.Start();
            if (Game.isActive == false)
            {
                Progress.Abort();
                forTimer.Abort();
            }
            /* while (Game.isActive)
             {
                 Game.Draw();// рисуем фигуры
             }
                                 
              //Game.inGame = true; // положение игры активное
             //Panel.PanelStaticDraw();
           //  Game.InitRandom(); // задаем змейке и еде начальные рандомные координаты 

             // PanelTimer.PanelTiming.Start();
            // PanelTimer.time.Change(0, 1000);

             Progress.Start();
             if (Game.inGame == false) Progress.Abort();
 */
        }

        private static void MainGame(object obj)
        {
            Direction.Start();// одновременно второй поток работает

            Console.ReadKey();
            while (Game.isActive)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();

                switch (pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Game.snake.body.Count != 1 && Game.dir == "down") ;
                        else Game.dir = "up";
                        break;
                    case ConsoleKey.DownArrow:
                        if (Game.snake.body.Count > 1 && Game.dir == "up") ;
                        else Game.dir = "down";
                        break;
                    case ConsoleKey.LeftArrow:
                        if (Game.snake.body.Count > 1 && Game.dir == "right") ;
                        else Game.dir = "left";
                        break;
                    case ConsoleKey.RightArrow:
                        if (Game.snake.body.Count > 1 && Game.dir == "left") ;
                        else Game.dir = "right";
                        break;
                    case ConsoleKey.Escape:
                        Game.isActive = false;
                        break;
                    case ConsoleKey.F4:
                        Game.Save2();
                        break;
                    case ConsoleKey.F5:
                        Game.Resume2();
                        break;
                    default:
                        break;
                }
            }
            
        }

        private static void Itstime(object obj) // основы движения змейки
        {
            while (Game.isActive)
            {
                switch (Game.dir)
                {
                    case "right":
                        Move.SnakeToRight();
                        break;
                    case "left":
                        Move.SnakeToLeft();
                        break;
                    case "up":
                        Move.SnakeToUp();
                        break;
                    case "down":
                        Move.SnakeToDown();
                        break;
                }

               Game.Draw();
                Game.DrawSnake();
                
                Thread.Sleep(100);

            }
        }

        public static void timer(object obj)
        {
            while (Game.isActive)
            {
                second++;
                if (second == 60)
                {
                    minute++;
                    second = 0;
                }
               
                Thread.Sleep(1000);
            }
        }

    }
}
