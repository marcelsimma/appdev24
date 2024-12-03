namespace ManuelHartmann.Week07.Ticketsystem
{
    public class Start
    {
        /*

        1. Grundannahmen definieren und Context abstecken
        Grundannahme: Highend Kamera wo Objektiv und Speicherkarte tauschbar sind. 

        2. Klassendiagramm erstellen mit allen Klassen(, Interfaces, Beziehungen, etc.)

        3. Klassen programmieren
        */

        public static void Launch()
        {
            // Erstelle Ticket-Anbieter und Konzerte
            TicketAnbieter ticketAnbieter = new TicketAnbieter();

            Konzert konzert1 = new Konzert("Rock am Ring", 5);
            Konzert konzert2 = new Konzert("Jazz Night", 50);

            // Personen einreihen ( Programmablauf 1)
            Bestellungen bestellung1 = new Bestellungen();
            Bestellungen bestellung2 = new Bestellungen();

            bestellung1.PersonEinreihung(new Personen("Stefan", 2, konzert1.Name));
            bestellung1.PersonEinreihung(new Personen("Hannes", 5, konzert1.Name));
            bestellung1.PersonEinreihung(new Personen("Andreas", 1, konzert1.Name));
            bestellung2.PersonEinreihung(new Personen("Bob", 5, konzert2.Name));
            bestellung2.PersonEinreihung(new Personen("Charlie", 8, konzert2.Name));
            bestellung2.PersonEinreihung(new Personen("Diana", 2, konzert2.Name));
            bestellung2.PersonEinreihung(new Personen("Lucy", 10, konzert2.Name));

            for (int i = 0; i < bestellung1.Bestellungsdetails.Count; i++)
            {
                konzert1.TicketVerkaufen(bestellung1);
            }
            
            konzert2.TicketVerkaufen(bestellung2);

            // Simuliere den Ticketkauf (Programmablauf 2)

            Console.WriteLine();

            // Ticketkauf fuer 'Rock am Ring'
            ticketAnbieter.GekaufteTickets.Add(konzert1, bestellung1);
            ticketAnbieter.GekaufteTickets.Add(konzert2, bestellung2);

            ticketAnbieter.AusgabeGekaufteTickets();
        }
    }
}
