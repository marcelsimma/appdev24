using System;

namespace JonasWehinger.Week04
{
    class Arbeitstage
    {
        public static int GetWorkdays(int jahr, int monat)
        {
            int arbeitstage = 0; 

            
            int tageImMonat = DateTime.DaysInMonth(jahr, monat);

            
            for (int tag = 1; tag <= tageImMonat; tag++)
            {
                DateTime aktuellerTag = new DateTime(jahr, monat, tag); 

                
                if (aktuellerTag.DayOfWeek >= DayOfWeek.Monday && 
                    aktuellerTag.DayOfWeek <= DayOfWeek.Friday)
                {
                    arbeitstage++; 
                }
            }

            return arbeitstage; 
        }

        public static void Start()
        {
            int jahr = 2024; 
            int monat = 10;  
            int arbeitstage = GetWorkdays(jahr, monat); 
            Console.WriteLine($"Der Monat Oktober {jahr} hat {arbeitstage} Arbeitstage."); 
        }
    }
}
