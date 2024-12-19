using System;

namespace CheyenneHarbarth.Zoo.Zoostructure.Worker
{
    internal class Zookeeper
    {
        private int KeeperID;
        internal int _KeeperID
        {
            get => KeeperID;
            set => KeeperID = value;
        }
        private string KeeperFirstname;
        internal string _KeeperFirstname
        {
            get => KeeperFirstname;
            set => KeeperFirstname = value;
        }
        private string KeeperLastname;
        internal string _KeeperLastname
        {
            get => KeeperLastname;
            set => KeeperLastname = value;
        }

        internal List<Enclosure> ResponsibleEnclosures = new List<Enclosure>();

        internal Zookeeper(int keeperid, string keeperfirstname, string keeperlastname)
        {
            KeeperID = keeperid;
            KeeperFirstname = keeperfirstname;
            KeeperLastname = keeperlastname;
        }
        internal void PrintResponsibleList()
        {
            Console.WriteLine($"{_KeeperFirstname} {_KeeperLastname} ist für folgende Gehege zuständig:");
            foreach (Enclosure enclosure in ResponsibleEnclosures)
            {
                Console.WriteLine($"{enclosure._EnclosureNr,5} | {enclosure._Enclosurename}");
            }
        }
    }
}