using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelHartmann.Week06.AbwesenheitslisteExtended
{
    public class Abwesenheit
    {
        private double _startzeit;
        // Die Startzeit muss groesserGleich 0 sein!
        public double Startzeit
        {
            get => _startzeit;
            set => _startzeit = (value >= 0) ? value : 0;
        }

        private double _endzeit;
        // Die Endzeit muss groesserGleich der Startzeit sein.
        public double Endzeit 
        {
            get => _endzeit;
            set => _endzeit = (value >= Startzeit) ? value : Startzeit;
        }

        public string Fehlgrund { get; set; }
        public bool Entschuldigt { get; set; }

        // Teilnehmer wird zur Abwesenheit hinzugefuegt. Somit koennen die Abwesenheitsdetails eindeutig jedem Teilnehmer zugewissen werden.
        public Teilnehmer Teilnehmer;

        public Abwesenheit(double startzeit, double endzeit, string fehlgrund, bool entschuldigt, Teilnehmer teilnehmer)
        {
            Teilnehmer = teilnehmer;
            Startzeit = startzeit;
            Endzeit = endzeit;
            Fehlgrund = fehlgrund;
            Entschuldigt = entschuldigt;
        }
        public void KostenAbwesenheit()
        {
            double kostenTeilnehmer = CalculateAbwesenheitskosten();
            // Wenn die Krankmeldung nicht entschuldigt ist, fallen die Kosten wirklich an, sonst nicht.
            if (Entschuldigt == false)
            {
                Console.WriteLine($"Angefallene Abwesenheitskosten: {kostenTeilnehmer} EUR.");
            }
            else
            {
                Console.WriteLine($"Die {kostenTeilnehmer} EUR, fallen nicht an, weil der Teilnehmer entschuldigt ist.");
            }
        }
        public double CalculateAbwesenheitskosten()
        {
            double calc = (Endzeit - Startzeit) * 85;   // Stundensatz von 85€
            return Math.Round(calc, 2);                 // Retuniert die angefallenen Kosten seiner Absenz -> (85€/h).
        }
        public override string ToString()
        {
            return

            String.Format(
            @"
            Teilnehmer: {0}
            Startzeit: {1}
            Endzeit: {2}
            Fehlgrund: {3}
            Entschuldigt: {4}

            ", Teilnehmer.ToString(), Startzeit, Endzeit, Fehlgrund, Entschuldigt);
            /* 'Alles in 'Teilnehmer.ToString()' definiert wird in dieser Ausgabe mitausgegeben.
               Somit muss lediglich eine ToString()-Methode aufgerufen werden und man kann die Teilnehmer mit
               den Abwesenheiten in Verbindung setzten.                 */
        }
    }
}
