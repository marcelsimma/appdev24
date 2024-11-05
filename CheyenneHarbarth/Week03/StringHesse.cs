using System;
using System.Diagnostics.Metrics;

namespace CheyenneHarbarth.Week03
{

    class StringHesse
    {

        public static void Start()
        {

            /*Aufgabe: Suche "Hesse"
            Wie oft kommt das Wort "Hesse" in folgendem Text vor?
            Gib die Anzahl und die Stellen aus.*/

            string textString = getText();
            string searchFor = "Hesse";             //könnte auch mit Console.ReadLine ein gewünschter Begriff speichern.

            int startPos = textString.IndexOf(searchFor, 0);       //mit .IndexOf kann ich den Index, also die Position, eines Worts, Buchstaben, Zahl etc.
            Console.WriteLine("First Index: " + startPos);
            Console.WriteLine("-------------------");

            int count = 0;
            int pos = -1;                                               //-1 müssen wir schreiben, weil er sonst wegen dem +1 nicht bei 0 sondern bei 1 beginnt zu zählen, so könnte er ein Wort gleich am Anfang übersehen
            do
            {
                pos = textString.IndexOf(searchFor, pos + 1);            //ohne +1 würde er immer an derselben Stelle feststecken, weil er immer dort beginnt zu zählen
                Console.WriteLine("Count: " + count + "Next Index: " + pos);
                count++;

            } while (pos >= 0 && count < 10);

            Console.WriteLine("Anzahl: " + (count - 1));              //warum -1, weil er dank do-while immer mind. 1x durchläuft

        }

        public static void Uppercase()
        {
            string Text = getText();
            string searchFor = "Hesse";


        }
        public static void BuchstabenZaehlenMarcel()
        {
            string text = "Hallo, wie geht es dir?";

            char[] textArray = text.ToCharArray();

            int[] Counter = new int[65536];             //warum diese hohe zahl? das ist die größe einer tabelle in der alle Zeichen abgespeichert sind

            foreach (char c in textArray)
            {              //wir iterrieren hier jeden Char im Text, mit dem int-Array wird der Char in Dezimal umgerechnet und gleichzeitig steigt der Counter für den jeweiligen Char
                Counter[c]++;
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (Counter[i] > 0)
                {
                    Console.WriteLine("Der Buchstabe " + (char)i + " hat den ASCI-Wert: " + i + " und taucht " + Counter[i] + " Mal im Text auf.");
                }

            }

        }
        public static void BuchstabenZaehlen()                      //kann Buchstaben und auch Zahlen zählen
        {
            Console.WriteLine("Welchen Buchstaben möchtest du zählen lassen?");
            char search = Convert.ToChar(Console.ReadLine());

            string Text = getText();

            int counter = 0;
            for (int i = 0; i < Text.Length; i++)
            {
                if (Text[i] == search)
                {
                    counter++;
                }

            }
            Console.WriteLine($"Anzahl von {search}: {counter}");
        }

        public static string getText()
        {
            return "Geboren am 2.7.1877 in Calw, gestorben am 9.8.1962 in Montagnola. Thematik der frühen Romane: Widerstand gegen konventionelle Normen, geistige Unruhe und Zweifel, Gegensatz zwischen kontemplativer und „sinnlicher“ Lebensweise," +
                " Verhältnis des Künstlers zum Leben. Nach dem Ersten Weltkrieg wird Hesses Werk von der Psychoanalyse (Demian) als auch von orientalischer Meditation (Siddhartha) beeinflusst; vor allem im „Steppenwolf“ übt Hesse vehemente Kritik" +
                " an der technokratischen Zivilisation und den Widersprüchen der bürgerlichen Gesellschaft, an einer Welt der Maschinen und der Kommerzialisierung. Der Altersroman Glasperlenspiel gestaltet das neue Ideal eines „Reichs des Geistes und der Seele“ als Gegenentwurf zur Geistverneinung des Nationalsozialismus. Hesses Werke waren mehrmals Identifikationstexte der gegen Gesellschaftszwänge aufbegehrenden jungen Generation: nach dem Ersten (Demian) und dem Zweiten Weltkrieg (Glasperlenspiel) und im Jugendprotest der späten sechziger Jahre. Vor dem Hintergrund des Vietnam-Kriegs kam es von den USA aus zu einer Hesse-Renaissance. Der Romantiker, Mystiker und Anti-Bürger Hesse wurde zum Klassiker der Hippiekultur, die sich in seinen Texten wiederfand (Steppenwolf).\r\n\r\nHesse über sich selbst: „Ich habe mich im Lauf meiner Entwicklung den Problemen der Zeit nicht entzogen und nie, wie meine politischen Kritiker meinen, im elfenbeinernen Turme gelebt – aber das erste und brennendste meiner Probleme war nie der Staat, die Gesellschaft oder die Kirche, sondern der einzelne Mensch, die Persönlichkeit, das einmalige, nicht normierte Individuum“ (1951).\r\nIn den USA und Japan der meistgelesene europäische Autor seit hundert Jahren; Millionenauflage seiner Bücher, Übersetzungen in 40 Sprachen.";
        }
    }
}