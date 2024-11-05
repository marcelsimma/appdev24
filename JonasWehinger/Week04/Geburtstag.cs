using System;
namespace JonasWehinger.Week04
{
class Geburtstag
{
    public static void Tag()
    {
        Console.WriteLine("Gib dein Geburtstag ein:");

        string? input = Console.ReadLine();

        DateTime geburtstag = Convert.ToDateTime(input);

            DayOfWeek wochentag = geburtstag.DayOfWeek;

            
            Console.WriteLine($"Dein Geburtstag war ein {wochentag}.");

    }
}
}