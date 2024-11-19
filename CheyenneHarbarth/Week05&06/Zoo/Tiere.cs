using System;

namespace CheyenneHarbarth.Week05.OOP.Zoo
{

    public class Tier
    {
        private string Name;
        public string _Name
        {
            get => Name;
            set => Name = value;
        }

        private string Art;
        public string _Art
        {
            get => Art;
            set => Art = value;
        }

        public Tier(string name, string art)
        {
            Name = name;
            Art = art;
        }

        public override string ToString()
        {
            return String.Format(Art + ", " + Name);
        }
    }
}