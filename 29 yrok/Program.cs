using System;

/*
 * Ключевое слово in
 * 
 *  ref - только дает поменять данные
 *  out - скомпелируется только если указать переменную в нем
 *  in - только дает смотреть, но ничего не делать с переменной, что ускоряет сам процесс кода
 */

namespace _29_yrok
{
    internal class Program
    {
        static void Foo(in int value)
        {
            //value = 5;
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            int a = 5;

            Foo(a);
        }
    }
}
