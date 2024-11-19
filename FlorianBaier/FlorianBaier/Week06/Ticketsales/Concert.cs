using System;

namespace FlorianBaier.Week06
{
    public class Concert
    {
        public string ConcertName { get; }
        private Queue<Person> queue;

        public Concert(string concertName)
        {
            ConcertName = concertName;
            queue = new Queue<Person>();
        }

        // Person in die Warteschlange einreihen
        public void Einreihen(Person person)
        {
            queue.Enqueue(person);  // Enqueue fügt die Person ans Ende der Warteschlange an
            Console.WriteLine($"{person.Name} hat sich für das Concert {ConcertName} eingereiht.");
        }

        // Person an der Reihe, um ein Ticket zu kaufen
        public Person TicketKauf()
        {
            if (queue.Count > 0)
            {
                return queue.Dequeue();  // Dequeue entfernt das erste Element (die Person, die an der Reihe ist)
            }
            return null; // Keine Person in der Warteschlange
        }
    }
}