using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Zoo
    {
        public string ZooName { get; set; }
        public string Gruendungsjahr { get; set; }

        public Gehege GehegeName;

        public Zoo(string zooName, string gruendungsjahr, Gehege gehegeName)
        {
            ZooName = zooName;
            Gruendungsjahr = gruendungsjahr;
            GehegeName = gehegeName;
        }
        public override string ToString()
        {
            return

            String.Format(
            @"|- Zoo: {0}, gegruendet {1}"

            , ZooName, Gruendungsjahr);
        }
    }
}
