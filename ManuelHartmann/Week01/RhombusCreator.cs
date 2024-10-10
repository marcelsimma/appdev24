
namespace ManuelHartmann.Week01
{

    public class RhombusCreator
    {
        static void Start(string[] args)
        {
            UserInput();

            //Print('*', result); // Result -> anzahl Iterationen
            //Console.WriteLine();
        }
        public static void Print(char c, int size)
        {
            int iteration = 1;
            for (int i = 0; i < size; i++)
            {
                if ((i == 0) || (i == size - 1))
                {
                    // (size-1)/2 == size/2, da Int die Kommastelle nicht speichert.
                    Console.WriteLine(new string(' ', size / 2) + c + new string(' ', size / 2));
                }
                // Erfuellt die Anforderungen fuer die mittlere Zeile
                else if (i == size/2)
                {
                    Console.WriteLine(c + new string(' ', size - 2) + c);
                }
                // Erfuellt die Anforderungen fuer den OBEREN Koerper
                else if (i > 0 && i < (size - 1) / 2)
                {
                    Console.WriteLine(new string(' ', (size - 1) / 2 - i) + c + new string(' ', iteration) + c);
                    iteration += 2;
                }
                // Erfuellt die Anforderungen fuer den UNTEREN Koerper
                else
                {
                    iteration -= 2;
                    Console.WriteLine(new string(' ', i - (size - 1) / 2) + c + new string(' ', iteration) + c);
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




