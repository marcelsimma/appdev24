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
            Motorcycle motorcycle = new Motorcycle("Ninja", 350);
            Console.WriteLine(motorcycle);
        }
    }
}