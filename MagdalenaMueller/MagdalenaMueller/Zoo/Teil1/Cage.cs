using System;
using System.Runtime.CompilerServices;
using Org.BouncyCastle.Bcpg;

namespace MagdalenaMueller.Zoo
{
    public class Cage
    {
        internal string CageName;
        public static Dictionary<Cage, List<Animal>> listOfCages = new Dictionary<Cage, List<Animal>>();

        public Cage(string cageName)
        {
            CageName = cageName;
        }

        public static void AddCage(string cageName, Zoo zoo)
        {
            Cage cage = new Cage(cageName);
            listOfCages.Add(cage, new List<Animal>());
        }
        public static void RemoveCage(string cageName, Zoo zoo)
        {
            bool wasCageFound = false;
            string? removeCage = cageName;

            foreach (var cage in listOfCages.Keys.ToList())
            {
                if (cage.CageName == removeCage)
                {
                    listOfCages.Remove(cage);
                    wasCageFound = true;
                }
            }
            if (wasCageFound == false)
            {
                Console.WriteLine("Kein Gehege mit diesem Namen gefunden");
            }
        }
        public static void AddAnimal(string cageOfAddedAnimal, Animal animal)
        {
            bool wasCageFound = false;

            foreach (var cage in listOfCages.Keys)
            {
                if (cageOfAddedAnimal == cage.CageName)
                {
                    wasCageFound = true;
                    listOfCages[cage].Add(animal);
                }
            }

            if (wasCageFound == false)
            {
                Console.WriteLine("Kein Gehege mit name " + cageOfAddedAnimal + " gefunden");
            }
        }
        public static void RemoveAnimal(Animal animal)
        {
            foreach (var cageEntry in listOfCages)
            {
                if (cageEntry.Value.Contains(animal))
                {
                    cageEntry.Value.Remove(animal);

                    break; 
                }
            }
        }

    }
}