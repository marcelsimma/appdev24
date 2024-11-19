using System;

namespace FlorianBaier.Week06
{
    public class Ticketsales
    {
        Ticketprovider eventim = new Ticketprovider();

        Concert lilPeep = new Concert("Lil Peep Concert");
        Concert juiceWrld = new Concert("Juice WRLD Concert");

        Person person1 = new Person("Florian");
        Person person2 = new Person("Melanie");
        Person person3 = new Person("Günther");
        Person person4 = new Person("Margit");

        public void StartSales()
        {
            lilPeep.Einreihen(person1);
            lilPeep.Einreihen(person2);
            juiceWrld.Einreihen(person3);
            juiceWrld.Einreihen(person4);

            SimulateTicketSales(lilPeep);
            SimulateTicketSales(juiceWrld);

            eventim.PrintTickets();
        }

        private void SimulateTicketSales(Concert concert)
        {
            Person person;
            while ((person = concert.TicketPurchase()) != null)
            {
                eventim.BuyTicket(person.Name, concert.ConcertName);
            }
        }
    }

}