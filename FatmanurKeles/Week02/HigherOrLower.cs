using System;

namespace FatmanurKeles.Week02
{
    public class HigherOrLower
    {
        public static void HigherOr()
        {
            int guess;
            int random;
            Random rnd = new Random();
            random = rnd.Next(0, 100);

            do
            {
                Console.WriteLine("Geben Sie eine Zahl zwischen 0 - 100 ein: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess < random)
                {
                    Console.WriteLine("Die eingegebene Zahl ist zu niedrig!");
                }

                else if (guess > random)
                {
                    Console.WriteLine("Die eingegebene Zahl ist zu hoch!");
                }

                else if (guess == random)
                {
                    Console.WriteLine("Du hast die richtige Zahl erraten!");
                }

            } while
               (guess != random);
        }
    }
}


