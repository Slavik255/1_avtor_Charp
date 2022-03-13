using System;

/*
 * Переменные в шарпе
 * 
 * Объявление (создание) переменных
 * 
 * Инициализация переменных 
 * 
 * Присвоение значений переменной (помещение данных)
 * 
 * Ввод данных в консоль
 */

namespace _2_yrok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Тип_данных имя_переменной;

            int a;
            a = 0;

            int b = 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

            string umia;
            // Мы ввели данные и нажали энтер, после чего сюда записались данные
            umia = Console.ReadLine();
            // Сдесь используем запись с обычным выводом
            Console.WriteLine("Привет " + umia + "!!!");
        }
    }
}
