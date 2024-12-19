namespace JonasWehinger.ZooSimulation
{
    public class Tier
    {
        public int TierID;
        public string Name;
        public string Spezies;

        public Tier(int tierID, string name, string spezies)
        {
            TierID = tierID;
            Name = name;
            Spezies = spezies;
        }
    }
}
