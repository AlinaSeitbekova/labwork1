﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            F1();
        }
        //функция для проверки числа на простоту
        static bool IsPrime(string s)
        {   //конвертация
            int x = int.Parse(s);
            //счетчик делителей числа, отличных от 1 и самого числа
            int cnt = 0;

            for (int j = 2; j <= Math.Sqrt(x); j++)
            {
                if (x % j == 0)
                {
                    cnt++;
                }
            }

            return cnt == 0 && x != 1;
        }
        //функция, которая вызывается в Main
        private static void F1()
        {
            //открывается input.txt, считывается строка, результат выводится в output.txt
            FileStream fr = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fr);
      
            //строка конвертируется в массив строк
            string line = sr.ReadLine();
            string[] array = line.Split(' ');

            int min = 10000;
            //обрабатывается каждый элемент массива
            for (int i = 0; i < array.Length; i++)
            {   //проверяются только простые числа
                if (IsPrime(array[i]))
                {
                    int currentNumber = int.Parse(array[i]);
                    if (currentNumber < min)
                        min = currentNumber;
                }
            }
             
            //результат выводится в output.txt
            Console.WriteLine("Minimum prime number is " + min);
           
            
             sr.Close();
             fr.Close();
         
       
            StreamWriter file = new StreamWriter("output.txt");
            file.WriteLine( min);
            
           file.Close();
            
            
      
            //файлы закрываются
           
       
        }

    }
}