using System;
using System.IO.Pipes;

namespace BerkantAkinci.Week06
{

    public class TicketsystemMain
    {
        public static void Start()
        {
            // TicketAnbieter
            TicketAnbieter ticketAnbieter = new TicketAnbieter();
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
}