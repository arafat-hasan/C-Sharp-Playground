using System;


namespace Arrays
{
    class Program
    {
        public static void Main()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[3][1]);
            Console.WriteLine(cars.Length);
            Array.Sort(cars);
            Console.WriteLine();
            foreach (string i in cars)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}