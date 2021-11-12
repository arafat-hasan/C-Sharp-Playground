using System;

namespace Strings
{
    class Program
    {
        public static void Main()
        {
            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());

            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);

            name = string.Concat(firstName, lastName);
            Console.WriteLine(name);

            name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);

            Console.WriteLine(txt[0]);
            Console.WriteLine(txt.IndexOf("l"));

        }
    }
}