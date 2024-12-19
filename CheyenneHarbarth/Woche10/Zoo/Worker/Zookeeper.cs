using System;
using System.Runtime.CompilerServices;

namespace CheyenneHarbarth.Zoo.Zoostructure.Worker
{
    internal class Zookeeper
    {
        private int _keeperID;
        internal int KeeperID
        {
            get => _keeperID;
            set => _keeperID = value;
        }
        private string _keeperFirstname;
        internal string KeeperFirstname
        {
            get => _keeperFirstname;
            set => _keeperFirstname = value;
        }
        private string _keeperLastname;
        internal string KeeperLastname
        {
            get => _keeperLastname;
            set => _keeperLastname = value;
        }

        internal List<Enclosure> responsibleEnclosures;

        internal Zookeeper(int keeperId, string keeperFirstname, string keeperLastname)
        {
            _keeperID = keeperId;
            _keeperFirstname = keeperFirstname;
            _keeperLastname = keeperLastname;
            responsibleEnclosures = new List<Enclosure>();
        }

        internal Zookeeper()
        {
            _keeperFirstname = Console.ReadLine();
            _keeperLastname = Console.ReadLine();
        }
        internal void PrintResponsibleList()
        {
            Console.WriteLine($"{_keeperFirstname} {_keeperLastname} ist für folgende Gehege zuständig:");
            foreach (Enclosure enclosure in responsibleEnclosures)
            {
                Console.WriteLine($"{enclosure._EnclosureNr,5} | {enclosure._Enclosurename}");
            }
        }
    }
}