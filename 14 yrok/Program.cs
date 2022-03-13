using System;

/*
 *  Вложенные циклы
 */

namespace _14_yrok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("цикл 1 итерация №: " + i);
                for (int g = 1; g <= 5; g++)
                {
                    Console.WriteLine("\tцикл 2 итерация №: " + g);
                    for (int j = 1; j <= 2; j++)
                    {
                        Console.WriteLine("\t\tцикл 3 итерация №: " + j);
                    }
                }
            }
            Console.ReadLine();
            */

            Console.Write("Введите высоту прямоугольника: ");
            int vusota = int.Parse(Console.ReadLine());

            Console.Write("Введите ширину прямоугольника: ");
            int hurina = int.Parse(Console.ReadLine());

            for (int j = 0; j < vusota; j++)
            {
                for (int i = 0; i < hurina; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
