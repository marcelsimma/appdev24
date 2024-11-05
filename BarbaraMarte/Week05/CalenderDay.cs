using System.Globalization;

namespace BarbaraMarte.Week05;

class CalendarDays
{
    public static void Print()
    {
        Year();
        Today();
    }
    public static void Today()
    {
        CultureInfo austrian = new CultureInfo("de - AT");
        DayOfWeek now = austrian.DateTimeFormat.FirstDayOfWeek;
        Console.Write(now + '*');
    }
    public static void Year()
    {
        DateTime dayTime = new DateTime(24, 10, 2024);
        Console.WriteLine(dayTime.ToString("dd.MM.yy"));
        DateTime moment = DateTime.Now();
    }
}