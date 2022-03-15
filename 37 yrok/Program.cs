using System;

// Использование enum и можно его парсить
// В документе надо сделать версию 8.0

namespace _37_yrok
{
    class Program
    {
        enum DayOfWeek : byte //Указываем какой тип данных будет
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        enum Color
        {
            White,
            Red,
            Green,
            Blue,
            Orange
        }
        static void Main(string[] args)
        {
            DayOfWeek dayOfWeek = DayOfWeek.Monday;

            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek)));//получаем тип данных

            Console.WriteLine(dayOfWeek);

            Console.WriteLine((int)dayOfWeek); //Приводим DayOfWeek к int

            Console.WriteLine((DayOfWeek)3); // Приводим int к DayOfWeek

            DayOfWeek nextDay = GetNextDay(dayOfWeek);
            Console.WriteLine(nextDay);

            /// <summary>
            /// Получаем следующий день
            /// </summary>
            /// <param name="day"></param>
            /// <returns></returns>
            static DayOfWeek GetNextDay(DayOfWeek day)
            {
                if (day < DayOfWeek.Sunday)
                    return day + 1;

                return DayOfWeek.Monday;
            }


            // Для enum Color что бы вывести весь список enum
            /*
            var values = Enum.GetValues(typeof(Color));
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
            */

            // Парсинг enum
            /*
            string str = Console.ReadLine();
            Color color = (Color)Enum.Parse(typeof(Color), str, ignoreCase: true);
            Console.WriteLine(color);   
            */


            // Простой код
            /*
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;

                int keyCode = (int)key;

                Console.WriteLine($"\tEnum {key} \tKey Code {keyCode}");
                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Вы нажали enter!");
                }
            }
            */
        }
    }
}
