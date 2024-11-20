using System;

namespace FlorianBaier.Week07
{
    public class UserInterface
    {

        private ParticipantsList participantsList;

        public UserInterface(ParticipantsList participantsList)
        {
            this.participantsList = participantsList;
        }

        public void Start()
        {
            participantsList.AddParticipant("Florian");
            participantsList.AddParticipant("Barbara");
            participantsList.AddParticipant("Julian");
            participantsList.AddParticipant("Simon");
            participantsList.AddParticipant("Manuel");
            participantsList.AddParticipant("Stefan");
            participantsList.AddParticipant("Fatma");


            while (true)
            {
                Console.Write("Geben Sie den Namen des Teilnehmers ein (oder 'exit' zum Beenden): ");
                string nameInput = Console.ReadLine();

                if (nameInput.ToLower() == "exit")
                {
                    break;
                }

                if (!participantsList.ParticipantExists(nameInput))
                {
                    Console.WriteLine($"Teilnehmer '{nameInput}' existiert nicht. Bitte versuchen Sie es erneut.");
                    continue;
                }

                Console.Write("Geben Sie das Datum der Abwesenheit ein (im Format dd.MM.yyyy): ");
                string dateInput = Console.ReadLine();
                DateTime absenceDate;

                if (DateTime.TryParseExact(dateInput, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out absenceDate))
                {
                    participantsList.AddAbsence(nameInput, absenceDate);
                    Console.WriteLine($"Abwesenheit für '{nameInput}' am {absenceDate.ToShortDateString()} wurde hinzugefügt.");
                }
                else
                {
                    Console.WriteLine("Ungültiges Datum. Bitte verwenden Sie das Format dd.MM.yyyy.");
                }
            }

            participantsList.PrintParticipantsList();
        }
    }
}