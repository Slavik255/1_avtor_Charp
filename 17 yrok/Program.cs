using System;
using System.Linq;

/*
 * Массивы и циклы
 */

namespace _17_yrok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] myArray = { 10, 3, 2, 55 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.ReadLine();
            */

            int[] myArray = { 111, 10, 4, 99, 49, 64, 77, 4, 42, 5 };

            //int result = myArray.Max();
            //int result = myArray.Min();

            // Выводит сумму четных элементов
            Console.WriteLine(myArray.Where(i => i % 2 == 0).Sum());
            // Самое маленькое нечетно число
            Console.WriteLine(myArray.Where(i => i % 2 != 0).Min());
            // Сортировка массива с меньшего к большему
            int[] result = myArray.OrderBy(i => i).ToArray();
            Console.WriteLine(result);
            // Сортировка массива с меньшего к меньшему
            int[] result1 = myArray.OrderByDescending(i => i).ToArray();
            Console.WriteLine(result1);

            Console.ReadLine();
        }
    }
}
