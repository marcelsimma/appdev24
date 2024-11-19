using System;

namespace OliverBedogg.Week06
{
    public class ListExample
    {
        private static Random rand = new Random();
        public static void Start()
        {
            // Liste vom Datentyp int
            List<int> values = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                // Listeneintrag hinzufügen
                values.Add(rand.Next(1, 101));
            }

            // Anzahl Listeneinträge
            Console.WriteLine("Count: {0}", values.Count); // 5
            // Kapazität bis intern ein Resize durchgeführt wird:
            Console.WriteLine("Capacity: {0}", values.Capacity); // 8
            Console.WriteLine("------------------");

            values.Add(rand.Next(1, 101)); // 6. Eintrag
            values.Add(rand.Next(1, 101)); // 7. Eintrag
            values.Add(rand.Next(1, 101)); // 8. Eintrag
            values.Add(rand.Next(1, 101)); // 9. Eintrag
            Console.WriteLine("Count: {0}", values.Count);
            Console.WriteLine("Capacity: {0}", values.Capacity);
            Console.WriteLine("------------------");

            // Werte Zusammenführen
            Console.WriteLine("[{0}]", string.Join(", ", values));
            Console.WriteLine("------------------");

            // Werte in For-Schleife mit Index-Zugriff
            for (int i = 0; i < values.Count; i++)
            {
                Console.WriteLine("{0}. is {1}", i, values[i]);
            }
            Console.WriteLine("------------------");

            // Werte über ForEach Durchgehen
            foreach (int item in values)
            {
                Console.WriteLine("Value: {0}", item);
            }
            Console.WriteLine("------------------");

            // Eintrag entfernen
            values.RemoveAt(0);
            Console.WriteLine("[{0}]", string.Join(", ", values));
            Console.WriteLine("------------------");

            // Suche
            Console.WriteLine("Ist 20 drin? " + values.Contains(20));
        }
    }
}