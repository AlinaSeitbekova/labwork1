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
           // F1();
            F2();
           
        }

        
        

        private static void F2()
        {
            FileStream fs = new FileStream("inputti4.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("11 9 4 5 6 8 1111");

            sw.Close();
            fs.Close();


            FileStream fss = new FileStream("inputti4.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite); 
            StreamReader sr = new StreamReader(fss);

            string line = sr.ReadLine();
            Console.WriteLine(line);

            string[] arr = line.Split(' ');// разделяем строку по разделителю
            int num, max=0,min = 10000;


            for (int i = 0; i < arr.Length; ++i)
            {
                num = int.Parse(arr[i]);// преобр строковое представление числа в числовое
                if (num < min)
                    min = num;


            }

            Console.WriteLine(min+"eto min");

            for (int i = 0; i < arr.Length; ++i)
            {
                num = int.Parse(arr[i]);
                if (num > max)
                    max = num;


            }
           

            Console.WriteLine(max);
            sr.Close();
            fss.Close();

             
            StreamWriter file = new StreamWriter("inputti10.txt");
        
            file.WriteLine( max);
            file.WriteLine(min);



            file.Close();
           
           
            
           // fss.Close();



            


            //writealltext
            string[] lines = { "First line", "Second line", "Third line" };
            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.  You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllLines(@"C:\Users\Home\Source\Repos\labwork1\lab2.2\lab2.2\bin\Debug\i2.txt", lines);

            
            // Example #2: Write one string to a text file.
            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllText(@"C:\Users\Home\Source\Repos\labwork1\lab2.2\lab2.2\bin\Debug\i3.txt", text);
           /*
            // Example #3: Write only some strings in an array to a file.
            // The using statement automatically flushes AND CLOSES the stream and calls 
            // IDisposable.Dispose on the stream object.
            // NOTE: do not use FileStream for text files because it writes bytes, but StreamWriter
            // encodes the output as text.
            using (System.IO.StreamWriter file2 =
                new System.IO.StreamWriter(@"C:\Users\Home\Source\Repos\labwork1\lab2.2\lab2.2\bin\Debug\i2.txt"))
            {
                foreach (string line3 in lines)
                {
                    // If the line doesn't contain the word 'Second', write the line to the file.
                    if (!line3.Contains("Second"))
                    {
                        file.WriteLine(line3);
                    }
                }
            }
            */
           // Example #4: Append new text to an existing file.
           // The using statement automatically flushes AND CLOSES the stream and calls 
           // IDisposable.Dispose on the stream object.
           using (System.IO.StreamWriter file3 =
               new System.IO.StreamWriter("i.txt"))
           {
               file.WriteLine("Fourth line");
           }
           


        }



       /*private static void F1()
        {
            FileStream fs = new FileStream("inputti.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("1 2 9 4 5 6 8");

            sw.Close();
            fs.Close();
        }
        */
    }
}
