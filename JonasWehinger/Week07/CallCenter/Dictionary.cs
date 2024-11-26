using System;

namespace JonasWehinger.Week07
{
    public class Dictionary
    {
        public static void Start()
        {
            Dictionary<string, List<DateTime>> participantsList = new Dictionary<string, List<DateTime>>();

            participantsList.Add("Anna", new List<DateTime>());
            participantsList.Add("Max", new List<DateTime>());
            participantsList.Add("Sophie", new List<DateTime>());

            participantsList["Anna"].Add(DateTime.Now);

            participantsList["Anna"].Clear();
    
            foreach (KeyValuePair<string, List<DateTime>> participant in participantsList)
            {
                Console.Write($"{participant.Key, -10}: ");
                foreach (DateTime timeEntry in participant.Value)
                { 
                    Console.Write($"{timeEntry.ToShortDateString()}, ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(participantsList["Anna"]);
        }
    }
}
