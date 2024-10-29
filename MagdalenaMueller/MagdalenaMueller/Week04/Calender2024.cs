using System;
using System.Globalization;

namespace MagdalenaMueller.Week04
{
    public class Calendar2024
    {
        public static void CalenderProgramm()
        {
            int year = 2024;
            int month = 1;
            int day = 1;

            int daysInMonth = DateTime.DaysInMonth(year, month);
            string monthName = new DateTime(year, month, 1).ToString("MMMM", new CultureInfo("de-DE"));

            string seperateString = "+----+----+----+----+----+----+----+";
            
            List<int> days = new List<int>();

            while(month <= 12)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{monthName}:");
                Console.ResetColor();

                Console.WriteLine("| MO | DI | MI | DO | FR | SA | SO |");
                Console.WriteLine(seperateString);

                
                for(int i = 0; i < daysInMonth; i++)
                {
                    days.Add(day);
                    day++;
                }
                Writecalander();
                Console.WriteLine("\n");
                
                month++;
                day = 1;
                monthName = new DateTime(year, month, 1).ToString("MMMM", new CultureInfo("de-DE"));
                days = new List<int>();
                
            }
            
            void Writecalander()
            {
                for(int i = 0; i < daysInMonth; i++)
                {
                    if(i == 6 || i == 13 || i == 20 || i == 27 || i == 33)
                    {
                        if(days[i] < 10)
                        {
                            Console.Write($"|  {days[i]} ");
                        }
                        else
                        {
                            Console.Write($"| {days[i]} ");
                        }
                        Console.WriteLine("|");
                        Console.WriteLine(seperateString);
                    }
                    else
                    {
                        if(days[i] < 10)
                        {
                            Console.Write($"|  {days[i]} ");
                        }
                        else
                        {
                            Console.Write($"| {days[i]} ");
                        }
                    }
                }
            
            }
        }
    }   
}