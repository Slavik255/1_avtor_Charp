using System;

/*
 * while
 */

namespace _11_yrok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int count = 0;
            int limit = int.Parse(Console.ReadLine());
            //while (true)
            //while (count < 25)
            while (count < limit)
            {
                count++;
                Console.WriteLine(count);
            }
            */

            int count = 5;

            do
            {
                count++;
                Console.WriteLine(count);
            } while (count < 5);
        }
    }
}
