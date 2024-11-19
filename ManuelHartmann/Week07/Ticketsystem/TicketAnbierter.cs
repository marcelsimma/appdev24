using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelHartmann.Week07.Ticketsystem
{
    public class TicketAnbieter
    {
        public Dictionary<Konzert, Bestellungen> GekaufteTickets { get; private set; }

        public TicketAnbieter()
        {
            GekaufteTickets = new Dictionary<Konzert, Bestellungen>();
        }
        public void AusgabeGekaufteTickets()
        {
            Console.WriteLine("\nListe der gekauften Tickets: ");
            Console.WriteLine(new string('-', 30));

            foreach (var eintrag in GekaufteTickets)
            {
                foreach(Personen p in eintrag.Value.Bestellungsdetails)
                {
                    Console.WriteLine($"{p.PersonenName} hat sich erfolgreich n: {p.Ticktanzahl} fuer das Konzert '{p.KonzertName}' gekauft.");
                }
            }
        }
    }
}