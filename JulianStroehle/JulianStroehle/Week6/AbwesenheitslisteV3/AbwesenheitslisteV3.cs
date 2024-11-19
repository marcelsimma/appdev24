using System;
using System.IO;
using System.Text;
namespace JulianStroehle.Week6.AbwesenheitslisteV3
{
    internal class AbwesenheitslisteV3
    {
        internal static string Path = "C:/Users/JUSR/Documents/Coding Campus/StreamTest/";
        internal static List<Teilnehmer> teilnehmerMZ = new List<Teilnehmer>();
        internal static List<Abwesenheit> abwesenheiten = new List<Abwesenheit>();
        internal static int Index;
        internal static void Start()
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<string> lines = new List<string>();
            if (File.Exists(Path + "AbwesenheitenV3.txt"))
            {
                using (StreamReader str = new StreamReader(Path + "AbwesenheitenV3.txt"))
                {
                    foreach (string line in str.ReadToEnd().Split("\n"))
                    {
                        if (line != "")
                        {
                            lines.Add(line);
                            string[] temps = line.Split("; ");
                            DateTime startTemp = new DateTime(Convert.ToInt64(temps[2]));
                            DateTime endTemp = new DateTime(Convert.ToInt64(temps[3]));
                            Abwesenheit abwesenheit = new Abwesenheit(startTemp, endTemp, temps[4], Convert.ToBoolean(temps[5]));
                            abwesenheiten.Add(abwesenheit);
                            Teilnehmer teilnehmerEZ = new Teilnehmer(temps[0], temps[1], abwesenheit);
                            teilnehmerMZ.Add(teilnehmerEZ);
                        }
                    }
                }
                string? temp;
                do
                {
                    Console.WriteLine("Wollen sie einen abwesenden Teilnehmer hinzufügen oder löschen? (h/l oder b zum Beenden)");
                    temp = Console.ReadLine();
                    switch (temp)
                    {
                        case "h": AddPerson(); break;
                        case "l": DelPerson(); break;
                        default: break;
                    }
                    Print();
                    GetFormatedDocument();
                }
                while (temp != "b");
            }
            else
            {
                Console.WriteLine("Anzahl der abwesenden Teilnehmer?");
                int anzahl = Convert.ToInt32(Console.ReadLine());
                AddPerson(anzahl);
                Print();
                GetFormatedDocument();
            }
        }
        static void AddPerson(int anzahl = 1)
        {
            for (int i = 0; i < anzahl; i++)
            {
                Console.WriteLine("Vorname?");
                string? firstName = Console.ReadLine();
                Console.WriteLine("Nachname?");
                string? lastName = Console.ReadLine();
                Console.WriteLine("Tag der Abwesenheit? (dd.MM.yyyy)");
                string[] times = Console.ReadLine().Split('.');
                Console.WriteLine("Uhrzeit der abwesenheit? (hh:mm:ss)");
                string[] times2 = Console.ReadLine().Split(':');
                DateTime dt = new DateTime(Convert.ToInt32(times[2]), Convert.ToInt32(times[1]), Convert.ToInt32(times[0]), Convert.ToInt32(times2[0]), Convert.ToInt32(times2[1]), Convert.ToInt32(times2[2]));
                Console.WriteLine($"Wieviel Tage war {firstName} Abwesend? (0 wenn {firstName} am gleichen Tag wieder kam)");
                int daysMissing = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Uhrzeit der Wiederkehr? (bei wiederkehr am nächsten Tag 17Uhr eintragen) (hh:mm:ss)");
                times2 = Console.ReadLine().Split(':');
                DateTime dt2 = new DateTime(Convert.ToInt32(times[2]), Convert.ToInt32(times[1]), Convert.ToInt32(times[0]) + daysMissing, Convert.ToInt32(times2[0]), Convert.ToInt32(times2[1]), Convert.ToInt32(times2[2]));
                Console.WriteLine("Grund der Abwesenheit?");
                string? cause = Console.ReadLine();
                bool isExcused = false;
                bool answered;
                do
                {
                    answered = true;
                    Console.WriteLine("Ist die Abwesenheit entschuldigt? (j/n)");
                    switch (Console.ReadLine().ToLower())
                    {
                        case "j": isExcused = true; break;
                        case "n": isExcused = false; break;
                        default: answered = false; break;
                    }
                }
                while (!answered);
                Abwesenheit abwesenheit = new Abwesenheit(dt, dt2, cause, isExcused);
                abwesenheiten.Add(abwesenheit);
                Teilnehmer teilnehmerEZ = new Teilnehmer(firstName, lastName, abwesenheit);
                teilnehmerMZ.Add(teilnehmerEZ);
            }
        }
        static void DelPerson()
        {
            Console.WriteLine("Index des Eintrags");
            Index = Convert.ToInt32(Console.ReadLine());
            teilnehmerMZ.RemoveAt(Index-1);
            abwesenheiten.RemoveAt(Index-1);
        }
        static void Print()
        {
            using (StreamWriter stw = new StreamWriter(Path + "AbwesenheitenV3.txt"))
            {
                for (int i = 0; i < teilnehmerMZ.Count; i++)
                {
                    stw.WriteLine(teilnehmerMZ[i].ToString() + abwesenheiten[i].ToString() + "; " + Math.Round(teilnehmerMZ[i].GetCost(), 2));
                }
            }
        }
        static void GetFormatedDocument()
        {
            using (StreamWriter stw = new StreamWriter(Path + "AbwesenheitenV3Formated.txt"))
            {
                Index = 1;
                stw.WriteLine(string.Format("{0,-6}", "Index") + "│" + string.Format("{0,-13}", "Vorname") + "│" + string.Format("{0,-10}", "Nachname") + "│" + string.Format("{0,-20}", "Startzeit") + "│" + string.Format("{0,-20}", "Endzeit") + "│" + string.Format("{0,-30}", "Fehlgrund") + "│" + string.Format("{0,-13}", "Entschuldigt") + "│" + string.Format("{0,-8}", "Kosten"));
                stw.WriteLine(new string('─', 6) + "┼" + new string('─', 13) + "┼" + new string('─', 10) + "┼" + new string('─', 20) + "┼" + new string('─', 20) + "┼" + new string('─', 30) + "┼" + new string('─', 13) + "┼" + new string('─', 8));
                for (int i = 0; i < teilnehmerMZ.Count; i++)
                {
                    stw.WriteLine(string.Format("{0,-6}", Index + ".") + "│" + teilnehmerMZ[i].Formated() + abwesenheiten[i].Formated() + "│" + string.Format("{0,8}", Math.Round(teilnehmerMZ[i].GetCost(), 2) + "€"));
                    Index++;
                }
            }
        }
    }
}