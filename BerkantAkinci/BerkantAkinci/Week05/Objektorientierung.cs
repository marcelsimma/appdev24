using System;
using System.Net;

namespace BerkantAkinci.Week05
{

    class Objektorientierung
    {
        public static void PrintObjektorientierung()
        {
            PrintPerson();
            System.Console.WriteLine();
            PrintAuto();
            System.Console.WriteLine();
            PrintBank();
            System.Console.WriteLine();
            PrintMotorrad();
            System.Console.WriteLine();
            PrintFotoapparat();
        }

        public static void PrintPerson()
        {
            Person p = new Person("Peter", 21, 178, 72);
            Person p2 = new Person("Nina", 18, 167, 65);

            Console.WriteLine(p);
            Console.WriteLine(p2);
        }

        public static void PrintAuto()
        {
            Auto a = new Auto("Mercedes", "dunkelgrau", 2019, 34678);
            Auto a2 = new Auto("Audi", "silber", 2015, 163993);

            System.Console.WriteLine(a);
            System.Console.WriteLine(a2);
        }

        public static void PrintBank()
        {
            Bank b = new Bank("Sparkasse", 589487, 1.057);
            Bank b2 = new Bank("Raiffeisenbank", 856389, 1.0974);

            System.Console.WriteLine(b);
            System.Console.WriteLine(b2);
        }

        public static void PrintMotorrad()
        {
            Motorrad m = new Motorrad("Motorrad 1", 5849, 60, "JA");
            Motorrad m2 = new Motorrad($"Motorrad 2", 15673, 25, "NEIN");
            System.Console.WriteLine(m);
            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine(m2);
        }

        public static void PrintFotoapparat()
        {
            Fotoapparat f = new Fotoapparat(85, 50, "Canon", "EOS 90D", 18);
            Fotoapparat f2 = new Fotoapparat(90, 60, "Nikon", "D750", 19.3);

            System.Console.WriteLine(f);
            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine(f2);
        }
    }
}