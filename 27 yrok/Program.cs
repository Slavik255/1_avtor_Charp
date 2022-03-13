/* 
 * Ключевое слово ref
 * 
 * Передача аргументов по ссылке
 */

namespace _27_yrok
{
    class MyClass
    {
        public int a;
        public double b;
        public float c;
    }
    class Program
    {
        //static void Foo(ref int a)
        static void Foo(MyClass myClass)
        {
            myClass.a = -5;
        }
        static void Bar(int[] myArray)
        {
            //myArray[0] = -5;
            myArray = null;
        }

        static void Main(string[] args)
        {
            /*
            int a = 2;
            Foo(ref a);
            Console.WriteLine(a);
            */

            /*
            MyClass myClass = new MyClass();
            Foo(myClass);
            */

            int[] myArray = { 1, 4, 6 };

            Bar(myArray);
        }
    }
}
