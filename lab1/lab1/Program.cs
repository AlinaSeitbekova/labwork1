using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {

        static bool Isnotprime(string s)// создаем функцию
        {
            bool div = false;
            //for (int i = 0; i < args.Length; ++i)//строка состоит из чисел,будет проходить по каждому элементу(число),пока не дойдет до конца строки
            //{
                

                int x = int.Parse(s);// преобразует строковое представление числа в числовое 
                for (int j = 2; j <= Math.Sqrt(x); ++j)//чтобы оценить на простоту-проверяем делители числа от 2 до корня из числа,потому что дальше нет смысла проверять
                {
                    if (x % j == 0)//если есть делители то не простое число 
                    {
                        div = true;
                        break;// выходит из цикла ,так как уже есть делители

                    }
                }
                return (div);// true or false
            }
        


       static void Main(string[] args2)// создаем функцию
       {        string str=Console.ReadLine();
                string[] args =str.Split(' ');

                for(int i=0;i<args.Length;i++)
                {
                    if( Isnotprime (args[i]))

                        Console.WriteLine(args[i] + "is not prime");
  

                    else // если есть делители то не простое
                {
                    Console.WriteLine(args[i] + "is prime");
                }

           

                }
        }
    }
}


