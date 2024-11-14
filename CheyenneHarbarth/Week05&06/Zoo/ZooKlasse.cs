using System;

namespace CheyenneHarbarth.Week05.OOP.Zoo
{
    public class Zoo
    {
        private string Name;
        public string _Name
        {
            get => Name;
            set => Name = value;
        }

        private int Gründungsjahr;
        public int _Gründungsjahr
        {
            get => Gründungsjahr;
            set => Gründungsjahr = value;
        }

        public Zoo(string name, int gründungsjahr)
        {
            Name = name;
            Gründungsjahr = gründungsjahr;
        }
    }
}