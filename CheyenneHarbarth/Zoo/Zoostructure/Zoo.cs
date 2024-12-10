using System;
using System.Dynamic;

namespace CheyenneHarbarth.Zoo.Zoostructure
{
    internal class Zoo
    {
        private string Zooname;
        public string _Zooname
        {
            get => Zooname;
            set => Zooname = value;
        }

        private int FoundingYear;
        public int _FoundingYear
        {
            get => FoundingYear;
            set => FoundingYear = value;
        }
        private List<Enclosure> Zoostructure = new List<Enclosure>();
        public Zoo(string zooname, int foundingyear)
        {
            Zooname = zooname;
            FoundingYear = foundingyear;
        }

        public void AddEnclosure(Enclosure enclosure)
        {
            Zoostructure.Add(enclosure);
        }

        public void RemoveEnclosure(Enclosure enclosure)
        {
            Zoostructure.Remove(enclosure);
        }

        public void PrintZoo()
        {
            Console.WriteLine($"\n|--- Zoo: {Zooname}, gegründet {FoundingYear}");
            if (Zoostructure.Count > 0)
            {
                foreach (Enclosure enclosure in Zoostructure)
                {
                    Console.WriteLine("|    |--- Gehege: " + enclosure._Enclosurename);
                    Console.WriteLine("|         |--- (leer)");
                }
            }
            else
            {
                Console.WriteLine("Es sind noch keine Gehege vorhanden!");
            }
        }
    }
}