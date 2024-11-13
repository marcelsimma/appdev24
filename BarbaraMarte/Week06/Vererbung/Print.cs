using System;

namespace BarbaraMarte.Week06.Vererbung;

public class Print
{
    public static void Start()
    {
        Car car = new Car("Yaris", "Toyota", "Naive Blue", 5, 20);
        Console.WriteLine(car);

        Motorcycle motorcycle = new Motorcycle("Virago", "Yamaha", "black", 10, 2);
        motorcycle.wheels = 2;
        motorcycle.maxSpeed = 200;
        Console.WriteLine(motorcycle);
    }
}