using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FarManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Home\Desktop\1 курс 1 семестр (2)\1 курс 2 семестр";
            DirectoryInfo dir = new DirectoryInfo(path);

            List<FileSystemInfo> items = new List<FileSystemInfo>();
            items.AddRange(dir.GetDirectories());
            items.AddRange(dir.GetFiles());

            int index = 0;

            while (true)
            {
                for (int i = 0; i < items.Count; ++i)
                {
                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    if (items[i].GetType() == typeof(FileInfo))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    Console.WriteLine(items[i].Name);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                }


                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (index > 0) index--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (index < items.Count - 1) index++;
                        break;
                    case ConsoleKey.Enter:
                        if (items[index].GetType() == typeof(DirectoryInfo))
                        {
                            path = items[index].FullName;
                            dir = new DirectoryInfo(path);
                            items.Clear();
                            items.AddRange(dir.GetDirectories());
                            items.AddRange(dir.GetFiles());
                            index = 0;
                        }
                        break;
                }
                Console.Clear();
            }
        }
    }
}