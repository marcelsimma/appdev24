using System;

namespace OliverBedogg.Week05
{

    public class Objektorientierung
    {
        public static void Start()
        {
            Person p = new Person("Peter", 21, 178, 72); // ruft Konstruktor auf
            Person p2 = new Person("Nina", 18, 178, 72);

            Console.WriteLine(p);
            Console.WriteLine(p.ToString());
            Console.WriteLine(p2);

            Person Anna = new Person("Anna", 24, 165, 60);
            Console.WriteLine(Anna);

            Anna.hasABirthday();
            Console.WriteLine(Anna);
        }
    }
}