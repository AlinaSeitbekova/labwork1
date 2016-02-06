using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3.Models
{
    public class Snake : Drawer// наследует методы ,свойства от класса drawer
    {
        public int MyProperty { get; set; }

        public Snake()
        {
            sign = 'o';
        }

        public void Move(int dx, int dy)
        {

            for (int i = body.Count - 1; i > 0; --i)
            {
                body[i].x = body[i - 1].x;// части змейки следовали по стопам головы змейки,голова змейки 0 элемент,шея 1 и тд,сначала присвоет,потом голова меняет положение
                body[i].y = body[i - 1].y;
            }

            body[0].x = body[0].x + dx;
            body[0].y = body[0].y + dy;

            //ЗАДАНИЕ1 проверка-змея попала ли на стену или за границу поля

            for (int i = 0; i < Game.wall.body.Count; ++i)
            {
                //ЗАДАНИЕ1!. проверка границ поля
                // нужно чтобы змея не выходила за границы окна консоли размером 48*48 ,поэтому рассмотрела 4 случая (для каждой стороны квадрата окна консоли)

                if (Game.snake.body[0].x == Game.wall.body[i].x &&
       Game.snake.body[0].y == Game.wall.body[i].y || Game.snake.body[0].y < Console.WindowHeight - 47 || Game.snake.body[0].y > Console.WindowHeight - 1 || Game.snake.body[0].x > Console.WindowHeight - 1 || Game.snake.body[0].x < Console.WindowHeight - 47)
                {
                    Console.Clear();
                    Console.SetCursorPosition(20, 10);
                    Console.WriteLine("Game over!");
                    Game.isActive = false;
                }
            }


                if (Game.snake.body[0].x == Game.food.body[0].x &&
                   Game.snake.body[0].y == Game.food.body[0].y)//если змейка попала на еду,координаты совпадут
                {
                    score++;
                   

                    Game.snake.body.Add(new Point
                    {
                        x = Game.food.body[0].x,
                        y = Game.food.body[0].y
                    });
// ЗАДАНИЕ4! индикатор очков и уровня 

                    Console.WriteLine(score);
                    Console.WriteLine("вы на {0} уровне", cnt);


                    //ЗАДАНИЕ 3!
                    // если змейка съела  4 еды,то новый уровень
                    if (score%4==0)
                    {
                        cnt++;// показывает уровень игры,карты
                        
                        Game.snake.body.Clear(); // уменьшаем змейку так как прошли новый уровень
                        Game.food.body.Clear();
                        Game.LoadlLevel(cnt);// открываем  новую карту

                        Game.snake.body.Add(new Point { x = 3, y = 3 });
                        Game.food.body.Add(new Point { x = 28, y = 1 });

                    }
                    else// если просто игра идет дальше,пока не съела 4 еды,проверяем нахождение еды на безоп-сть
                    {                                    

                        // ЗАДАНИЕ 2!.создаем еду на новом месте

                        Game.food.body[0].x = new Random().Next(0, 47);// диапозон чисел из которых можно выбрать координату для новой еды
                        Game.food.body[0].y = new Random().Next(0, 47);
                        // проверяем не попала ли новая еда на стену и змеейку
                        for (int k = 0; k < Game.snake.body.Count; ++k)
                            for (int j = 0; j < Game.wall.body.Count; ++j)
                            {
                                if ((Game.food.body[0].x == Game.wall.body[j].x &&
                       Game.food.body[0].y == Game.wall.body[j].y) || Game.food.body[0].x == Game.snake.body[k].x && Game.food.body[0].y == Game.snake.body[k].y)

                                {  Game.food.body[0].x = new Random().Next(0, 47);// диапозон чисел из которых можно выбрать координату для новой еды
                                Game.food.body[0].y = new Random().Next(0, 47);
                                }
                             }

    
                }


            }
        }
    }
}
