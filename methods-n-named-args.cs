using System;

namespace NamedArgs
{
    class Program
    {
        public static void Main()
        {
            // arguments with the key: value syntax.
            Foo(child3: "adsf", child1: "wrwre", child2: "cbvcb");

            // Named arguments are especially useful when you have multiple parameters with default values,
            // and you only want to specify one of them when you call it
            Bar("child3");
        }

        static void Foo(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }


        static void Bar(string child1 = "Liam", string child2 = "Jenny", string child3 = "John")
        {
            Console.WriteLine(child3);
        }
    }
}