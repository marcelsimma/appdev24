using System;

/*
Aufgabe: Pi
------------------
Pi = 4/1 - 4/3 + 4/5 - 4/7 + 4/9 ...
*/

namespace OliverBedogg.Week02
{

    public class Pi
    {
        public static void Start()
        {
            // Ansatz 1: + und - separat durchführen
            int loop = 1;
            int limit = 4;
            bool add = true;

            do
            {
                // modal
                if (loop % 2 != 0)
                {
                    Console.WriteLine("modal: plus");
                }
                else
                {
                    Console.WriteLine("modal: minus");
                }

                // bool
                if (add)
                {
                    Console.WriteLine("add: true");
                }
                else
                {
                    Console.WriteLine("add: false");
                }
                add = !add;

                loop++;
            } while (loop <= limit);
        }
    }
}