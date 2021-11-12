using System;

namespace MethodOverloading
{
    class Program
    {

        static int PlusMethod(int x, int y)
        {
            return x + y;
        }
        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        public static void Main()
        {
            Console.WriteLine(PlusMethod(3, 4));
            Console.WriteLine(PlusMethod(3.454, 6.677));
        }
    }
}