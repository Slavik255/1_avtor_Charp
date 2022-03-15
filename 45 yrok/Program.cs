using System;

/*
 * Ключевое слово static
 * 
 * Статические поля класса
 */

namespace _45_yrok
{
    class MyClass
    {
        public int a;

        public static int b;

        public void SetB(int b)
        {
            MyClass.b = b;
        }

        public void PrintB()
        {
            Console.WriteLine(b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass.b = 5;

            MyClass myClass1 = new MyClass();
            myClass1.SetB(3);

            MyClass myClass2 = new MyClass();
            myClass2.PrintB();
        }
    }
}
