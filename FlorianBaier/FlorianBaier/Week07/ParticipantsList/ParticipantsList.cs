using System;

namespace FlorianBaier.Week07
{
    public class ParticipantsList
    {
        private Dictionary<string, List<DateTime>> participants;

        public ParticipantsList()
        {
            participants = new Dictionary<string, List<DateTime>>();
        }

        public void AddAbsence(string fullName, DateTime absenceDate)
        {
            if (!participants.ContainsKey(fullName))
            {
                Console.WriteLine($"Fehler: Der Teilnehmer '{fullName}' ist nicht in der Liste.");
                return;
            }

            participants[fullName].Add(absenceDate);
        }

        public void AddParticipant(string fullName)
        {
            if (!participants.ContainsKey(fullName))
            {
                participants[fullName] = new List<DateTime>();
                Console.WriteLine($"Teilnehmer '{fullName}' wurde hinzugefügt.");
            }
            else
            {
                Console.WriteLine($"Teilnehmer '{fullName}' existiert bereits in der Liste.");
            }
        }
        public bool ParticipantExists(string fullName)
        {
            return participants.ContainsKey(fullName);
        }
        public void PrintParticipantsList()
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(string.Format("| {0,-25} | {1,-35} |", "Teilnehmername", "Abwesenheiten"));
            Console.WriteLine("-------------------------------------------------------------------");

            foreach (var participant in participants)
            {
                string participantName = participant.Key;
                List<DateTime> absences = participant.Value;

                string formatName = string.Format("{0,-25}", participantName);

                if (absences.Count > 0)
                {
                    foreach (var absence in absences)
                    {
                        Console.WriteLine(string.Format("| {0} | {1,-35} |", formatName, absence.ToShortDateString()));
                    }
                }
                else
                {
                    Console.WriteLine(string.Format("| {0} | {1,-35} |", formatName, "Keine Abwesenheiten vorhanden"));
                }

                Console.WriteLine("-------------------------------------------------------------------");
            }
        }
    }
}