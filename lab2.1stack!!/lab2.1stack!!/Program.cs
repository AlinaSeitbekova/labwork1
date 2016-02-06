using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{   //поиск файлов в каждой папке
    class Program
    {
        static void Main(string[] args)
        {      
             F1(@"C:\Users\Home\Desktop\1 курс 1 семестр (2)\1 курс 2 семестр");
        }

        private static void F1(string path)
        {   //создается стэк
            Stack<string> dirs = new Stack<string>(100);
            //кол-во файлов в начальной папке
            Console.WriteLine(path + ": " + Directory.GetFiles(path).Length);
            //добавляется путь начальной папки
            dirs.Push(path);
            //выполняется цикл, пока стэк не станет пустым
            while (dirs.Count > 0)
            {   //берется путь последней добавленной папки
                string lastDir = dirs.Pop();
                //в массив добавляются пути подпапок в текущей папке 
                string[] subDirs = Directory.GetDirectories(lastDir);

                foreach (string pat in subDirs)//для каждой папки из подпапок
                {   // выводит кол-во файлов в каждой папке
                    Console.WriteLine(pat + ": " + Directory.GetFiles(pat).Length);
                    //пути папок добавляются в стэк
                    dirs.Push(pat);
                }
            }
        }

        
        
        //рекурсивный метод
        private static void F4(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            Console.WriteLine(directory.FullName + ": " + directory.GetFiles().Length);
            DirectoryInfo[] directories = directory.GetDirectories();
            for (int i = 0; i < directories.Length; i++)
            {
                F4(directories[i].FullName);
            }
        }
}
}

        
