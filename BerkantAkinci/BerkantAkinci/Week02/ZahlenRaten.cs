using System;
using System.Formats.Asn1;

namespace BerkantAkinci.Week02
{

    class ZahlenRaten
    {

        public static void PrintZahlenRaten(int Start, int Ende)
        {
            Random random = new Random();
            int rand = random.Next(Start, Ende);

            int UserInput = 0;

            System.Console.WriteLine("Willkommen beim super coolen Zahlen Ratespiel!");

            while (UserInput != rand) {

                UserInput = Convert.ToInt32(Console.ReadLine());

                if (UserInput > rand)
                {
                    System.Console.WriteLine("Die Random Zahl ist niedriger! \nVerusuche es nochmal!");
                }

                else if (UserInput < rand)
                {

                    System.Console.WriteLine("Die Random Zahl ist höherl! \nVersuche es nochmal!");
                }

                else
                {
                    System.Console.WriteLine("Gratuliere, du hast die Zahl erraten!");
                }
            }
            
        }
    }
}
