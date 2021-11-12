using System;

namespace Classes
{
    class Car
    {

        public string model;  // Create a field

        public Car()
        {
            model = "Mustang";
        }
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
        static void Main(string[] args)
        {
            Car Ford = new Car();
            Console.WriteLine(Ford.model);
        }
    }
}