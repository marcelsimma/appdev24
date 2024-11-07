using System;

namespace SimonJochum.Week02
{
    public class Round
    {
        public static void Start()
        {
            double input;
            int decimalPlace;
            int place = 10;
            long bigNumber;
            Console.WriteLine("Hallo, gib eine beliebige Kommazahl ein.");
            input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Auf wie viele Nachkommastellen möchtest du runden?");
            decimalPlace = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < place; i++)
            {
                place *= 10;
            }
            bigNumber = Convert.ToInt64(input*place);
            if (bigNumber % 10 > 4)
            {
                bigNumber += 10;
            }
            bigNumber /= 10;
            input = Convert.ToDouble(bigNumber);
            input /= place / 10;

            Console.WriteLine("Hier ist deine gerundete Zahl: " + input);
        }
    }
}