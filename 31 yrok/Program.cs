using System;

/*
 * Обязательные и необязательные параметры
 * 
 * Именные параметры
 */

namespace _31_yrok
{
    internal class Program
    {
        static int Sum(int a, int b, bool enableLogging = false)
        {
            int result = a + b;

            if (enableLogging)
            {
                Console.WriteLine("Значение переменной а = " + a);
                Console.WriteLine("Значение переменной b = " + b);
                Console.WriteLine("Результат сложения = " + result);
            }
            return result;
        }
        static void Main(string[] args)
        {
            int result = Sum(5, 2);
            //int result = Sum(b:2, a:5)
        }
    }
}
