using System;

namespace CheyenneHarbarth.Zoo.Zoostructure.Worker
{
    internal class Zookeeper
    {
        private string Workername;
        internal string _Workername
        {
            get => Workername;
            set => Workername = value;
        }

        internal List<Enclosure> ResponsibleEnclosures = new List<Enclosure>();

        internal Zookeeper(string workername, Enclosure enclosure)
        {
            Workername = workername;
            ResponsibleEnclosures.Add(enclosure);
        }
        internal void Work()
        {

        }
    }
}