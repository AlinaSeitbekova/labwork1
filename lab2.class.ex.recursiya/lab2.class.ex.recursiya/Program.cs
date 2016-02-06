using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace SearchText
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            DirectoryInfo dir = new DirectoryInfo(path);
            Search(dir);
        }
        static void Search(DirectoryInfo dir)
        {
            int cnt = dir.GetFiles().Length;
            Console.WriteLine(cnt + " files are located in " + dir.FullName);
            foreach (DirectoryInfo ndir in dir.GetDirectories())
            {
                Search(ndir);
            }
        }
    }
}
