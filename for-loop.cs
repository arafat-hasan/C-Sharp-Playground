using System;

namespace ForLoop
{
    class Program
    {
        public static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            string[] list = { "apple", "banana", "orange", "pineapple" };

            foreach (string i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("Break-Continue");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                if (i == 5) continue;
                Console.WriteLine(i);
            }

            Console.WriteLine();

            for (int i = 1; i < 10; i++)
            {
                if (i % 2 == 0 && i % 3 == 0) break;
                Console.WriteLine(i);
            }
        }
    }

}
