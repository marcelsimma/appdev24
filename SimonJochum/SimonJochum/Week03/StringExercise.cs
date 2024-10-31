using System;

namespace SimonJochum.Week03
{
    public class StringExercise
    {
        public static void Start()
        {
            //SearchHesse();
            CountingCharacter();
            // PrintInUppercase();

        }

        public static void SearchHesse()
        {
            string textToSearch = GetText();

            string? toSearch = Console.ReadLine();
            int pos = 0;
            int count = 0;

            pos = textToSearch.IndexOf(toSearch, 0);
            Console.WriteLine($"An Position {pos} gefunden");

            while (pos >= 0)
            {
                count++;
                pos = textToSearch.IndexOf(toSearch, pos + 1);
                Console.WriteLine($"An Position {pos} gefunden");
            }
            Console.Write($"Anzahl = {count}");
        }
        

        public static void CountingCharacter()
        {
            string textString = GetText();
            int max = char.MaxValue;
            int[] count = new int[max];

            foreach (char c in textString)
            {
                count[Convert.ToInt32(c)]++; // Zähle jeden Charakter
            }

            for (int i = 0; i < max; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine($"{(char)i}: {count[i]}"); // Gibt das Zeichen und die Anzahl aus
                }
            }
        }

        public static void PrintInUppercase()
        {
            Console.WriteLine("Welches Wort möchtest du groß schreiben?");

            string textToSearch = GetText();
            string? toSearch = Console.ReadLine();
            string? toReplace = toSearch.ToUpper();
            int pos = 0;
            int count = 0;

            pos = textToSearch.IndexOf(toSearch, 0);
            string replacedTextToSearch = textToSearch.Replace(toSearch,toReplace);

            while (pos >= 0)
            {
                count++;
                pos = textToSearch.IndexOf(toSearch, pos + 1);
                replacedTextToSearch = textToSearch.Replace(toSearch,toReplace);
            }
            Console.WriteLine(replacedTextToSearch);
        }

        public static string GetText()
        {
            return "Geboren am 2.7.1877 in Calw, gestorben am 9.8.1962 in Montagnola. Thematik der frühen Romane: Widerstand gegen konventionelle Normen, geistige Unruhe und Zweifel, Gegensatz zwischen kontemplativer und „sinnlicher“ Lebensweise," +
                " Verhältnis des Künstlers zum Leben. Nach dem Ersten Weltkrieg wird Hesses Werk von der Psychoanalyse (Demian) als auch von orientalischer Meditation (Siddhartha) beeinflusst; vor allem im „Steppenwolf“ übt Hesse vehemente Kritik" +
                " an der technokratischen Zivilisation und den Widersprüchen der bürgerlichen Gesellschaft, an einer Welt der Maschinen und der Kommerzialisierung. Der Altersroman Glasperlenspiel gestaltet das neue Ideal eines „Reichs des Geistes und der Seele“ als Gegenentwurf zur Geistverneinung des Nationalsozialismus. Hesses Werke waren mehrmals Identifikationstexte der gegen Gesellschaftszwänge aufbegehrenden jungen Generation: nach dem Ersten (Demian) und dem Zweiten Weltkrieg (Glasperlenspiel) und im Jugendprotest der späten sechziger Jahre. Vor dem Hintergrund des Vietnam-Kriegs kam es von den USA aus zu einer Hesse-Renaissance. Der Romantiker, Mystiker und Anti-Bürger Hesse wurde zum Klassiker der Hippiekultur, die sich in seinen Texten wiederfand (Steppenwolf).\r\n\r\nHesse über sich selbst: „Ich habe mich im Lauf meiner Entwicklung den Problemen der Zeit nicht entzogen und nie, wie meine politischen Kritiker meinen, im elfenbeinernen Turme gelebt – aber das erste und brennendste meiner Probleme war nie der Staat, die Gesellschaft oder die Kirche, sondern der einzelne Mensch, die Persönlichkeit, das einmalige, nicht normierte Individuum“ (1951).\r\nIn den USA und Japan der meistgelesene europäische Autor seit hundert Jahren; Millionenauflage seiner Bücher, Übersetzungen in 40 Sprachen.";
        }
    }
}