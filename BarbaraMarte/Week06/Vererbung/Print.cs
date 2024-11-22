using System;

namespace BarbaraMarte.Week06.Vererbung;

public class Print
{
    public static void Start()
    {
        Car car = new Car(5, "Yaris", "Toyota", "Naive Blue", 5, 50, 49, 4.8);
        car.Drive(10);
        Console.WriteLine(car);
        Console.WriteLine(car);
        car.Drive(5);
        Console.WriteLine(car);
        Console.WriteLine(car);
        Console.WriteLine();
        Motorcycle motorcycle = new Motorcycle(1, "Virago", "Yamaha", "black", 10, 50, 23, 3.8);
        motorcycle.Tire = 2;
        motorcycle.maxSpeed = 200;
        Console.WriteLine(motorcycle);

        // Unicycle unicycle = new Unicycle();
        // Console.WriteLine(unicycle);
    }
}