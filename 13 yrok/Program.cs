using System;

/*
 * Ключевое слово break;
 * 
 * Ключевое слово continue;
 */

namespace _13_yrok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 0; i < 100; i++)
            {
                string msg = Console.ReadLine();
                if(msg == "exit")
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */

            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
