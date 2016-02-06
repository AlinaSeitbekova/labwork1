using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            F1();
            F2();
        }

        private static void F2()
        {
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            string line = sr.ReadLine();
            Console.WriteLine(line);

            string[] arr = line.Split(' ');// разделяем строку по разделителю
            int num, max = 0, min = 10000;


            for (int i = 0; i < arr.Length; ++i)
            {
                num = int.Parse(arr[i]);// преобр строковое представление числа в числовое
                if (num < min)
                    min = num;


            }

            Console.WriteLine(min);

            for (int i = 0; i < arr.Length; ++i)
            {
                num = int.Parse(arr[i]);
                if (num > max)
                    max = num;


            }
           

            Console.WriteLine(max);
           




            sr.Close();
            fs.Close();
        }



        private static void F1()
        {
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("1 2 9 4 5 6 8");

            sw.Close();
            fs.Close();
        }
    }
}
