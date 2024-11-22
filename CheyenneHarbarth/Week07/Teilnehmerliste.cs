using System;
using System.Reflection.Metadata;
using System.Runtime.Loader;

namespace CheyenneHarbarth.Week07
{
    public class Teilnehmerliste
    {
        public static void Start()
        {
            Dictionary<string, List<DateTime>> ParticipantsList = new Dictionary<string, List<DateTime>>();

            ParticipantsList.Add("Cheyenne Harbarth", new List<DateTime>());
            ParticipantsList.Add("Berkant Akinci", new List<DateTime>());
            ParticipantsList.Add("Stefan Marinovic", new List<DateTime>());
            ParticipantsList.Add("Manuel Hartmann", new List<DateTime>());
            ParticipantsList.Add("Riccardo Ceccon", new List<DateTime>());

            ParticipantsList["Cheyenne Harbarth"].Add(DateTime.Now);
            ParticipantsList["Berkant Akinci"].Add(DateTime.Today.AddDays(-6));
            ParticipantsList["Berkant Akinci"].Add(DateTime.Today.AddDays(-5));
            ParticipantsList["Manuel Hartmann"].Add(DateTime.Today.AddDays(-7));
            ParticipantsList["Riccardo Ceccon"].Add(DateTime.Today);

            foreach (KeyValuePair<string, List<DateTime>> participant in ParticipantsList)
            {
                Console.Write($"Name: {participant.Key,-20} | Abwesenheiten:");
                foreach (DateTime timeEntry in participant.Value)
                {
                    Console.Write($" {timeEntry.ToShortDateString()},");
                }
                Console.WriteLine();
            }
        }
    }
}