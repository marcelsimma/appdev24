using System;

namespace FlorianBaier.Week06
{
    public class Ticketprovider
    {
        private Dictionary<string, string> purchasedTickets;

        public Ticketprovider()
        {
            purchasedTickets = new Dictionary<string, string>();
        }

        public void BuyTicket(string personName, string concertName)
        {
            if (!purchasedTickets.ContainsKey(personName))
            {
                purchasedTickets[personName] = concertName;
                Console.WriteLine($"{personName} hat ein Ticket für das Konzert {concertName} gekauft.");
            }
            else
            {
                Console.WriteLine($"{personName} hat bereits ein Ticket.");
            }
        }

        public void PrintTickets()
        {
            Console.WriteLine("\nGekaufte Tickets:");
            foreach (var ticket in purchasedTickets)
            {
                Console.WriteLine($"{ticket.Key} geht zum Konzert {ticket.Value}.");
            }
        }
    }
}