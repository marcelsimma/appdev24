using System;

namespace BerkantAkinci.Week10
{
    public class Zoo
    {
        public string ZooName;

        public int FoundingYear;

        public List<Enclosure> EnclosureList = new List<Enclosure>();

        public Dictionary<AnimalFood, double> demandList;

        public Zoo(string zooName, int foundingYear)
        {
            ZooName = zooName;
            FoundingYear = foundingYear;
            demandList = new Dictionary<AnimalFood, double>();
        }

        public void PrintAll()
        {
            foreach (Enclosure enclosure in EnclosureList)
            {
                foreach (Animal animalina in enclosure.Animals)
                {
                    /*  foreach (KeyValuePair<AnimalFood, double> animalfoodina in animalina.animalFoodList)
                     {
                         if (demandList.Contains > ) {

                         }
                         demandList.Add(animalfoodina.Key, animalfoodina.Value);
                     } */
                }
            }

            foreach (KeyValuePair<AnimalFood, double> demandlisterina in demandList)
            {

                System.Console.WriteLine($"{demandlisterina.Key}, {demandlisterina.Value}");
            }
        }

        public void AddEnclosure(Enclosure EnclosureName)
        {
            EnclosureList.Add(EnclosureName);
        }

        public void RemoveEnclosure(Enclosure EnclosureName)
        {
            EnclosureList.Remove(EnclosureName);
        }

        public void ZooStructure()
        {
            Console.WriteLine($"\n|---- Zoo: {ZooName}, gegründet {FoundingYear}");
            if (EnclosureList.Count > 0)
            {
                foreach (Enclosure enclosure in EnclosureList)
                {
                    Console.WriteLine("|     |---- Gehege: " + enclosure.EnclosureName);
                    if (enclosure.Animals.Count > 0)
                    {
                        foreach (Animal animals in enclosure.Animals)
                        {
                            Console.WriteLine("|           |---- " + animals.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("|           |---- (leer)");
                    }
                }
            }
            else
            {
                Console.WriteLine("Es sind noch keine Gehege vorhanden!");
            }
        }

        public void CalculateFoodDemand()
        {

        }
    }
}