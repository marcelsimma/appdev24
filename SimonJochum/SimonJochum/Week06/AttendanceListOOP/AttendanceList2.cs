using System;
using SimonJochum.Week03;
using System.Collections.Generic;
using System.Globalization;
using System.IO;


namespace SimonJochum.Week06.AttendanceListOOP
{
    public class AttendanceList2
    {
        private static readonly string FilePath = @"C:\Users\SIJO\Documents\Testaufgaben\attendanceList.csv";
        private static readonly CultureInfo AustrianCulture = new CultureInfo("de-AT");
        static List<Participant> attendanceList = new List<Participant>();

        public static void StartNow()
        {
            LoadParticipantsListFromCSV();
            Console.WriteLine("Was möchten Sie tun?\n1: Teilnehmer hinzufügen\n2: Abwesenheit hinzufügen\n3: Liste anzeigen\n4: Kosten anzeigen\n5: Speichern und Beenden");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddParticipant();
                    break;
                case "2":
                    AddAbsenceReason();
                    break;
                case "3":
                    PrintAttendanceList();
                    break;
                case "4":
                    PrintAttendanceCosts();
                    break;
                case "5":
                    SaveParticipantsListToCSV();
                    return;
                default:
                    Console.WriteLine("Bitte geben Sie eine gültige Aktion ein.");
                    StartNow();
                    break;
            }
        }

        public static void AddParticipant()
        {
            Console.WriteLine("Vorname des Teilnehmers:");
            string inputFirstName = Console.ReadLine();

            Console.WriteLine("Nachname des Teilnehmers:");
            string inputLastName = Console.ReadLine();

            Console.WriteLine("Stundensatz des Teilnehmers:");
            double hourRate = double.Parse(Console.ReadLine(), AustrianCulture);

            Participant newEntry = new Participant(inputFirstName, inputLastName) { HourRate = hourRate };
            attendanceList.Add(newEntry);
            Console.WriteLine("Teilnehmer erfolgreich hinzugefügt.");
            StartNow();
        }

        public static void AddAbsenceReason()
        {
            Console.WriteLine("Bei welchem Teilnehmer möchten Sie eine Abwesenheit eintragen? (Vorname Nachname)");
            string name = Console.ReadLine();
            string[] nameParts = name.Split(' ');

            if (nameParts.Length != 2)
            {
                Console.WriteLine("Bitte geben Sie den Vor- und Nachnamen an.");
                AddAbsenceReason();
                return;
            }

            Participant participant = attendanceList.Find(p => p.FirstName == nameParts[0] && p.LastName == nameParts[1]);
            if (participant == null)
            {
                Console.WriteLine("Teilnehmer nicht gefunden.");
                StartNow();
                return;
            }

            Console.WriteLine("Grund der Abwesenheit:");
            string absenceReason = Console.ReadLine();

            Console.WriteLine("Startzeitpunkt der Abwesenheit (z.B. dd.MM.yyyy HH:mm):");
            DateTime startTime = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy HH:mm", AustrianCulture);

            Console.WriteLine("Endzeitpunkt der Abwesenheit (z.B. dd.MM.yyyy HH:mm):");
            DateTime endTime = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy HH:mm", AustrianCulture);

            Console.WriteLine("Ist die Abwesenheit entschuldigt? (Ja/Nein)");
            bool excused = Console.ReadLine().ToLower() == "ja";

            ReasonOfAbsence newAbsence = new ReasonOfAbsence(absenceReason, startTime, endTime, excused);
            participant.AddAbsence(newAbsence);
            Console.WriteLine("Abwesenheit erfolgreich hinzugefügt.");
            StartNow();
        }

        public static void PrintAttendanceList()
        {
            Console.WriteLine("Teilnehmerliste:");
            foreach (var participant in attendanceList)
            {
                Console.WriteLine(participant.PrintParticipant());
                foreach (var absence in participant.Absences)
                {
                    Console.WriteLine($"  - {absence}");
                }
            }
            StartNow();
        }

        public static void SaveParticipantsListToCSV()
        {
            using (var writer = new StreamWriter(FilePath))
            {
                foreach (var participant in attendanceList)
                {
                    writer.WriteLine($"Teilnehmer;{participant.FirstName};{participant.LastName};{participant.HourRate.ToString(AustrianCulture)}");

                    foreach (var absence in participant.Absences)
                    {
                        writer.WriteLine($"Abwesenheit;{absence.StartTime.ToString("dd.MM.yyyy HH:mm", AustrianCulture)};" +
                                         $"{absence.EndTime.ToString("dd.MM.yyyy HH:mm", AustrianCulture)};" +
                                         $"{absence.AbsenceReason};{absence.Excused}");
                    }
                }
            }
            Console.WriteLine("Teilnehmerliste erfolgreich gespeichert.");
        }

        public static void LoadParticipantsListFromCSV()
        {
            if (!File.Exists(FilePath))
            {
                Console.WriteLine("Keine gespeicherte Teilnehmerliste gefunden.");
                return;
            }

            attendanceList.Clear();
            Participant currentParticipant = null;

            using (var reader = new StreamReader(FilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var columns = line.Split(';');
                    if (columns[0] == "Teilnehmer")
                    {
                        string firstName = columns[1];
                        string lastName = columns[2];
                        double hourRate = double.Parse(columns[3], AustrianCulture);

                        currentParticipant = new Participant(firstName, lastName) { HourRate = hourRate };
                        attendanceList.Add(currentParticipant);
                    }
                    else if (columns[0] == "Abwesenheit" && currentParticipant != null)
                    {
                        DateTime startTime = DateTime.ParseExact(columns[1], "dd.MM.yyyy HH:mm", AustrianCulture);
                        DateTime endTime = DateTime.ParseExact(columns[2], "dd.MM.yyyy HH:mm", AustrianCulture);
                        string absenceReason = columns[3];
                        bool excused = bool.Parse(columns[4]);

                        ReasonOfAbsence newAbsence = new ReasonOfAbsence(absenceReason, startTime, endTime, excused);
                        currentParticipant.AddAbsence(newAbsence);
                    }
                }
            }
            Console.WriteLine("Teilnehmerliste erfolgreich geladen.\n" + new string('-', 30));
        }

        public static void PrintAttendanceCosts()
        {
            Console.WriteLine("Abwesenheitskosten pro Teilnehmer:");

            foreach (var participant in attendanceList)
            {
                double cost = participant.CalculateAttendanceCost();
                Console.WriteLine($"{participant.FirstName} {participant.LastName}: {cost.ToString("C", AustrianCulture)}");
            }
            StartNow();
        }
    }
}