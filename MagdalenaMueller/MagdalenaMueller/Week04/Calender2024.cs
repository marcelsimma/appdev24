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
            int daysPlus = 0;
            
            DateTime date = new DateTime(year, month, 1);

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

                if(date.DayOfWeek == DayOfWeek.Tuesday)
                {
                    daysPlus = 1;
                }
                if(date.DayOfWeek == DayOfWeek.Wednesday)
                {
                    daysPlus = 2;
                }
                if(date.DayOfWeek == DayOfWeek.Thursday)
                {
                    daysPlus = 3;
                }
                if(date.DayOfWeek == DayOfWeek.Friday)
                {
                    daysPlus = 4;
                }
                if(date.DayOfWeek == DayOfWeek.Saturday)
                {
                    daysPlus = 5;
                }
                if(date.DayOfWeek == DayOfWeek.Sunday)
                {
                    daysPlus = 6;
                }
                
                for(int i = 0; i < daysInMonth + daysPlus; i++)
                {
                    if(day == 1)
                    {
                        if(date.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            days.Add(0);
                            i++;
                        }
                        if(date.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            days.Add(0);
                            days.Add(0);
                            i = i +2;
                        }
                        if(date.DayOfWeek == DayOfWeek.Thursday)
                        {
                            days.Add(0);
                            days.Add(0);
                            days.Add(0);
                            i = i+3;
                        }
                        if(date.DayOfWeek == DayOfWeek.Friday)
                        {
                            days.Add(0);
                            days.Add(0);
                            days.Add(0);
                            days.Add(0);
                            i = i+4;
                        }
                        if(date.DayOfWeek == DayOfWeek.Saturday)
                        {
                            days.Add(0);
                            days.Add(0);
                            days.Add(0);
                            days.Add(0);
                            days.Add(0);
                            i = i+5;
                        }
                        if(date.DayOfWeek == DayOfWeek.Sunday)
                        {
                            days.Add(0);
                            days.Add(0);
                            days.Add(0);
                            days.Add(0);
                            days.Add(0);
                            days.Add(0);
                            i = i+6;
                        }
                    }
                    days.Add(day);
                    day++;
                }
                Writecalander();
                
                Console.WriteLine("\n");
                
                month++;
                day = 1;
                daysPlus = 0;
                date = new DateTime(year, month, 1);
                daysInMonth = DateTime.DaysInMonth(year, month);
                monthName = new DateTime(year, month, 1).ToString("MMMM", new CultureInfo("de-DE"));
                days = new List<int>();
                 
            }
            
            void Writecalander()
            {
                for(int i = 0; i < daysInMonth + daysPlus; i++)
                {
                    if(i == 6 || i == 13 || i == 20 || i == 27 || i == 34)
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
                            if(days[i] == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write($"|  {days[i]} ");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write($"|  {days[i]} ");
                            }
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