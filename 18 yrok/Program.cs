using System;

/*
 *  Индексы и диапазоны
 *  
 *  Многомерные массивы
 *  
 *  Двумерный прямоугольный массив
 *  
 *  Тип_данных [,] имя_массива;
 */

namespace _18_yrok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] myArray = { 2, 10, 5, 6, 77, 89 };

            Console.WriteLine(myArray[myArray.Length - 1]);
            */

            int[,] myArray = new int[3, 5]
            {
                { 1, 1, 1, 1, 1 },
                { 2, 2, 2, 2, 2 },
                { 3, 3, 3, 3, 3 }
            };
            Console.WriteLine(myArray);
            //myArray[0, 2] = 99;
            //Console.WriteLine(myArray[0,2]);
        }
    }
}
