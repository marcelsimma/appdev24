using System;
using System.Globalization;
namespace JulianStroehle.Week4
{
    public class WannUndWo
    {
        public static void Start()
        {
            DateTime dt = DateTime.Now;
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de_AT");
            OnlyDate(dt);
            OnlyTime(dt);
            TimeAndDate(dt);
            TimeDateAndZone(dt);
            Second(dt);
        }
        static void OnlyDate(DateTime dt)
        {
            Console.WriteLine(dt.ToString("d"));
        }
        static void OnlyTime(DateTime dt)
        {
            Console.WriteLine(dt.ToString("T"));
        }
        static void TimeAndDate(DateTime dt)
        {
            Console.WriteLine(dt.ToString("U"));
        }
        static void TimeDateAndZone(DateTime dt)
        {
            Console.Write(dt.ToString("U") + " ");
            Console.WriteLine(dt.ToString("zzz"));
        }
        static void Second(DateTime dt)
        {
            Console.WriteLine(dt.ToString("ss.fff"));
        }
    }
}