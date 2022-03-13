using System;

/*
 * Функции и методы в с#
 * 
 *    Модификаторы тип_возвращаемого_значения название_метода(параметры)
 *    {
 *          тело метода
 *    }
 */

namespace _23_yrok
{
    internal class Program
    {
        static int Sum(int a, int b)
        {
            int result = a + b;

            return result;
        }
        static void Main(string[] args)
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = Sum(a, b);

            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
