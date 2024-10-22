using System;

namespace CheyenneHarbarth.Week02
{

    class Zahlenraten
    {

        public static void StartGame(int start, int ende)
        {

            Random random = new Random();
            int rand = random.Next(start, ende);
            Console.WriteLine($"Willkommen zum besten Zahlen-Ratespiel! Tippe eine Zahl zwischen {start} und {ende}");
            int userinput = -1;
            while (userinput != rand)
            {
                userinput = Convert.ToInt32(Console.ReadLine());
                if (userinput < rand)
                {
                    Console.WriteLine($"Die Zahl ist größer als {userinput}");
                }
                else if (userinput == rand)
                {
                    Console.WriteLine($"Prima! :D Du hast die Zahl erraten. Die Zahl ist {rand}");
                }
                else
                {
                    Console.WriteLine($"Die Zahl ist kleiner als {userinput}");
                }
            }
        }
    }
}