using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {

        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; ++i)//строка состоит из чисел,будет проходить по каждому элементу(число),пока не дойдет до конца строки
            {
                int cnt = 0;

                int x = int.Parse(args[i]);// преобразует строковое представление числа в числовое 
                for (int j = 2; j <= Math.Sqrt(x); ++j)//чтобы оценить на простоту-проверяем делители числа от 2 до корня из числа,потому что дальше нет смысла проверять
                {
                    if (x % j == 0)//если есть делители то не простое число 
                    {
                        cnt++;
                    }
                }



                if (cnt != 0)// если есть делители то не простое
                {
                    Console.WriteLine(x + "is not prime");
                }

                else// если нет делителей то простое
                {
                    Console.WriteLine(x + "is prime");
                }
                //  Console.ReadKey();

            }
        }
    }
}


