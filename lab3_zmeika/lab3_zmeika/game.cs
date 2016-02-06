using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3.Models
{
    [Serializable]
    public class Game
    {
        public static bool isActive;
        public static Snake snake;
        public static Food food;
        public static Wall wall;

        public static void Init()
        {
            isActive = true;
            snake = new Snake();// создаем экземпляры
            food = new Food();
            wall = new Wall();

            snake.body.Add(new Point { x = 20, y = 20 });// добавляет объект(положение змеи) к массиву точек змеи
            food.body.Add(new Point { x = 10, y = 20 });

            food.color = ConsoleColor.Green;
            wall.color = ConsoleColor.White;
            snake.color = ConsoleColor.Yellow;

            Console.SetWindowSize(48, 48);
        }
  
        public static void LoadlLevel(int level)
        {
            FileStream fs = new FileStream(string.Format(@"Levels\MapLevel{0}.txt", level), FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);// считывает данные с потока fs и записывает их в sr

            string line;
            int row = -1;
            int col = -1;

            while ((line = sr.ReadLine()) != null)//пока все линии пройдет
            {
                row++;
                col = -1;
                foreach (char c in line)
                {
                    col++;
                    if (c == '#')
                    {
                        wall.body.Add(new Point { x = col, y = row });// добавляет объект к массиву точек(стена) 
                    }
                }
            }

            sr.Close();
            fs.Close();
        }
    /*
       public static void Save()
        {
            wall.Save();
            snake.Save();
            food.Save();
        }

        public static void Resume()
        {
            wall.Resume();
            snake.Resume();
            food.Resume();
        }
    */
        
        public static void Save2()
        {
            wall.Save2();
            snake.Save2();
            food.Save2();
        }

        public static void Resume2()
        {
            wall.Resume2();
            snake.Resume2();
            food.Resume2();
        }

        public static void Draw()
        {
            Console.Clear();
            snake.Draw();
            food.Draw();
            wall.Draw();
            Console.SetCursorPosition(0, 46);
   
            Console.WriteLine("Уровень: {0} ",Program.Level);
            Console.SetCursorPosition(0, 47);
            Console.WriteLine("Cчет: {0} ",Game.snake.body.Count-1);//эта функция считывает размер змейки,соответсвенно если отнять 1 -количество съеденной еды это счет,после перехода на новый уровень он обнуляется
        }
    }
}
