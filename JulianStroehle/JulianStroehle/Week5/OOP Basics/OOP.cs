using System;
using JulianStroehle.Week5.models;
namespace JulianStroehle.Week5
{
    public class OOP
    {
        public static void Start()
        {
            Person person1 = new Person("Nick", 22, 1.75, 80, 40);
            Person person2 = new Person("Anna", 25, 1.60, 57, 50);
            Person person3 = new Person("Kevin", 5, 1.20, 34);
            Console.WriteLine(person1 + "\n" + person2 + "\n" + person3 + "\n");
            Car car1 = new Car("Mercedes", 150, "AMG", 300, 50000);
            Car car2 = new Car("Volkswagen", 100, "Sharan", 240, 220000);
            Console.WriteLine(car1 + " " + car1.Kilometers + "\n" + car2 + " " + car2.Kilometers + "\n");
            car1.driveToWork(person1.DistanceToWork);
            car2.driveToWork(person2.DistanceToWork);
            Console.WriteLine(car1 + " " + car1.Kilometers + "\n" + car2 + " " + car2.Kilometers + "\n");
            Bank bank1 = new Bank("Raiffeisen");
            Bank bank2 = new Bank("Sparkasse");
            Console.WriteLine(bank1 + "\n" + bank2);
        }
    }
}