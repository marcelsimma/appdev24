using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelHartmann.Week06.AbwesenheitslisteExtended
{
    public class Teilnehmer
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public double Stundensatz { get; set; }

        public Teilnehmer(string vorname, string nachname, double stundensatz)
        {
            Vorname = vorname;
            Nachname = nachname;
            Stundensatz = stundensatz;
        }
        public override string ToString()
        {
            return

            String.Format(
            @"

            Vorname: {0}
            Nachname: {1}
            Stundensatz: {2}

            ", Vorname, Nachname, Stundensatz);  
        }
    }
}
