using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketsystem
{
    public class Personen
    {
        public string PersonenName { get; private set; }
        public int Ticktanzahl { get; set; }

        public string KonzertName;

        public Personen(string personenName, int ticktanzahl, string konzert)
        {
            PersonenName = personenName;
            Ticktanzahl = ticktanzahl;
            KonzertName = konzert;
        }
    }
}
