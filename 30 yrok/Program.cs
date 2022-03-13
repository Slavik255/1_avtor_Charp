using System;

/*
 * Ключевое слово params
 */

namespace _30_yrok
{
    internal class Program
    {
        /*
        static int Sum(int a, int b)
        {
            return a + b;
        }
        */
        static int Sum(params int[] parametrs)
        {
            int result = 0;

            for (int i = 0; i < parametrs.Length; i++)
            {
                result += parametrs[i];
            }
            return result;
        }
        static void Foo(params object[] parametrs)
        {
            string message = "Тип данных {0}, значение {1}";

            foreach (var item in parametrs)
            {
                Console.WriteLine(message, item.GetType(), item);
            }
        }
        static void Main(string[] args)
        {
            int result = Sum(5, 10, 6);

            Foo("test", 5, "q", 5.89f, true);

            Console.WriteLine(result);
        }
    }
}
