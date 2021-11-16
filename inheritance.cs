using System;

class Veihcle
{
    public string brand = "Ford";
    protected void honk()
    {
        Console.WriteLine("Tuut Tuut");


    }
}

class Car : Veihcle
{
    public string modelName = "Mustang";

}

class Program
{
    static void Main()
    {
        Car myCar = new Car();

        myCar.honk();

        Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
}