using System;
namespace JonasWehinger.Week04
{
class Date
{
    public static void Datum()
    {
        
        DateTime jetzt = DateTime.Now;

        
        DateTime nurDatum = jetzt.Date;
        Console.WriteLine( nurDatum.ToString("dd.MM.yyyy"));

        
        TimeSpan nurUhrzeit = jetzt.TimeOfDay;
        Console.WriteLine( nurUhrzeit.ToString(@"hh\:mm\:ss"));

        
        Console.WriteLine( jetzt.ToString("dd.MM.yyyy HH:mm"));

        
        DateTimeOffset Zeitzone = DateTimeOffset.Now;
        Console.WriteLine( Zeitzone.ToString("dd.MM.yyyy HH:mm zzz"));

        
        Console.WriteLine( jetzt.ToString("ss.fff"));
    }
}
}