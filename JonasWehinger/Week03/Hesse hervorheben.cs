using System;
using System.Security.Cryptography;

namespace JonasWehinger.Week03
{
 
    public class StringsHesse
    {
        public static void Start()
        {
            
            SucheHesse();
            Console.WriteLine("===================");
            BuchstabenZaehlen();
            
        }
 
        public static void SucheHesse()
        {
           
           
 
            string textString = getText();
            string searchFor = "Hesse";
            
 
            int startPos = textString.IndexOf(searchFor);
            Console.WriteLine("First Index: " + startPos);
            Console.WriteLine("--------------------");
 
            int count = -1;
            int pos = -1;
            do
            {
                pos = textString.IndexOf(searchFor, pos + 1);
                Console.WriteLine("Count: " + count + ", Found at Index: " + pos);
                count++;
            } while (pos >= 0);
            
            Console.WriteLine("Anzahl: " + count);
            Console.WriteLine("--------------------");
            Console.WriteLine("--------------------");
 
 
            count = 0;
            pos = textString.IndexOf(searchFor);
            Console.WriteLine("Found at Index: " + pos);
 
            
            while (pos >= 0)
            {
                
                count++;
                pos = textString.IndexOf(searchFor, pos + 1);
                Console.WriteLine("Count: " + count + ", Found at Index: " + pos);
            }
            
            if (count > 0)
                Console.WriteLine("Anzahl: " + count);
            else
                Console.WriteLine($"{searchFor} nicht gefunden.");
 
            Console.WriteLine("--------------------");
        }
 
        public static void BuchstabenZaehlen()
        {
 
 
            int nbr = (int)'A';
            int max = char.MaxValue;
            string textString = getText();
            Console.WriteLine($"int of char: {nbr}/{max}");
            Console.WriteLine($"char of int: {nbr}: " + (char)nbr);
            Console.WriteLine("--------------------");
 
            for (int i = 0; i < textString.Length; i++)
            {
                char c = textString[i];
            }
            Console.WriteLine("--------------------");
 
        }
 
        public static string getText()
        {
            return "Geboren am 2.7.1877 in Calw, gestorben am 9.8.1962 in Montagnola. Thematik der frühen Romane: Widerstand gegen konventionelle Normen, geistige Unruhe und Zweifel, Gegensatz zwischen kontemplativer und „sinnlicher“ Lebensweise," +
                " Verhältnis des Künstlers zum Leben. Nach dem Ersten Weltkrieg wird Hesses Werk von der Psychoanalyse (Demian) als auch von orientalischer Meditation (Siddhartha) beeinflusst; vor allem im „Steppenwolf“ übt Hesse vehemente Kritik" +
                " an der technokratischen Zivilisation und den Widersprüchen der bürgerlichen Gesellschaft, an einer Welt der Maschinen und der Kommerzialisierung. Der Altersroman Glasperlenspiel gestaltet das neue Ideal eines „Reichs des Geistes und der Seele“ als Gegenentwurf zur Geistverneinung des Nationalsozialismus. Hesses Werke waren mehrmals Identifikationstexte der gegen Gesellschaftszwänge aufbegehrenden jungen Generation: nach dem Ersten (Demian) und dem Zweiten Weltkrieg (Glasperlenspiel) und im Jugendprotest der späten sechziger Jahre. Vor dem Hintergrund des Vietnam-Kriegs kam es von den USA aus zu einer Hesse-Renaissance. Der Romantiker, Mystiker und Anti-Bürger Hesse wurde zum Klassiker der Hippiekultur, die sich in seinen Texten wiederfand (Steppenwolf).\r\n\r\nHesse über sich selbst: „Ich habe mich im Lauf meiner Entwicklung den Problemen der Zeit nicht entzogen und nie, wie meine politischen Kritiker meinen, im elfenbeinernen Turme gelebt – aber das erste und brennendste meiner Probleme war nie der Staat, die Gesellschaft oder die Kirche, sondern der einzelne Mensch, die Persönlichkeit, das einmalige, nicht normierte Individuum“ (1951).\r\nIn den USA und Japan der meistgelesene europäische Autor seit hundert Jahren; Millionenauflage seiner Bücher, Übersetzungen in 40 Sprachen.";
        }
    }
}
 