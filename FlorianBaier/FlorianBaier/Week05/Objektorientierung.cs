using System;


namespace FlorianBaier.Week05
{

    public class Objektorientierung
    {
        public static void StartPerson()
        {
            Person flo = new Person("Florian", 26, 180, 73); // ruft Konstruktor auf
            Person jonas = new Person("Jonas", 21, 182, 75);

            Console.WriteLine(flo);
            Console.WriteLine(jonas);
            jonas.hasABirthDay();
            Console.WriteLine(jonas);
        }

        public static void StartCar()
        {
            Car audi = new Car("Audi", "A4", 189, 55435.99, 87903.4);

            Console.WriteLine(audi);
            audi.DriveDistance();
            audi.DriveDistance();
            audi.DriveDistance();
            audi.DriveDistance();
            Console.WriteLine(audi);
        }

        public static void StartBank(){
            Bank dornbirnerSparkasse = new Bank("Dornbirner Sparkasse", 123456789, 315);

            Console.WriteLine(dornbirnerSparkasse);
        }
    }
}