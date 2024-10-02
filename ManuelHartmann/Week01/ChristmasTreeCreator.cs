using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text.Json.Serialization;


namespace ManuelHartmann
{

    public class ChristmasTreeCreator
    {
        static void ChristmasTreeCreator(string[] args)
        {
            UserInput();

            //Print('*', result); // Result -> anzahl Iterationen
            //Console.WriteLine();
        }
        public static void Print(char c, int size)
        {
            int iteration = 3;
            for (int i = 0; i < size; i++)
            {
                // Erfuellt die Anforderungen fuer den Anfang
                if (i == 0)
                {
                    // (size-1)/2 == size/2, da Int die Kommastelle nicht speichert.
                    Console.WriteLine(new string(' ', size / 2) + c);
                }
                // Erfuellt die Anforderungen fuer das Ende
                else if (i == size - 1)
                {
                    for (int j = 0; j < (size / 2); j++)
                    {
                        Console.Write(" ");
                        Console.Write("0");
                    }
                    Console.Write("\n");
                    Console.WriteLine(new string(' ', (size / 2) / 2) + new string('+', (size + 3) / 2));
                    Console.WriteLine(new string(' ', (size / 2) / 2) + new string('+', (size + 3) / 2));
                }
                // Erfuellt die Anforderungen fuer den OBEREN Koerper
                else if (i > 0 && i < (size - 1) / 2)
                {
                    Console.WriteLine(new string(' ', size / 2 - iteration / 2) + new string(c, iteration));
                    iteration += 2;
                }
            }
        }
        public static void PrintLine(char c, int length)
        {
            //for(int i = 0; i < length; i++)
            //{
            //    Console.Write(c);
            //}
            Console.WriteLine(new string(c, length));
        }

        public static void UserInput()
        {
            bool stop = false;
            string userResponse, responseUser = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Insert a number and I'll create a rhombus with it's size:");
                string response = Console.ReadLine();
                // Ueberprueft, ob es sich bei der Eingabe um eine GANZE Zahl handelt und ob sie UNGERADE ist!
                if ((int.TryParse(response, out int result)) && (result % 2 != 0))
                {
                    Print('*', result); // Result -> anzahl Iterationen
                }
                else
                {
                    Console.WriteLine("It's not a number or it's not a integer");
                }
                Console.WriteLine("Typ 'stop' to exit or anything else to continue:");
                userResponse = Console.ReadLine();
                responseUser = userResponse.ToLower();
                if (responseUser == "stop")
                {
                    stop = true;
                }
            } while (stop == false);

        }
    }
}




