using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            F3();
        }

        private static void F3()
        {
            bool ok = true;

            while (ok)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();

                switch (pressedKey.Key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("left");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("right");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("down");
                        break;
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("up");
                        break;
                    case ConsoleKey.Escape:
                        ok = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }

        }

        private static void F2()
        {

            while (true)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    Console.WriteLine("left");
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    Console.WriteLine("right");
                }
                else if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    Console.WriteLine("up");
                }
                else if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    Console.WriteLine("down");
                }
                else if (pressedKey.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }

        }

        private static void F1()
        {
            ConsoleKeyInfo pressedKey = Console.ReadKey();
            Console.WriteLine(pressedKey.KeyChar);
        }
    }
}