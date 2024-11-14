using System;

namespace CheyenneHarbarth.Week05.OOP.Zoo
{
    public class Gehege
    {
        private string Name;
        public string _Name
        {
            get => Name;
            set => Name = value;
        }

        public Gehege(string name)
        {
            Name = name;
        }
    }
}