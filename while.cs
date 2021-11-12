using System;

namespace WhileLoop
{
    class Program
    {
        public static void Main()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("Do-While executing");
            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);

        }
    }
}