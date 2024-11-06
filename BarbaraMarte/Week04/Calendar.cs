using System;

namespace BarbaraMarte.Week04;

class Calendar
{
  public static void Print()
  {
    /*
      Vorangehensweise:
      1. How many days has a month
      2. first weekday of the month
      3. today
      4. table
      5. first day of the week (sunday or monday)
    */

    // 3. today
    DateTime today = DateTime.Today;

    // 1. amount of days in the month
    int daysInMonth = DateTime.DaysInMonth(today.Year, today.Month);
    Console.WriteLine(daysInMonth);

    // 2. first weekday of the month
    DateTime firstDay = new DateTime(today.Year, today.Month, 1);
    Console.WriteLine(firstDay);
    DayOfWeek firstDayOfMonth = firstDay.DayOfWeek;
    Console.WriteLine((int)firstDayOfMonth);

    /*
    alternative program:
    DateTime firstDay2 = today.AddDays(today.Day * -1 + 10;) 


    if (firstDayOfMonth == 0)   if it is working then it puts the sunday in position 7 that it is printed out in the list 
    {
      firstDayOfMonth = 7;
    }
    */

    // 4. table
    Console.WriteLine("| Mo | Di | Mi | Do | Fr | Sa | So |");

    // negative fields are not printed
    int counter = (int)firstDayOfMonth * -1 + 2;

    for (int i = 0; i < 7; i++)
    {
      for (int j = 0; j < 7; j++)
      {
        if (counter == today.Day)
        {
          Console.Write($"| {counter,2}*");
        }
        else if (counter > daysInMonth || counter < 1)
        {
          Console.Write("|    ");
        }
        else
        {
          Console.Write($"| {counter,2} ");
        }
        counter++;
      }
      Console.WriteLine("|");
      if (counter > daysInMonth)
      {
        break;
      }
    }
  }
}
/* public static void Start()
   {

      // heutiges Datum
      DateTime today = DateTime.Today;

      // welcher Wochentag ist heute?
      DayOfWeek todaysDay = today.DayOfWeek;
      Console.WriteLine(today.DayOfWeek);




      // erster Tag des Monats
      DateTime firstDayOfMonth = new DateTime(2024, 11, 1);
      Console.WriteLine((int)firstDayOfMonth.DayOfWeek);


      // Kalenderwoche

      // kalenderspezifische Kulturinformation für Österreich und die Deutsche Sprache
      CultureInfo aut = new CultureInfo("us-US");

      // der erste Tag in der Woche in Österreich
      Console.WriteLine(aut.DateTimeFormat.FirstDayOfWeek);

      // Regeln für den Umgang mit Kalenderwochen in Österreich
      CalendarWeekRule cwr = aut.DateTimeFormat.CalendarWeekRule;

      int week = aut.Calendar.GetWeekOfYear(today, cwr, aut.DateTimeFormat.FirstDayOfWeek);

      Console.WriteLine(week);


   }
       */
