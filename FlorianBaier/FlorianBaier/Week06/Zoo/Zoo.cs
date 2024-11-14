using System;

namespace FlorianBaier.Week06
{
    public class Zoo
    {
        public string Name { get; private set; }
        public int FoundingYear { get; private set; }
        private List<Compound> CompoundList { get; set; }

        public Zoo(string name, int foundingYear)
        {
            Name = name;
            FoundingYear = foundingYear;
            CompoundList = new List<Compound>();
        }

        public void AddCompound(Compound zooCompound)
        {
            CompoundList.Add(zooCompound);
        }

        public void RemoveCompound(Compound zooCompound)
        {
            CompoundList.Remove(zooCompound);
        }

        public void PrintZooStructure()
        {
            Console.WriteLine($"Zoo: {Name}, gegründet {FoundingYear}");

            foreach (var zooCompound in CompoundList)
            {
                zooCompound.PrintCompoundInfo(1);
            }
        }
    }
}