using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            f(@"C:\Users\Home\Desktop\1 курс 1 семестр (2)\1 курс 2 семестр");
            Console.ReadKey();
        }
        public static void f(string path)
        {
            Stack<string> dirs = new Stack<string>(100);
            Console.WriteLine(path + ":" + Directory.GetFiles(path).Length);
            dirs.Push(path);
            while (dirs.Count > 0)
            {
                string currentDir = dirs.Pop();
                string[] subDirs = Directory.GetDirectories(currentDir);
                foreach (string s in subDirs)
                {
                    Console.WriteLine(s + ":" + Directory.GetFiles(s).Length);

                    dirs.Push(s);
                }
            }

        }
    }
}