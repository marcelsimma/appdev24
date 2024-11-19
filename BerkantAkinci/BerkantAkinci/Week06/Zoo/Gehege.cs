using System;

namespace BerkantAkinci.Week06.Zoo
{
    public class Gehege
    {
        public string _Name;

        public List<Tier> Tiere = new List<Tier>();

        public Gehege(string name)
        {
            _Name = name;
        }

        public void AddTier(Tier _Name)
        {
            Tiere.Add(_Name);
        }

        public void RemoveTier(Tier _Name)
        {
            Tiere.Remove(_Name);
        }
    }
}