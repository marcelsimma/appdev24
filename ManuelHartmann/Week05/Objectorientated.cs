using System;

namespace ManuelHartmann.Week05 
{
    public class Objectorientated
    {
        public static void Start()
        {
            Person p = new Person("Peter", 21, 178, 72); // ruft Konstruktor auf
            Person p2 = new Person("Nina", 18, 160, 50);

            Console.WriteLine(p);
            Console.WriteLine(p.ToString());
            Console.WriteLine(p2);

            Person Anna = new Person("Anna", 24, 165, 60);
            Console.WriteLine(Anna);

            Anna.hasABirthday(); // Methodenaufruf ändert Attribut
            Console.WriteLine(Anna);

            Anna._Age++; // schreibe öffentliches Attribut
            Console.WriteLine(Anna);

            // Attribut über getter abfragen:
            Console.WriteLine("Person 2 heißt " + p2.Name);
            Console.WriteLine($"Person 2 ist {p2.Height} cm groß.");

            // Attribut über setter schreiben:
            p2.Height += 2;
            Console.WriteLine($"Person 2 ist {p2.Height} cm groß.");
            Console.WriteLine("---------\n\n\n");

            AufgabeMotorrad();
        }

        public static void AufgabeMotorrad()
        {
            Motorcycle motorcycle1 = new Motorcycle(1000);
            Motorcycle motorcycle2 = new Motorcycle(5000);

            Console.WriteLine("Motorrad 1:");
            motorcycle1.fahre(40);
            Console.WriteLine("Motorrad ist in Bewegung: " + motorcycle1.faehrt());
            motorcycle1.stop();
            Console.WriteLine("Motorrad 1: " + motorcycle2);
            Console.WriteLine("---------");

            Console.WriteLine("Motorrad 2:");
            Console.WriteLine("Motorrad ist in Bewegung: " + motorcycle2.faehrt());
            motorcycle2.fahre(70);
            motorcycle1.stop();
            Console.WriteLine("Motorrad 2: " + motorcycle2);
            Console.WriteLine("---------");
        }
    }
}