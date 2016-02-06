using Example3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
   // [Serializable]
    class Program
    {
        public static int Level = 1;
        static void Main(string[] args)
        {    
           
            Game.Init();// game is active .создаем экземпляры фигур,задаем положение,цвет  змейки,еды
            Game.LoadlLevel(1);// включаем первую карту,рисуем стены

            while (Game.isActive)
            {
                Game.Draw();// рисуем фигуры

                ConsoleKeyInfo pressedKey = Console.ReadKey();// змейка двигается по 4 клавишам
                switch (pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        Game.snake.Move(0, -1);// dx.dv для змейки
                        break;
                    case ConsoleKey.DownArrow:
                        Game.snake.Move(0, 1);
                        break;
                    case ConsoleKey.LeftArrow:
                        Game.snake.Move(-1, 0);
                        break;
                    case ConsoleKey.RightArrow:
                        Game.snake.Move(1, 0);
                        break;
                    case ConsoleKey.Escape:
                        Game.isActive = false;
                        break;
                    /*
                    case ConsoleKey.F2:
                        Game.Save();
                        break;
                    case ConsoleKey.F3:
                        Game.Resume();
                        break;
                     */
                   
                    case ConsoleKey.F4:
                        Game.Save2();// бинарный формат
                        break;
                    case ConsoleKey.F5:
                        Game.Resume2();// бинарный формат
                        break;
                    
                }
            }

            Console.ReadKey();



        }
    }
}
