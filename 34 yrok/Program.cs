using System;

/*
 * "Ядерный ганди" и арифматическое переполнение
 */

namespace _34_yrok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = int.MaxValue;
            a = a + 1; //Переполнение через верхную границу
            Console.WriteLine(a);

            int b = int.MinValue;
            b = b - 1; //Переполнение через нижную границу
            Console.WriteLine(b);
            */

            byte aggression = 1;
            byte democracyModifer = 2;

            try
            {
                aggression = checked((byte)(aggression - democracyModifer)); //Сужающее преобразование данных
                Console.WriteLine(aggression);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка переполнения");


            }

            // Так же и в float
            double a = 1.0 / 0.0;
            Console.WriteLine(double.IsInfinity(a)); //output: True бесконечность
            double b = 0.0 / 0.0;
            Console.WriteLine(double.IsInfinity(b)); //output: True не число
            double c = double.MaxValue + double.MaxValue;
            Console.WriteLine(double.IsInfinity(c)); //output: True 
        }
    }
}
