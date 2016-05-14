using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSample1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hello!");
            F1();
        }
        private static void F3()
        {
            Thread t = new Thread(new ParameterizedThreadStart(doit3));
            
            t.Start("1");

            t.IsBackground = true;
            //t.Join();

            string line = Console.ReadLine();
            //t.Abort();

        }

        static int cnt = 0;

        private static void doit3(object obj)
        {
            while (true)
            {
                cnt++;
                Console.SetCursorPosition(10, 10);
                Console.Clear();
                if (cnt == 4)
                {
                    Console.WriteLine("waiting...");
                    cnt = 0;
                }
                else if (cnt == 3) Console.WriteLine("waiting..");
                else if (cnt == 2) Console.WriteLine("waiting.");
                else Console.WriteLine("waiting");
                Thread.Sleep(1000);
            }
        }

        private static void F2()
        {
            Thread t = new Thread(new ParameterizedThreadStart(doit2));
            t.Start("1");//message

            Thread t2 = new Thread(new ParameterizedThreadStart(doit2));
            t2.Start("2");
        }

        private static void doit2(object obj)
        {
            string message = obj as string;

            while (true)
            {
                Console.WriteLine(message + " " + Thread.CurrentThread.ManagedThreadId);
                 Thread.Sleep(1000);

            }
        }

        private static void F1()
        {
            Timer t = new Timer(new TimerCallback(doit));

            t.Change(10000, 1000);

            bool ok = false;

            while (!ok)//
            {
                string line = Console.ReadLine();
                ok = true;
            }
        }

        static void doit(object state)
        {
            Console.WriteLine("waiting...");
        }
    }
}