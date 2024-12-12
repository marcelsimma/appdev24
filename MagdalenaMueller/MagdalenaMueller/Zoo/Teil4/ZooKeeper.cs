using System;

namespace MagdalenaMueller.Zoo
{
    public class ZooKeeper
    {
        internal string KeeperName;
        internal List<Cage> CagesToKeep;

        public ZooKeeper(string keeperName)
        {
            KeeperName = keeperName;
            CagesToKeep = new List<Cage>();
        }
    }
}