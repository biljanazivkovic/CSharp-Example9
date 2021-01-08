using System;

namespace ex9
{
    class Program
    {
        /* Methods */

        static void MyMethod()
        {
            Console.WriteLine("Hello world!");
        }

        static void MySecondMethod(string fname, int age)
        {
            Console.WriteLine(fname + " Refsnes" + " is " + age);
        }

        static int MyThirdMethod(int x)
        {
            return x + 5;
        }

        static int PlusMethod(int x, int y)
        {
            return x + y;
        }
        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            MyMethod();
            MySecondMethod("Liam", 15);
            MySecondMethod("Jenny", 8);
            MySecondMethod("Anja", 21);
            Console.WriteLine(MyThirdMethod(5));
            Console.WriteLine("Int: " + PlusMethod(8, 3));
            Console.WriteLine("Double: " + PlusMethod(5.2, 6.9));
        }
    }
}
