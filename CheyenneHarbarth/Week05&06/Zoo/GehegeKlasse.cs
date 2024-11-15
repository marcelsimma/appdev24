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
        public List<Tier> Tiere = new List<Tier>();

        public Gehege(string name)
        {
            Name = name;
        }

        public void TierHinzufügen(Tier __name)
        {
            Tiere.Add(__name);
        }

        public void TierWegbringen(Tier __name)
        {
            Tiere.Remove(__name);
        }
    }
}