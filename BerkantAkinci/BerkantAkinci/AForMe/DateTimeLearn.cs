using System;

namespace BerkantAkinci.AForMe
{
    class DateTimeLearn
    {
        public static void Start()
        {
            TimeSpan vorher = new TimeSpan(-5,-2,-30,-20);
            DateTime jetztMonat = DateTime.Now;

            DateTime vorher1 = jetztMonat.Add(vorher);

            System.Console.WriteLine(vorher1);

            System.Console.WriteLine(jetztMonat.ToString("MMMM"));


        }
    }
}