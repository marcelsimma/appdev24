using System;

namespace SimonJochum.Week05
{
    public class ExerciseOOP
    {
        public static void Start()
        {
            Camera camera1 = new Camera("Canon", "MX1000", 50, 500, 50.0);
            Console.WriteLine(camera1.ToString());
            camera1.Megapixel = 100.5;
            Console.WriteLine(camera1.takePhoto());
            Console.WriteLine(camera1.CameraWhoTookPhoto());
            Console.WriteLine(new string('-', 24));
            camera1.Brand = "Nikon";
            camera1.Model = "ZRY-955";
            camera1.BrennweiteMin = 100;
            camera1.BrennweiteMax = 1000;
            Console.WriteLine(camera1.CameraWhoTookPhoto());
            Console.WriteLine(camera1.ToString());
            Console.WriteLine(camera1.takePhoto());
             camera1.Brand = "Sony";
            camera1.Model = "Snapshot";
            camera1.BrennweiteMin = 100;
            camera1.BrennweiteMax = 1000;

        }

        public static void Exercise()
        {
            Person paul = new Person("Paul", 28, 190, 85, 20000.05);
            Person nina = new Person("Nina", 19, 165, 57, 800.0);
            Car viper = new Car("Dodge", "Viper", 650, 100000, 12345);
            Car polo = new Car("Volkswagen", "Polo", 60, 20000, 123456);
            Bank raiba = new Bank("Kleinkredit", 30000.00, 1000.00, 24);
            Bank sparkasse = new Bank("Kleinkredit", 25000.00, 500.00, 24);
            Console.WriteLine(paul);
            Console.WriteLine(nina);
            Console.WriteLine(nina.HasABirthday(19));
            Console.WriteLine(viper);
            Console.WriteLine(viper.Kilometerstand(500));
            Console.WriteLine(polo);
            Console.WriteLine(raiba);
            Console.WriteLine(sparkasse);
        }

        public static void ExerciseMotorcycle()
        {
            Motorcycle Motorrad1 = new Motorcycle("Motorrad1", 1000);
            Console.WriteLine(Motorrad1.ToString());
            Motorrad1.Faehrt();
            Motorrad1.Fahre(100);
            Console.WriteLine(Motorrad1.ToString());
            Motorrad1.Stop();
            Console.WriteLine(Motorrad1.ToString());
            Console.WriteLine(new string('-', 24));
            Motorcycle Motorrad2 = new Motorcycle("Motorrad2", 10000);
            Console.WriteLine(Motorrad2.ToString());
            Motorrad2.Faehrt();
            Motorrad2.Fahre(79);
            Console.WriteLine(Motorrad2.ToString());
            Motorrad2.Stop();
            Console.WriteLine(Motorrad2.ToString());
            Motorrad2.Faehrt();
            Motorrad2.Fahre(1079);
            Console.WriteLine(Motorrad2.ToString());
            Motorrad2.Stop();
            Console.WriteLine(Motorrad2.ToString());
        }
    }
}