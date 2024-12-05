using System; 
namespace NicoDobler.Week07
{
    class ParticipantsList
    {
        public static void Start()
        {

            Dictionary<string, List<DateTime>> participantsList = new Dictionary<string, List<DateTime>>();

            participantsList.Add("Mathias", new List<DateTime>());
            participantsList.Add("Johannes", new List<DateTime>());
            participantsList.Add("Ahmet", new List<DateTime>());

        

            participantsList["Nico"].Add(DateTime.Now);

            participantsList["Nico"].Clear();

            foreach(KeyValuePair<string, List<DateTime>> participant in participantsList) {
                Console.Write($"{participant.Key, -10}: ");
                foreach (DateTime timeEntry in participant.Value) {
                    Console.Write($"{timeEntry.ToShortDateString()}, ");
                }
                Console.WriteLine();
            }
            System.Console.WriteLine(participantsList["Nico"]);

        }
    }
}