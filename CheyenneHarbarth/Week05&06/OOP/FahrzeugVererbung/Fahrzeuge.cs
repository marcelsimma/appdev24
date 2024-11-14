using System;

namespace CheyenneHarbarth.Week05.OOP.FahrzeugVererbung
{
    public class Auto : Fahrzeug
    {
        public int Kilometer;
        public new void Fahren()
        {
            Console.WriteLine($"Ich fahre jetzt {Kilometer} km!");
            int AnzahlRäder = base.AnzahlderRäder;
            Console.WriteLine(AnzahlRäder);
        }

        public Auto(int kilometer)
        {
            Kilometer = kilometer;
        }
    }

    public class Einrad : Fahrzeug
    {
        public new int AnzahlderRäder = 1;

        public new void Fahren()
        {
            Console.WriteLine("Ich fahre jetzt!");
        }
    }
    public class Motorrad : Fahrzeug
    {
        public new int AnzahlderRäder = 2;

        public new void Fahren()
        {
            Console.WriteLine("Ich fahre jetzt!");
        }
    }
}