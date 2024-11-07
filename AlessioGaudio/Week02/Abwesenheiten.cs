using System;

namespace AlessioGaudio.Week02
{
    class Abwesende
    {
         public static void Start()
        {
            Console.WriteLine("Anzahl Teilnehmer: ");
            int Anzahl = Convert.ToInt32(Console.ReadLine());
            string[,] Anwesenheiten = new string[Anzahl + 1, 4];
            string? again;
           
            Anwesenheiten[0, 1] = "Di";
            Anwesenheiten[0, 2] = "Mi";
            Anwesenheiten[0, 3] = "Do";
            Anwesenheiten[0, 0] = " ";
          
            for (int i = 0; i < Anzahl; i++)
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
                IsHere(Anwesenheiten, Anzahl);
                for (int i = 0; i < Anzahl + 1; i++)
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
                Console.WriteLine("Weitere Abwesenheiten? (j/n)");
                again = Console.ReadLine();
            }
            while (again == "j");
        }
        static void IsHere(string[,] Anwesenheiten, int Anzahl)
        {
            Console.WriteLine("Wer ist Abwesend?");
            string? name = Console.ReadLine();
            bool GefName = false;
            for (int i = 0; i < Anzahl + 1; i++)
            {
                if (Anwesenheiten[i, 0] == name)
                {
                    GefName = true;
                    Console.WriteLine("Tag? (Di/Mi/Do)");
                    string? day = Console.ReadLine();
                    switch (day.ToLower())
                    {
                        case "di": Anwesenheiten[i, 1] = "X"; break;
                        case "mi": Anwesenheiten[i, 2] = "X"; break;
                        case "do": Anwesenheiten[i, 3] = "X"; break;
                    }
                }
            }
            if (GefName == false)
            {
                Console.WriteLine("Name nicht gefunden");
            }
        }
    }
}

