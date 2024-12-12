using System;
namespace JulianStroehle.Week10
{
    internal class Zookeeper
    {
        internal int ID;
        internal string FirstName;
        internal string LastName;
        internal List<Enclosure> EnclosureList;
        internal Zookeeper(int id, string firstName, string lastName)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            EnclosureList = new List<Enclosure>();
        }
        internal void AddEnclosure(Enclosure enclosure)
        {
            EnclosureList.Add(enclosure);
        }
    }
}