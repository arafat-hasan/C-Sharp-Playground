using System;

namespace UserInput
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You name is: " + name);
            Console.WriteLine("Your age is: " + age);
        }
    }
}