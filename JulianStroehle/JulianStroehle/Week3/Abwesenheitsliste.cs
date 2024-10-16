using System;
namespace JulianStroehle.Week3
{
    public class Abwesenheitsliste
    {
        public static void Start()
        {
            Console.WriteLine("Anzahl Teilnehmer: ");
            int anz = Convert.ToInt32(Console.ReadLine());
            string[,] Anwesenheiten = new string[anz + 1, 4];
            string? again;
            Anwesenheiten[0, 1] = "Di";
            Anwesenheiten[0, 2] = "Mi";
            Anwesenheiten[0, 3] = "Do";
            Anwesenheiten[0, 0] = " ";
            for (int i = 0; i < anz; i++)
            {
                Console.WriteLine($"Vorname des {i + 1}. Teilnehmers: ");
                string? name = Console.ReadLine();
                if (name != null)
                {
                    Anwesenheiten[i + 1, 0] = name;
                }
            }
            do
            {
                IsHere(Anwesenheiten, anz);
                for (int i = 0; i < anz + 1; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (Anwesenheiten[i, j] == null)
                        {
                            Anwesenheiten[i, j] = "O";
                        }
                        Console.Write(Anwesenheiten[i, j] + "\t");
                        if (j == 0)
                        {
                            Console.Write("\t");
                        }
                    }
                    Console.WriteLine("\n--------------------------------------");
                }
                Console.WriteLine("Weitere Abwesenheit eintragen? (j/n)");
                again = Console.ReadLine();
            }
            while (again == "j");
        }
        static void IsHere(string[,] Anwesenheiten, int anz)
        {
            Console.WriteLine("Welcher Teilnehmer ist Abwesend?");
            string? name = Console.ReadLine();
            bool foundName = false;
            for (int i = 0; i < anz + 1; i++)
            {
                if (Anwesenheiten[i, 0] == name)
                {
                    foundName = true;
                    Console.WriteLine("Tag? (Di/Mi/Do)");
                    string? day = Console.ReadLine();
                    switch (day)
                    {
                        case "Di": Anwesenheiten[i, 1] = "X"; break;
                        case "Mi": Anwesenheiten[i, 2] = "X"; break;
                        case "Do": Anwesenheiten[i, 3] = "X"; break;
                    }
                }
            }
            if (foundName == false)
            {
                Console.WriteLine("Name nicht gefunden");
            }
        }
    }
}