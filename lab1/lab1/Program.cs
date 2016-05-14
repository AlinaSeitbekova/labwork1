using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {

        static bool Isnotprime(string s)// создаем функциюTIPA BOOL!!IZNACLNO ONA FALSE.POETOMY V MAIN ESLI NOT PRI,ME TO FALSE       
        {
            bool div = false;
            //for (int i = 0; i < args.Length; ++i)//строка состоит из чисел,будет проходить по каждому элементу(число),пока не дойдет до конца строки
            //{
                

                int x = int.Parse(s);// преобразует строковое представление числа в числовое 
                for (int j = 2; j <= Math.Sqrt(x); ++j) //чтобы оценить на простоту-проверяем делители числа от 2 до корня из числа,потому что дальше нет смысла проверять
                {
                    if (x % j == 0)//если есть делители то не простое число 
                    {
                        div = true;
                       // break;// выходит из цикла ,так как уже есть делители

                    }
                    break;
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




           //readalltext readallline
                string text = System.IO.File.ReadAllText(@"C:\Users\Home\Desktop\2task\1прав.txt");

                // Display the file contents to the console. Variable text is a string.
                System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

                // Example #2
                // Read each line of the file into a string array. Each element
                // of the array is one line of the file.
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Home\Source\Repos\labwork1\lab1\lab1\bin\Debug\12.txt");

                // Display the file contents by using a foreach loop.
                System.Console.WriteLine("Contents of WriteLines2.txt = ");
                foreach (string line in lines)
                {
                    // Use a tab to indent each line of the file.
                    Console.WriteLine("\t" + line);
                }

                // Keep the console window open in debug mode.
                Console.WriteLine("Press any key to exit.");
                System.Console.ReadKey();

        }
    }
}


