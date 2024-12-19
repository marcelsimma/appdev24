using System.Collections.Generic;

namespace JonasWehinger.ZooSimulation
{
    public class Gehege
    {
        public int GehegeID;
        public string Name;
        public List<Tier> Tiere;
        public bool Bearbeitet;

        public Gehege(int gehegeID, string name)
        {
            GehegeID = gehegeID;
            Name = name;
            Tiere = new List<Tier>();
        }

       
        public void FuegeTierHinzu(Tier tier)
        {
            Tiere.Add(tier);
        }
    }
}
