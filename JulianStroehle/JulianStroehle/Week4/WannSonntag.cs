using System;
namespace JulianStroehle.Week4
{
    public class WannSonntag
    {
        public static void Start()
        {
            DateTime dt= DateTime.Now;
            for (int i = 0; i < 21; i++)
            {
                if (dt.AddDays(i).ToString("ddd") == "So")
                {
                    Console.WriteLine($"In {i} Tagen ist ein weiterer Sonntag.");
                }
            }
        }
    }
}