using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace prostchisla
{
    class Program
    {
        static void Main(string[] args)
        {
            F1();
            F2();

        }
        //vvela kommentjjkklkkk
        private static void F2()
        {
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            string line = sr.ReadLine();
            Console.WriteLine(line);

            string[] arr = line.Split(' ');


            int numpr, min = 10000, cnt = 0;


            for (int i = 0; i < arr.Length; ++i)
            {
                numpr = int.Parse(arr[i]);

                for (int j = 2; j <= Math.Sqrt(numpr); ++j)
                {
                    if (numpr % j == 0)
                    {
                        cnt++;
                    }

                }

                if (cnt != 0)
                {
                    if (numpr < min)
                        min = numpr;
                }
            }



            Console.WriteLine(min);

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
