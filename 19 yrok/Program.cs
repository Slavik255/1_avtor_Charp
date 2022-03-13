using System;

/*
 * Вывод двумерного массива
 */

namespace _19_yrok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[,]
            {
                { 2, 45, 12, 51, 51 },
                { 6, 7, 8, 3, 1 },
                { 1, 5, 65, 78, 13 },
                { 3, 6, 151, 5, 65 }
            };

            /*
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
            */

            // Сколько измерений содержит(двумерный, трехмерный и т.д)
            //Console.WriteLine(myArray.Rank);

            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
