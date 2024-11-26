namespace ManuelHartmann.Week06.AbwesenheitslisteExtended
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
            List<Abwesenheit> teilnehmer = new List<Abwesenheit>();
            Teilnehmer teilnehmer1 = new Teilnehmer("Johannes", "Mustermann", 40);
            Abwesenheit abwesenheit1 = new Abwesenheit(8.45, 16.51, "Kopfschmerzen", true, teilnehmer1);
            Teilnehmer teilnehmer2 = new Teilnehmer("Stefan", "Marinovice", 39.5);
            Abwesenheit abwesenheit2 = new Abwesenheit(8.33, 17.02, "Schwaecheanfall", false, teilnehmer2);

            teilnehmer.Add(abwesenheit1);
            teilnehmer.Add(abwesenheit2);

            //Console.WriteLine(abwesenheit1.ToString());

            Console.WriteLine("Datenblatt Abwesenheit: ");
            foreach (Abwesenheit abwesenheits in teilnehmer)
            {
                Console.WriteLine(abwesenheits);
                abwesenheits.KostenAbwesenheit();
                Console.WriteLine(new string('-', 32));
            }
        }
    }
}
