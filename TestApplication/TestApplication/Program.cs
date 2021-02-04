using System;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            MyMath(ref a, ref b);
            Console.WriteLine("Value of a: "+a);
            Console.WriteLine("Value of b: "+b);
        }

        static void MyMath(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
        }
    }
}
