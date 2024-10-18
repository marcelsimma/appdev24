using System;

namespace MagdalenaMueller.Week03
{
    public class StringHesse
    {
        public static void StringHesseProgram()
        {
            string hesse = "Hesse";
            int counter = 0;
            int indexcounter = 0;
            int lettercounter = 0;
        
            // Den Text abrufen
            string text = Text();
            
            // Den Text in Wörter aufteilen
            string[] words = text.Split(new char[] { ' ', ',', '.', ';', ':', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            
            for(int i = 0; i < words.Length; i++)
            {
                // Wörter mit "Hesse" vergleichen
                if (hesse.CompareTo(words[i]) == 0)
                {
                    counter++;
                    Console.WriteLine($"Gefunden an Stelle {i}");
                }
            }
        
            Console.WriteLine($"{counter}x Gefunden\n------------------------");

            char[] letterArray = text.ToCharArray();
            char[] abc = new char[30] {'a', 'b' ,'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'ä', 'ö', 'ü', 'ß'};
            int counti = 0;
            while(counti < letterArray.Length-1)
            {
                for(int i = 0; i <= letterArray.Length-1; i++)
                {
                    if(abc[indexcounter] == letterArray[i])
                    {
                        lettercounter++;
                    }
                }
                Console.WriteLine($"{abc[indexcounter]}: {lettercounter}");
                lettercounter = 0;
                

                for (int j = 0; j < letterArray.Length - 1; j++)
                {
                    if (char.ToUpper(abc[indexcounter]) == letterArray[j])
                    {
                        lettercounter++;
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{char.ToUpper(abc[indexcounter])}: {lettercounter}");
                Console.ResetColor();
                indexcounter++;
                lettercounter = 0;
                counti++;
            }
            
        }
        
        public static string Text()
        {
            return "Geboren am 2.7.1877 in Calw, gestorben am 9.8.1962 in Montagnola. Thematik der frühen Romane: Widerstand gegen konventionelle Normen, geistige Unruhe und Zweifel, Gegensatz zwischen kontemplativer und „sinnlicher“ Lebensweise," +
                " Verhältnis des Künstlers zum Leben. Nach dem Ersten Weltkrieg wird Hesses Werk von der Psychoanalyse (Demian) als auch von orientalischer Meditation (Siddhartha) beeinflusst; vor allem im „Steppenwolf“ übt Hesse vehemente Kritik" +
                " an der technokratischen Zivilisation und den Widersprüchen der bürgerlichen Gesellschaft, an einer Welt der Maschinen und der Kommerzialisierung. Der Altersroman Glasperlenspiel gestaltet das neue Ideal eines „Reichs des Geistes und der Seele“ als Gegenentwurf zur Geistverneinung des Nationalsozialismus. Hesses Werke waren mehrmals Identifikationstexte der gegen Gesellschaftszwänge aufbegehrenden jungen Generation: nach dem Ersten (Demian) und dem Zweiten Weltkrieg (Glasperlenspiel) und im Jugendprotest der späten sechziger Jahre. Vor dem Hintergrund des Vietnam-Kriegs kam es von den USA aus zu einer Hesse-Renaissance. Der Romantiker, Mystiker und Anti-Bürger Hesse wurde zum Klassiker der Hippiekultur, die sich in seinen Texten wiederfand (Steppenwolf).\r\n\r\nHesse über sich selbst: „Ich habe mich im Lauf meiner Entwicklung den Problemen der Zeit nicht entzogen und nie, wie meine politischen Kritiker meinen, im elfenbeinernen Turme gelebt – aber das erste und brennendste meiner Probleme war nie der Staat, die Gesellschaft oder die Kirche, sondern der einzelne Mensch, die Persönlichkeit, das einmalige, nicht normierte Individuum“ (1951).\r\nIn den USA und Japan der meistgelesene europäische Autor seit hundert Jahren; Millionenauflage seiner Bücher, Übersetzungen in 40 Sprachen.";
        }
    }
}