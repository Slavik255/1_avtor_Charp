using System;

/* 
 * Ключевое слово out
 * 
 * Различия между out и ref
 */

namespace _28_yrok
{
    internal class Program
    {
        static void Foo(ref int value)
        {
            value++;
            Console.WriteLine(value);
        }
        static void Bar(out int value)
        {
            value = 5;
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            int a = 10;
            Foo(ref a);
            Bar(out a);
        }
    }
}
