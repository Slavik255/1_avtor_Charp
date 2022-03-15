using System;
using System.Collections.Generic;

// Ключевое слово var
// Неявно типизированные локальные переменные

namespace _36_yrok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 5;

            // Упрощает написание кода и изменение его
            //Dictionary<int, string> t = new Dictionary<int, string>();
            var t = new Dictionary<int, string>();

            Console.WriteLine(t.GetType());
        }
    }
}
