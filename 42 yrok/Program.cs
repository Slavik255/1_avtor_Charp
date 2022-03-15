using System;

// Перегрузка конструктора

namespace _42_yrok
{
    class Point
    {
        public Point()
        {
            x = y = 1;
        }
        public Point(int x, int y)
        {
            x = x;
            y = y;
        }
        private int x;
        private int y;

        public void Print()
        {
            Console.WriteLine($"X: {x}\t Y: {y}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.Print();
        }
    }
}
