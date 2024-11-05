using System;
using System.Globalization;

namespace BarbaraMarte.Week04;

class WannUndWo
{
    public static void Print()
    {
        DateTime moment = DateTime.Now;
        CultureInfo austrian = new CultureInfo("de-AT");

        Console.WriteLine("Date: " + moment.ToString("d", austrian));
        Console.WriteLine("Time: " + moment.ToString("t", austrian));
        Console.WriteLine("Date: " + moment.ToString("d", austrian) + "\nTime: " + moment.ToString("t", austrian) + " Timezone: " + moment.ToString("zzz"));
        Console.WriteLine("Second: " + moment.ToString("s") + "\tMillisecond: " + moment.ToString("fff"));
    }
}