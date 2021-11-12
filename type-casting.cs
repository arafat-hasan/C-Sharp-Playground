using System;

namespace Casting
{
    class Program{
        public static void Main(){
            // Implicit casting is done automatically when passing a smaller size type to a larger size type:
            int myInt = 9;
            double myDouble = myInt;

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            // Explicit casting must be done manually by placing the type in parentheses in front of the value:
            myDouble = 9.78;
            myInt = (int) myDouble;

            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);


            // Type Conversion
            bool myBool = true;
            string myString = "1233.66";

            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToString(myDouble));
            Console.WriteLine(Convert.ToDouble(myString));
            Console.WriteLine(Convert.ToInt32(Convert.ToDouble(myString)));
        }
    }
}