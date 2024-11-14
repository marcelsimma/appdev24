using System;
using OliverBedogg.Week05;

namespace OliverBedogg.Week06
{
    public class TicketAnbieter
    {
        // Konzerte
        List<Konzert> _konzerte = new List<Konzert>();

        // gekauften Tickets Personenname, Konzertname
        Dictionary<string, string> _tickets = new Dictionary<string, string>();

        public TicketAnbieter()
        {

        }

        public void plusKonzert(Konzert konzert)
        {
            _konzerte.Add(konzert);
        }

        public void personEinreihen(Konzert konzert, string person)
        {
            //option Ticketkontingent prüfen
        }

        public void warteschlangeAbarbeiten()
        {
            // alle Konzerte durchgehen
            foreach (Konzert konzert in _konzerte)
            {
                // für jedes Konzert die Warteschlange abarbeiten
                while (konzert.queue.Count > 0)
                {
                    string person = konzert.queue.Dequeue();
                    string konzertname = konzert._name;

                    //option Ticketkontingent prüfen

                    // ticketkauf speichern
                    _tickets.Add(person, konzertname);
                }
            }
        }
    }
}