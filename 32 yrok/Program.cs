using System;

/* 
 * Рекурсия
 * 
 * Методы и стек
 * 
 * Переполнение стека
 */

namespace _32_yrok
{
    internal class Program
    {
        static void Foo(int i)
        {
            Console.WriteLine(i);

            if (i >= 3)
            {
                return;
            }
            i++;
            Foo(i);
        }
        static void Main(string[] args)
        {
            Foo(0);
        }
    }
}
