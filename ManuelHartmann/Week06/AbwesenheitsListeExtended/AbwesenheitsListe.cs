using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ManuelHartmann.Week06.AbwesenheitslisteExtended
{
    public class AbwesenheitsListe
    {
        /* Handelt sich auch nur um eine uebergeordnete Liste! 
           Es muss auch zuerst ein Objekt erzeugt werden, um damit arbeiten zu koennen. Wie z.B. bei den Teilnehmern koennen auch hier
           *n Listen erzeugt werden. KursListe, ArbeitsListe etc. (Jede kann dann auch auf die Methoden zugreiffen.                                 */
        List<Abwesenheit> abwesenheitsListe = new List<Abwesenheit>();

        // Abwesenheit mit dem Objekt des 'neu erstellten Abwesenden' kann zur AbwesenheitsListe hinzugefuegt werden.
        public void AbwesenheitHinzufuegen(Abwesenheit abwesenheit)
        {
            abwesenheitsListe.Add(abwesenheit);
        }
        // Das erstellte Objekt des Abwesenden kann in der Abweseneheitsliste ueberprueft werden.
        public void AbwesenheitPruefen(Abwesenheit abwesenheit)
        {
            if (abwesenheitsListe.Contains(abwesenheit))
            {
                Console.WriteLine($"Der {abwesenheit} ist bereits in der AbwesenheitsListe erfasst.");
            }
            else
            {
                Console.WriteLine($"Der {abwesenheit} ist noch nicht in der AbwesenheitsListe erfasst.");
            }
        }
        public void AbwesenheitEntfernen(Abwesenheit abwesenheit)
        {
            if (abwesenheitsListe != null && abwesenheitsListe.Contains(abwesenheit))
            {
                abwesenheitsListe.Remove(abwesenheit);
            }
            else
            {
                Console.WriteLine("Der zu entfernende Abwesende ist nicht in der Liste.");
            }
        }
    }
}
