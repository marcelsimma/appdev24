using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ManuelHartmann.Week07.Ticketsystem
{
    public class Bestellungen
    {
        public Queue<Personen> Bestellungsdetails { get; set; }

        public Bestellungen()
        {
            Bestellungsdetails = new Queue<Personen>();
        }
        public void PersonEinreihung(Personen personen)
        {
            Bestellungsdetails.Enqueue(personen);
            Console.WriteLine($"{personen.PersonenName} hat sich mit n:{personen.Ticktanzahl} " +
    $"Tickets fuer das Konzert '{personen.KonzertName}' eingereiht.");
        }
    }
}
