using System.Globalization;
namespace BarbaraMarte.Week05;

class Workdays
{

    public static void Start()
    {
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine("there are " + getWorkdays(2024, i) + " workdays in the " + i + " Month of the year.");
            // TimeSpan(2024, i);
            Console.WriteLine(new string('-', 24));
        }
    }
    public static int getWorkdays(int year, int month)

    {
        int workdays = 0;
        DateTime dateTime = new DateTime(year, month, 1);
        int daysInMonth = DateTime.DaysInMonth(year, month);

        for (int day = 1; day <= daysInMonth; day++)
        {
            if (dateTime.DayOfWeek != DayOfWeek.Saturday && dateTime.DayOfWeek != DayOfWeek.Sunday)
            {
                workdays++;
            }
            dateTime = dateTime.AddDays(1);
        }
        return workdays;
    }
}

