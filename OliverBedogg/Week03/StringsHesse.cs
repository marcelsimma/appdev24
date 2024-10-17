using System;

namespace OliverBedogg.Week02
{

    public class StringsHesse
    {
        public static void Start()
        {
            // Aufgaben:
            SucheHesse();
            BuchstabenZaehlen();
            // Verwende den Text in getText()
        }

        public static void SucheHesse()
        {
            /* Aufgabe: Suche nach "Hesse" --------
            Wie oft kommt das Wort "Hesse" in folgendem Text vor? An welchen Stellen?
            Gib die Anzahl und die Stellen aus.

            Ansatz:
            textString.IndexOf(...) liefert den ersten Index zurück
            Der Methode IndexOf können weitere Parameter wie der Startindex für die Suche übergeben werden.
            https://learn.microsoft.com/de-de/dotnet/api/system.string.indexof?view=net-8.0
            */
        }

        public static void BuchstabenZaehlen()
        {
            /* Aufgabe: Buchstaben zählen -------
            In der folgenden Aufgabe sollen alle Buchstaben und Zeichen eines Texts gezählt werden.
            Um die einzelnen Buchstaben und Zeichen zu zählen soll ein int[] verwendet werden.
            Gib am Schluss die Anzahl der einzelnen Zeichen (zb. A,a,ä,.) aus.

            Ansatz:
            Es kann die String-Methode IndexOf oder auch IndexOfAny verwendet werden
            textString.IndexOfAny(...)
            https://learn.microsoft.com/de-de/dotnet/api/system.string.indexofany?view=net-8.0
            */
        }

        public static string getText()
        {
            return "Geboren am 2.7.1877 in Calw, gestorben am 9.8.1962 in Montagnola. Thematik der frühen Romane: Widerstand gegen konventionelle Normen, geistige Unruhe und Zweifel, Gegensatz zwischen kontemplativer und „sinnlicher“ Lebensweise," +
                " Verhältnis des Künstlers zum Leben. Nach dem Ersten Weltkrieg wird Hesses Werk von der Psychoanalyse (Demian) als auch von orientalischer Meditation (Siddhartha) beeinflusst; vor allem im „Steppenwolf“ übt Hesse vehemente Kritik" +
                " an der technokratischen Zivilisation und den Widersprüchen der bürgerlichen Gesellschaft, an einer Welt der Maschinen und der Kommerzialisierung. Der Altersroman Glasperlenspiel gestaltet das neue Ideal eines „Reichs des Geistes und der Seele“ als Gegenentwurf zur Geistverneinung des Nationalsozialismus. Hesses Werke waren mehrmals Identifikationstexte der gegen Gesellschaftszwänge aufbegehrenden jungen Generation: nach dem Ersten (Demian) und dem Zweiten Weltkrieg (Glasperlenspiel) und im Jugendprotest der späten sechziger Jahre. Vor dem Hintergrund des Vietnam-Kriegs kam es von den USA aus zu einer Hesse-Renaissance. Der Romantiker, Mystiker und Anti-Bürger Hesse wurde zum Klassiker der Hippiekultur, die sich in seinen Texten wiederfand (Steppenwolf).\r\n\r\nHesse über sich selbst: „Ich habe mich im Lauf meiner Entwicklung den Problemen der Zeit nicht entzogen und nie, wie meine politischen Kritiker meinen, im elfenbeinernen Turme gelebt – aber das erste und brennendste meiner Probleme war nie der Staat, die Gesellschaft oder die Kirche, sondern der einzelne Mensch, die Persönlichkeit, das einmalige, nicht normierte Individuum“ (1951).\r\nIn den USA und Japan der meistgelesene europäische Autor seit hundert Jahren; Millionenauflage seiner Bücher, Übersetzungen in 40 Sprachen.";
        }
    }
}