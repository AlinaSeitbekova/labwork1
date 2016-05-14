using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1task
{
    class Program
    {
        static void Main(string[] args)// создаем функцию
        {
            string str = Console.ReadLine();
            string[] args2 = str.Split(' ');

            for(int i=0;i< args2.Length; i++)
            {int x = int.Parse(args2[i]);
            int x2 = (int)Math.Sqrt(x);

                if (x2*x2==x )

                    Console.WriteLine(args2[i] + "is squarw");


                else // если 
                {
                    Console.WriteLine(args2[i] + "notr");
                }
            }
             



            }


        }
        /*

        private static bool nepodhodit(string p)
        {
            bool num = true;

            int x = int.Parse(p);// преобразует строковое представление числа в числовое 

            if ((x % Math.Sqrt(x)) == 0 && x % 5 != 0)//если есть делители И если это не квадрат то оно нам не подходит
            {
                num = false;
                // break;// выходит из цикла ,так как уже есть делители

            }


            return (num);// true or false
        }
         */
    }



//x % Math.Sqrt(x) != 0