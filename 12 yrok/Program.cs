using System;

/*
 *  Цикл for (2 таба)
 */

namespace _12_yrok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int limit = int.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(i);
            }
            */

            /*
            for (;;)
            {
                Console.WriteLine("for is working");
                System.Threading.Thread.Sleep(300);
                break;
            }
            Console.ReadLine();
            */

            /*
            int i = 0;
            for (; i < 3; i++)
            {
                Console.WriteLine("for_1: " + i);
            }
            for (; i < 5; i++)
            {
                Console.WriteLine("for_2: " + i);
            }
            */

            /*
            for (int i = 0, j = 5; i < 10 & j < 12; i++, j++)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("j: " + j);
            }
            */

            int i = int.Parse(Console.ReadLine());
            for (; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
