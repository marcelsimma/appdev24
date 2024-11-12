using System;

namespace BarbaraMarte.Week05
{

    class PrintClass
    {

        public static void PrintPerson()
        {
            Person person1 = new Person("Sandra", 25, 175);
            Person person2 = new Person("Lova", 19, 170);

            Console.WriteLine(person1);
            Console.WriteLine(person2);
        }
        public static void PrintCar()
        {
            Car car = new Car("Toyota", 5, 15000);
            Console.WriteLine(car);
        }
        public static void PrintBank()
        {
            Bank bank = new Bank("Wood", "dark brown", "outside", 520);
            Console.Write(bank);
        }
        public static void PrintMotorcycle()
        {
            Motorcycle motorcycle = new Motorcycle(350);
            Console.WriteLine("Motorcycle 1: ");
            motorcycle.Drive(200);
            Console.WriteLine("The Motorcycle is moving: " + motorcycle.Drives());
            motorcycle.Stop();
            Console.WriteLine("Motorcycle 1: " + motorcycle);
        }
        public static void PrintPhoto()
        {
            Photo photo = new Photo("Professional", "Philips", 2);
            Console.WriteLine(photo);
            photo.Amount += 1;
            Console.WriteLine(photo);

        }
    }
}