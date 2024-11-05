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

    // 2. first weekday of the month
    DateTime firstDay = new DateTime(today.Year, today.Month, 1);
    DayOfWeek firstDayOfMonth = firstDay.DayOfWeek;

    /*
    alternative program:
    DateTime firstDay2 = today.AddDays(today.Day * -1 + 10;) 
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