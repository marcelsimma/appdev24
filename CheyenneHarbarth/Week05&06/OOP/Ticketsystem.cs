using System;

namespace CheyenneHarbarth.Week05.OOP
{
    public class TicketsystemMain
    {
        public static void Start()
        {
            // TicketAnbieter
            Ticketanbieter ticketAnbieter = new Ticketanbieter();
            // Konzerte
            Konzert frequency = new Konzert("Frequency");
            Konzert openair = new Konzert("Open Air");

            Console.WriteLine("\nEinreihung mehrerer Personen -------------");
            // Personen zu Konzert-Warteschlangen
            frequency.queue.Enqueue("Peter");
            frequency.queue.Enqueue("Paul");
            frequency.queue.Enqueue("Ines");

            ticketAnbieter.plusKonzert(frequency);
            ticketAnbieter.plusKonzert(openair);

            Console.WriteLine("\nTicketkauf und speichern der gekauften Tickets -------------");
            ticketAnbieter.warteschlangeAbarbeiten();
            // ticketAnbieter.printTickets();

        }
    }
    public class Ticketanbieter
    {
        // Konzerte
        List<Konzert> _konzerte = new List<Konzert>();

        // gekauften Tickets Personenname, Konzertname
        Dictionary<string, string> _tickets = new Dictionary<string, string>();

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
    public class Konzert
    {
        public string _name;
        // Warteschlange
        public Queue<string> queue = new Queue<string>();

        public Konzert(string name)
        {
            _name = name;
        }
    }

}
