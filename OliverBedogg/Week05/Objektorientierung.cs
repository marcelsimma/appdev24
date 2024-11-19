using System;
using System.IO.Pipes;

namespace OliverBedogg.Week05
{

    public class Objektorientierung
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
            Console.WriteLine("Person 2 heißt " + p2._Name);
            Console.WriteLine($"Person 2 ist {p2.Height} cm groß.");

p2.Height=170;
            p2.getHeight();

            // Attribut über setter schreiben:
            p2.Height += 2;
            Console.WriteLine($"Person 2 ist {p2.Height} cm groß.");
            Console.WriteLine("---------\n\n\n");

            aufgabeMotorrad();
        }

        public static void aufgabeMotorrad()
        {
            Motorrad motorrad1 = new Motorrad(1000);
            Motorrad motorrad2 = new Motorrad(5000);

            Console.WriteLine("Motorrad 1:");
            motorrad1.fahre(40);
            Console.WriteLine("Motorrad ist in Bewegung: " + motorrad1.faehrt());
            motorrad1.stop();
            Console.WriteLine("Motorrad 1: " + motorrad1);
            Console.WriteLine("---------");

            Console.WriteLine("Motorrad 2:");
            Console.WriteLine("Motorrad ist in Bewegung: " + motorrad2.faehrt());
            motorrad2.fahre(70);
            motorrad1.stop();
            Console.WriteLine("Motorrad 2: " + motorrad2);
            Console.WriteLine("---------");
        }
    }
}