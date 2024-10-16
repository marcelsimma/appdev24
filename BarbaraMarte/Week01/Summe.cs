using System.ComponentModel;
using System.Reflection.Emit;
using System.Xml.XPath;

namespace BarbaraMarte.Week01
{
    class Summe
    {
        public static void PrintSumme()
        {
            int sum = 0;
            Console.WriteLine("Summe von 20 vis 50 addiert:");

            for (int i = 20; i <= 50; i++)
            {
                Console.WriteLine($"Rechenweg {sum} + {i} = {sum + i}");             
                sum += i;  // Aktuelle Zahl wird zur Summe hinzugefügt (mit += wird der Wert der sum nicht überschrieben)             
            }
            Console.WriteLine($"Die Gesammte Summe ist: {sum}"); // Ausgabe der Gesamtsumme nach jeder Rechnung
        }   //das & interpretiert das in der Geschwungen Klammern geschriebene als variablen. Vereinfacht das schreiben und lesen
    }
}