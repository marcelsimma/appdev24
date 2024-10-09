using System;

namespace CheyenneHarbarth.Week02
{

    class Einkaufsliste
    {

        public static int PrintList()
        {

            while (true)
            {
                Console.WriteLine("Was musst du noch einkaufen?");
                string userinput = Console.ReadLine();
                Console.WriteLine($"Wieviel brauchst du von {userinput}");
                string muchness = Console.ReadLine();

                if (int.TryParse(muchness, out int muchness2))
                {
                    return muchness2;
                }
                else
                {
                    Console.WriteLine("Gib eine Zahl ein!");
                }
                Console.WriteLine($"Einkaufsliste: \n {muchness} {userinput}");
            }
        }
    }
}