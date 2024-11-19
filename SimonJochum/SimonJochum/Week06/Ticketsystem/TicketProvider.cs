using System;

namespace SimonJochum.Week06.Ticketsystem
{
    public class TicketProvider
    {
        List<Concert> Concerts = new List<Concert>();
        Dictionary<string, string> TicketEntrys = new Dictionary<string, string>();
        Dictionary<Person, string> TicketEntrys2 = new Dictionary<Person, string>();
        int AmountTicketsAvailable;

        public TicketProvider()
        {

        }

        public void AddConcert(Concert concert)
        {
            Concerts.Add(concert);
        }

        public void QueuePerson(Concert concert, string person)
        {
            concert.BuyingQueue.Enqueue(person);
        }

        public void QueuePersonWithClass(Concert concert, Person person, int amountTicket)
        {
            concert.BuyingQueue2.Enqueue(person);
            concert.BuyingQueue3.Enqueue(amountTicket);
        }

        public void DequeueQueue()
        {
            foreach (Concert concert in Concerts)
            {
                while (concert.BuyingQueue.Count > 0)
                {
                    string person = concert.BuyingQueue.Dequeue();
                    string concertName = concert.Name;
                    TicketEntrys.Add(person, concertName);
                }
            }

            foreach (Concert concert in Concerts)
            {
                AmountTicketsAvailable = 10;
                while (concert.BuyingQueue2.Count > 0)
                {
                    Person person = concert.BuyingQueue2.Dequeue();
                    int amountTickets = concert.BuyingQueue3.Dequeue();
                    string concertName = concert.Name;
                    if (amountTickets <= AmountTicketsAvailable)
                    {
                        TicketEntrys2.Add(person, concertName);
                        AmountTicketsAvailable -= amountTickets;
                    }
                    else
                    {
                        Console.WriteLine($"Für {person} sind leider nicht mehr genügend ({amountTickets}) Tickets für {concertName} zur vorhanden.");
                    }

                }
            }
        }

        public void PrintTicketList()
        {
            foreach (KeyValuePair<string, string> entry in TicketEntrys)
            {
                Console.WriteLine("Name = {0} Konzert = {1}", entry.Key, entry.Value);
            }
            foreach (KeyValuePair<Person, string> entry in TicketEntrys2)
            {
                Console.WriteLine("Name = {0}, Konzert = {1}", entry.Key, entry.Value);
            }
        }
    }
}