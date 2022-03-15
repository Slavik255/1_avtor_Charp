using System;
using System.Reflection;

// Модификаторы доступа public и private, для членов класса

namespace _39_yrok
{
    class Point
    {
        int z = 3;
        public int x = 1;
        private int y = 44;
        private void PrintX()
        {
            Console.WriteLine($"X: {x}");
        }
        public void PrintY()
        {
            Console.WriteLine($"Y: {y}");
        }
        public void PrintPoint()
        {
            PrintX();
            PrintY();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();

            point.PrintPoint();

            var typeInfo = typeof(Point).
                GetFields(BindingFlags.Instance |
                BindingFlags.NonPublic |
                BindingFlags.Public);

            foreach (var item in typeInfo)
            {
                Console.WriteLine($"{item.Name}\t IsPrivate: {item.IsPrivate}\t IsPublic: {item.IsPublic}");
            }
        }
    }
}
