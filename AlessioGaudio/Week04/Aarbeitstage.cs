using System;

public class ATagee
{
    public static void Start()
    {
        Console.Write("Gib das Jahr ein: ");
        int jahr = Convert.ToInt32(Console.ReadLine());

        Console.Write("Gib den Monat ein (1-12): ");
        int monat = Convert.ToInt32(Console.ReadLine());

        int arbeitstage = getWorkdays(jahr, monat);
        Console.WriteLine($"Der Monat {monat} hat {arbeitstage} Arbeitstage.");

        int verbleibendeArbeitstage = getRemainingWorkdays(jahr, monat);
        Console.WriteLine($"Verbleibende Arbeitstage für das Jahr {jahr} ab Monat {monat}: {verbleibendeArbeitstage}");
    }

    public static int getWorkdays(int jahr, int monat)
    {
        int arbeitstage = 0;
        int tageImMonat = DateTime.DaysInMonth(jahr, monat);

        for (int tag = 1; tag <= tageImMonat; tag++)
        {
            DateTime datum = new DateTime(jahr, monat, tag);
            DayOfWeek wochentag = datum.DayOfWeek;

            if (wochentag >= DayOfWeek.Monday && wochentag <= DayOfWeek.Friday)
            {
                arbeitstage++;
            }
        }

        return arbeitstage;
    }

    public static int getRemainingWorkdays(int jahr, int startMonat)
    {
        int arbeitstage = 0;

        for (int monat = startMonat; monat <= 12; monat++)
        {
            arbeitstage += getWorkdays(jahr, monat);
        }

        return arbeitstage;
    }
}
