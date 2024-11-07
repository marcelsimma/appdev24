using System;

namespace BerkantAkinci.Week02
{

    class Pi
    {

        public static void PrintPi()
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
