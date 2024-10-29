
namespace ManuelHartmann.Week04
{
    public class NextUpcomingSunday
    {
        public static void Start()
        {
            DateTime today = DateTime.Today;    //  Heutiger Tag.
            int daysUntilSunday = ((int)DayOfWeek.Sunday - (int)today.DayOfWeek + 7) % 7;   //  Anzahl die von heute addiert werden muessen, um auf Sonntag zu kommen.
            DateTime upcomingSunday = today.AddDays(daysUntilSunday);

            //  Textausgaben
            Console.Write("From today: ");
            Console.Write(today.ToString("D"));
            Console.WriteLine();

            //  Gibt die naechsten drei bevorstehenden Sonntage aus.
            for (int i = 0; i < 3; i++)
            {
                DateTime nextSunday = today.AddDays(daysUntilSunday + (i * 7)); //  Berechnet die naechsten drei bevorstehenden Sonntage.
                Console.WriteLine($"{i + 1}. upcoming Sunday is at : {nextSunday.ToShortDateString()}");
            }
        }
    }
}

