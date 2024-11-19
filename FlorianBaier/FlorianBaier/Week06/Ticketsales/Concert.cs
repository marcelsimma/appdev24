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

        public void Einreihen(Person person)
        {
            queue.Enqueue(person);
            Console.WriteLine($"{person.Name} hat sich für das Konzert {ConcertName} eingereiht.");
        }

        public Person TicketPurchase()
        {
            if (queue.Count > 0)
            {
                return queue.Dequeue();
            }
            return null;
        }
    }
}