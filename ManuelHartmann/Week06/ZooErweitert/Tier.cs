using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Tier
    {
        public string TierName { get; set; }
        public string Gattung {  get; set; }

        public Tier(string tierName, string gattung)
        {
            TierName = tierName;
            Gattung = gattung;
        }
        public override string ToString()
        {
            return

            String.Format(
            @"{0}, {1}"

            , TierName, Gattung);
        }
    }
}
