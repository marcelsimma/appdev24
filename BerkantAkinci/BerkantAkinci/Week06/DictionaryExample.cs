using System;

namespace BerkantAkinci.Week06
{
    public class DictionaryExample
    {
        public static void Start()
        {
            // Trainer-Liste
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Sandro", 13);
            dict.Add("Lukas", 7);
            dict.Add("Hassan", 14);
            dict.Add("Berna", 6);
            dict.Add("Gyula", 20);
            dict.Add("UFO", 1);

            foreach (string name in dict.Keys)
            {
                Console.WriteLine("Name: {0}", name);
            }

            Console.WriteLine(
                "Sandro hat {0} Kursstunden pro Woche",
                dict["Sandro"]);
            dict["Sandro"] += 7;
            Console.WriteLine(
                "Sandro hat nächste Woche {0} Kursstunden",
                dict["Sandro"]);


            Console.WriteLine("Ist Jovo ein Trainer? {0}",
                dict.ContainsKey("Jovo"));
            Console.WriteLine("Ist Lukas ein Trainer? {0}",
                dict.ContainsKey("Lukas"));

            dict.Remove("UFO");
            Console.WriteLine(
                "Es gibt {0} aktiv Trainer.",
                dict.Count
                );
        }
    }
}