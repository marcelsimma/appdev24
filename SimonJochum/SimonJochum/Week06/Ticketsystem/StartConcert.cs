using System;

namespace SimonJochum.Week06.Ticketsystem
{
    public class StartConcert
    {
        static TicketProvider Eventim = new TicketProvider();
        static Concert FreiWild = new Concert("Frei.Wild");
        static Concert ViniVici = new Concert("Vini Vici");
        static Concert SzeneOA = new Concert("Szene Open Air");
        public static void Start()
        {
            bool again = false;
            do
            {

                Console.WriteLine("Welches Konzert möchtest du besuchen?\n1: Frei.Wild\n2: Vini Vici\n3: Szene Open Air");
                string? choice = Console.ReadLine();
                Console.WriteLine("Wie ist der Name der Person? (Vorname Nachname)");
                string? fullName = Console.ReadLine();
                Console.WriteLine($"Wieviele Tickets möchte {fullName} kaufen?");
                int amountTickets = Convert.ToInt32(Console.ReadLine());
                Person PersonToAdd = new Person(fullName);
                do
                {
                    if (choice == "1")
                    {
                        Eventim.QueuePersonWithClass(FreiWild, PersonToAdd, amountTickets);
                        break;
                    }
                    else if (choice == "2")
                    {
                        Eventim.QueuePersonWithClass(ViniVici, PersonToAdd, amountTickets);
                        break;
                    }
                    else if (choice == "3")
                    {
                        Eventim.QueuePersonWithClass(SzeneOA, PersonToAdd, amountTickets);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Bitte gib ein gültiges Konzert an.");
                    }
                }
                while (choice == "1" || choice == "2" || choice == "3");
                Console.WriteLine("Möchtest du noch eine Person hinzufügen? (Ja/Nein)");
                string askAgain = Console.ReadLine().ToLower();
                if (askAgain == "ja")
                {
                    again = true;
                }
                else 
                again = false;

            }
            while (again);
            // Eventim.QueuePerson(FreiWild, "Simon");
            // Eventim.QueuePerson(FreiWild, "David");
            // Eventim.QueuePerson(FreiWild, "Alex");
            // Eventim.QueuePerson(FreiWild, "Nina");
            // Eventim.QueuePerson(FreiWild, "Verena");
            // Eventim.QueuePerson(ViniVici, "Jonas");
            // Eventim.QueuePerson(ViniVici, "Fabian");
            // Eventim.QueuePerson(ViniVici, "Pascal");
            // Eventim.QueuePerson(ViniVici, "Carola");
            // Eventim.QueuePerson(ViniVici, "Elena");
            Eventim.AddConcert(FreiWild);
            Eventim.AddConcert(ViniVici);
            Eventim.AddConcert(SzeneOA);
            Eventim.DequeueQueue();
            Eventim.PrintTicketList();
        }
    }
}