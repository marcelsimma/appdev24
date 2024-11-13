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

            System.Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(p);
            System.Console.WriteLine();
            Console.WriteLine(p2);
            System.Console.WriteLine("-----------------------------------------------------------");

        }

        public static void PrintAuto()
        {
            Auto a = new Auto("Mercedes", 2018, "ABC0012");
            Auto a2 = new Auto("Audi", 2024, "ABC00123");

            System.Console.WriteLine("-----------------------------------------------------------------------------------------");
            System.Console.WriteLine(a);
            System.Console.WriteLine();
            System.Console.WriteLine(a2);
            System.Console.WriteLine("-----------------------------------------------------------------------------------------");
        }

        public static void PrintBank()
        {
            Bank b = new Bank("Sparkasse", 589487, 1.057);
            Bank b2 = new Bank("Raiffeisenbank", 856389, 1.0974);

            System.Console.WriteLine("-----------------------------------------------------------------------------------------");
            System.Console.WriteLine(b);
            System.Console.WriteLine();
            System.Console.WriteLine(b2);
            System.Console.WriteLine("-----------------------------------------------------------------------------------------");
        }

        public static void PrintMotorrad()
        {
            Motorrad m = new Motorrad("Motorrad 1", 5849, 60, "JA");
            Motorrad m2 = new Motorrad($"Motorrad 2", 15673, 25, "NEIN");

            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine(m);
            System.Console.WriteLine();
            System.Console.WriteLine(m2);
            System.Console.WriteLine("--------------------------------------");
        }

        public static void PrintFotoapparat()
        {
            Fotoapparat f = new Fotoapparat(85, 50, "Canon", "EOS 90D", "EF 75-300mm", 18);
            Fotoapparat f2 = new Fotoapparat(90, 60, "Nikon", "D750", "Nikkor 50mm f", 19.3);

            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine(f);
            System.Console.WriteLine();
            System.Console.WriteLine(f2);
            System.Console.WriteLine("------------------------------------");
        }
    }
}