using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //F5(@"C:\");
           // F1();
            //F2();
            F5(@"C:\Users\Home\Desktop\1 курс 1 семестр (2)\1 курс 2 семестр");
        }

        private static void F5(string path)
        {
            try {
                DirectoryInfo directory = new DirectoryInfo(path);
                Console.WriteLine(directory.FullName + ": " + directory.GetFiles().Length);

                DirectoryInfo[] dirs = directory.GetDirectories();
                for (int i = 0; i < dirs.Length; ++i)
                {
                    F5(dirs[i].FullName);
                }
            }
            catch
            {

            }
            finally
            {

            }
        }

        private static void F4()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\work");
            var x = directory.GetDirectories();

            foreach (var t in x)
            {
                Console.WriteLine(t.FullName + ": " + t.GetFiles().Length);
            }
        }

        private static void F3()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Home\Desktop\1 курс 1 семестр (2)\1 курс 2 семестр");
            var x = directory.GetDirectories();

            foreach(DirectoryInfo t in x)
            {
                Console.WriteLine(t.FullName + ": " + t.GetFiles().Length);
            }
        }
        private static void F2()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Home\Desktop\1 курс 1 семестр (2)\1 курс 2 семестр");
            var x = directory.GetDirectories();

            for(int i = 0; i < x.Length; ++i)
            {
                Console.WriteLine(x[i].FullName + ": " + x[i].GetFiles().Length);
            }
        }
        private static void F1()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Home\Desktop\1 курс 1 семестр (2)\1 курс 2 семестр");
            Console.WriteLine(directory.GetFiles().Length);
            Console.WriteLine(directory.GetDirectories().Length);
        }
    }
}