using System;

namespace CheyenneHarbarth.Zoo.Zoostructure.Worker
{
    internal class Zookeeper
    {
        private string Keepername;
        internal string _Keepername
        {
            get => Keepername;
            set => Keepername = value;
        }

        internal List<Enclosure> ResponsibleEnclosures = new List<Enclosure>();

        internal Zookeeper(string workername, Enclosure enclosure)
        {
            Keepername = workername;
            ResponsibleEnclosures.Add(enclosure);
        }
        internal void Work()
        {

        }
    }
}