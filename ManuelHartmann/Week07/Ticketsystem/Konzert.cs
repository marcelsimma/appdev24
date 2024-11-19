using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ManuelHartmann.Week07.Ticketsystem
{
    public class Konzert
    {
        public string Name { get; private set; }
        public int Ticketkontingent { get; private set; }

        public Konzert(string name, int ticketkontingent)
        {
            Name = name;
            Ticketkontingent = ticketkontingent;
        }

        public string TicketVerkaufen(Bestellungen bestellungsDetails)
        {
            var queueDetails = bestellungsDetails.Bestellungsdetails.Dequeue();
            string person = queueDetails.PersonenName;
            int anzahlTicketsPerson = queueDetails.Ticktanzahl;

            if (bestellungsDetails.Bestellungsdetails.Count > 0 && Ticketkontingent > 0)
            {
                if (Ticketkontingent - anzahlTicketsPerson < 0)
                {
                    Console.WriteLine($"\n{person} wuerden gerne {anzahlTicketsPerson} erwerben, es sind aber lediglich noch {Ticketkontingent} verfuegbar.");
                    Console.WriteLine("Geben Sie einen noch verfuegbares Ticketkontingent ein, um mit dem Erwerb fortzufahren.");
                    string respond = Console.ReadLine();
                    if (int.TryParse(respond, out int tmp) && tmp <= Ticketkontingent)
                    {
                        anzahlTicketsPerson = tmp;
                        Ticketkontingent -= anzahlTicketsPerson;
                        // Es muss keine Person etc. uebergeben werden, weil ohnehin immer der Oberste aus der 'Queue' entfernt wird.
                        Console.WriteLine($"{person} hat sich n:{anzahlTicketsPerson} Ticket(s) fuer das Konzert '{Name}' gekauft.");
                        queueDetails.Ticktanzahl = anzahlTicketsPerson;
                        bestellungsDetails.Bestellungsdetails.Enqueue(queueDetails);
                        return person;
                    }
                    else
                    {
                        Console.WriteLine("Es wurde keine gultiger Betrag eingegeben.");
                    }
                }
                else
                {
                    // Ticketkontingent wird abgebaut und anschließend ueberprueft, ob es sich ausgeht.
                    Ticketkontingent -= anzahlTicketsPerson;
                    // Es muss keine Person etc. uebergeben werden, weil ohnehin immer der Oberste aus der 'Queue' entfernt wird.
                    Console.WriteLine($"{person} hat sich n:{anzahlTicketsPerson} Ticket(s) fuer das Konzert '{Name}' gekauft.");
                    queueDetails.Ticktanzahl = anzahlTicketsPerson;
                    bestellungsDetails.Bestellungsdetails.Enqueue(queueDetails);
                    return person;
                }
            }
            else
            {
                if (bestellungsDetails.Bestellungsdetails.Count != 0)
                {
                    Console.WriteLine($"\n{person} haette noch gerne {anzahlTicketsPerson} erworben, " +
                        $"leider sind bereits alle Tickets fuer das Konzert '{Name}' ausverkauft.");
                }
                else
                {
                    Console.WriteLine($"Es gibt keine Personen mehr in der Warteschlange fuer das Konzert '{Name}'.");
                }
            }
            // Wenn die Bedingung nicht zutrifft. Gib nichts zurueck.
            return null;
        }
    }
}
