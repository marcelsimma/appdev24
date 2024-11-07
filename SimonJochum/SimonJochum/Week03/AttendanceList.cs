using System;

namespace SimonJochum.Week03
{
    public class AttendanceList
    {
        public static void Start()
        {
            Console.WriteLine("Wieviele Teilnehmer möchten Sie auf die Liste schreiben?");
            int amount = Convert.ToInt32(Console.ReadLine()); 
            string[] names = new string[amount];
            string[][] attendanceList = new string[amount][];
            string? again;
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine($"Vorname des {i + 1}. Teilnehmer:"); //Nuterabfrage als Schleife, die das Array anschließend erstellt
                string? name = Console.ReadLine();
                if (name != null)
                {
                    names[i] = name;
                }
            }

            for (int i = 0; i < amount; i++) // das Array wird in ein Jagged Array überschrieben
            {
                attendanceList[i] = new string[1];
                attendanceList[i][0] = names[i];
            }


            do
            {
                Console.WriteLine("Bei welchem Teilnehmer möchten Sie eine Abwesenheit eintragen?");
                string? checkNameOnList = Console.ReadLine();
                Console.WriteLine("Was ist der Abwesenheitsgrund?");
                string? attendance = Console.ReadLine(); //Nuterabfrage bei wem was eingetragen werden soll

                bool found = false; // um zu prüfen, ob der Teilnehmer gefunden wurde

                for (int i = 0; i < amount; i++)
                {
                    if (checkNameOnList == attendanceList[i][0])
                    {
                        // Vergrößere das Array um 1
                        Array.Resize(ref attendanceList[i], attendanceList[i].Length + 1);
                        // Füge den Abwesenheitsgrund hinzu
                        attendanceList[i][attendanceList[i].Length - 1] = attendance;
                        found = true;
                        break; // Breche die Schleife ab, wenn der Teilnehmer gefunden wurde
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Teilnehmer nicht gefunden.");
                }

                PrintArray(attendanceList);
                Console.WriteLine("Möchten Sie noch einen Eintrag erstellen? (j/n)");
                again = Console.ReadLine();

            } while (again == "j");

        }

        public static void PrintArray(string[][] attendanceList)
        {
            for (int i = 0; i < attendanceList.Length; i++) // über das Array itterieren um es auszugeben
            {
                for (int j = 0; j < attendanceList[i].Length; j++)
                {
                    Console.Write(attendanceList[i][j] + " | ");
                }
                Console.WriteLine();
            }
        }

    }
}