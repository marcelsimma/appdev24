using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Gehege
    {
        public string GehegeName { get; set; }

        public List<Tier> tierList = new List<Tier>();

        public Gehege(string gehegeName, List<Tier> tierList)
        {
            GehegeName = gehegeName;
            this.tierList = tierList;
        }

        public void TierHinzufuegen(Tier tier)
        {
            tierList.Add(tier);
        }
        public void TierEntfernen(Tier tier)
        {
            if (tierList.Contains(tier))
            {
                tierList.Remove(tier);
            }
            else
            {
                Console.WriteLine($"No need to remove {tier} cause it's not in the List anyway.");
            }
        }
        public override string ToString()
        {
            // Somit wird der ListenInhalt wie gewuenscht ausgegeben.
            // Die 'StringBuilder-Klasse wird verwendet, um effizient eine Zeichenkette zu erstellen, die alle Tier-Objekte auflistet.
            StringBuilder tierDetails = new StringBuilder();
            foreach (Tier tier in tierList)
            {
                tierDetails.AppendLine($"|       |- {tier}");
            }

            return String.Format(
            @"|   |- Gehege: {0}
{1}"

        , GehegeName, tierDetails.ToString()
            );
        }
    }
}
