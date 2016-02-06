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

            //ЗАДАНИЕ1 проверка-змея попала ли на стену

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
                    Console.WriteLine(score);

                    Game.snake.body.Add(new Point
                    {
                        x = Game.food.body[0].x,
                        y = Game.food.body[0].y
                    });



                    //ЗАДАНИЕ 3!
                    // если змейка съела  4 еды,то новый уровень
                    if (score==4 || score==8)
                    {
                        Game.snake.body.Clear(); // уменьшаем змейку так как прошли новый уровень
                        Game.LoadlLevel(2);// открываем  новую карту

                        Game.snake.body.Add(new Point { x = 3, y = 3 });
                        Game.food.body.Add(new Point { x = 28, y = 5 });

                    }
                    else
                    {





                        /*          
                       
                                      //Game.snake.body.Add(new Point


                                      Game.snake.body[0].x = new Random().Next(0, 47);
                                      Game.snake.body[0].y = new Random().Next(0, 47);
                                      // создаем безопасное место для змейки во втором уровне
                                      for (int i = 0; i < Game.wall.body.Count; ++i)
                                      {

                                          if (Game.snake.body[0].x == Game.wall.body[i].x &&
                                 Game.snake.body[0].y == Game.wall.body[i].y)
                                          { }
                                          else
                                          {
                                              Game.snake.body[0].x = new Random().Next(0, 47);
                                              Game.snake.body[0].y = new Random().Next(0, 47); 
                                          }
                                      }
                                      //создаем безоп место для еды на новом уровне
                                      Game.food.body[0].x = new Random().Next(0, 47);// диапозон чисел из которых можно выбрать координату для новой еды
                                      Game.food.body[0].y = new Random().Next(0, 47);




                                  }





                  */

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

                    //

/*                    // проверка-змея попала ли на стену

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
                  
 */
                }


            }
        }
    }
}
