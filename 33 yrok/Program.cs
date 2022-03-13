using System;

// Преобразование и приведение примитивных типов в С#

namespace _33_yrok
{
    internal class Program
    {
        static void Foo(float value)
        {
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            int a = 5;
            Foo(a);

            //double a = 5.3;
            //float b = (float)a;
        }
    }
}
