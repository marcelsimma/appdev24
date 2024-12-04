using System;
using System.Globalization;

namespace SimonJochum.Week07.ParticipantList
{
    public class ParticipantsList
    {
        static readonly CultureInfo AustrianCulture = new CultureInfo("de-AT");
        static Dictionary<Person, List<DateTime>> ParticipantListToPrint = new Dictionary<Person, List<DateTime>>();
        static List<DateTime> AttendanceTimestamp = new List<DateTime>();
        public static void Start()
        {
            Console.WriteLine("Hallo bei der Abwesenheitsliste 4.0");
            Choice();
        }

        public static void Choice()
        {
            Console.WriteLine("Was möchten Sie machen?\n1. Person hinzufügen\n2. Eintrag zu einer Person hinzufügen\n3. Liste anzeigen\n4. Beenden");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddPerson();
                    break;
                case "2":
                    AddEntry();
                    break;
                case "3":
                    PrintList();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Bitte eine gültige Aktion wählen.");
                    break;
            }
        }

        public static void AddPerson()
        {
            Console.WriteLine("Wie ist der Name der Person die du hinzufügen möchtest? (Vorname Nachname)");
            string fullName = Console.ReadLine();
            Person toAdd = new Person(fullName);
            DateTime dateAtAdd = DateTime.Now;
            AttendanceTimestamp.Add(dateAtAdd);
            ParticipantListToPrint.Add(toAdd, AttendanceTimestamp);
            Console.WriteLine(new string('-', 24) + "\nPerson hinzugefügt\n" + new string('-', 24));
            AttendanceTimestamp.Clear();
            Choice();
        }

        public static void AddEntry()
        {
            Console.WriteLine("Bei welcher Person möchten Sie die Abwesenheit eintragen? (Vorname Nachname)");
            string nameToLook = Console.ReadLine();
            Console.WriteLine("Für welchen Tag soll die Abwesenheit eingetragen werden? (z.B. dd.MM.yyyy HH:mm)");
            DateTime attendanceTime = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy HH:mm", AustrianCulture);
            bool check = false;

            foreach (Person entry in ParticipantListToPrint.Keys)
            {
                if (entry.ToString() == nameToLook)
                {
                    AttendanceTimestamp.Add(attendanceTime);
                    Console.WriteLine(new string('-', 24) + "\nEintrag hinzugefügt\n" + new string('-', 24));
                    check = true;
                }
                if (!check)
                {
                    Console.WriteLine("Person nicht gefunden");
                }
            }
            Choice();
        }

        public static void PrintList()
        {
            foreach (var participant in ParticipantListToPrint.Keys)
            {
                Console.WriteLine(participant.ToString() + "\n" + new string('-', 24));
                foreach (var date in ParticipantListToPrint.Values)
                {
                    foreach (var d in date)
                        Console.WriteLine(d);
                }
            }
            Choice();
        }
    }
}