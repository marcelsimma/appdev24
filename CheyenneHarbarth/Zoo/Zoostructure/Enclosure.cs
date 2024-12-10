using System;

namespace CheyenneHarbarth.Zoo.Zoostructure
{
    internal class Enclosure
    {
        private string Enclosurename;
        public string _Enclosurename
        {
            get => Enclosurename;
            set => Enclosurename = value;
        }

        public Enclosure(string enclosurename)
        {
            Enclosurename = enclosurename;
        }
    }
}