using System;

namespace CheyenneHarbarth.Week05.OOP
{
    class AufgabeMotorrad
    {
        public static void Start()
        {
            Motorrad Suzuki = new Motorrad();
            Suzuki.Name = "Suzuki";
            Suzuki.Kilometerstand = 4389;

            Console.WriteLine(Suzuki.Kilometer());
            Console.WriteLine(Suzuki.FährtDistanz(30));

        }
    }
    class Motorrad
    {
        public int Kilometerstand;

        public string Name;

        public string Kilometer()
        {
            return string.Format($"Motorrad {Name}: {Kilometerstand} km");
        }
        //Methode für die Distanz und berechnet neuen Kilometerstand
        public string FährtDistanz(int Distanz)
        {
            int neuerStand = Kilometerstand + Distanz;
            return string.Format($"Motorrad {Name} fährt {Distanz} km\nMotorrad {Name}: {neuerStand} km");
        }
    }
}