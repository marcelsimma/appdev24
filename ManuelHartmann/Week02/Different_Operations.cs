
namespace ManuelHartmann.Week02
{

    public class Different_Operations
    {
        static void Start(string[] args)
        {
            MenuCases();
            ReadNextInt();
            ReadNextDouble();
            ReadNextChar();
        }
        public static void MenuCases()
        {
            string response = "";

            do
            {
                Console.Clear();
                BuildMenu();
                response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        ReadNextInt();
                        break;
                    case "2":
                        ReadNextDouble();
                        break;
                    case "3":
                        ReadNextChar();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option. Continue by pressing \"enter\".");
                        Console.ReadLine();
                        break;
                }

            } while (response != "exit");
        }

        public static void BuildMenu()
        {
            Console.WriteLine("1. Insert you integer: ");
            Console.WriteLine("2. Insert you double: ");
            Console.WriteLine("3. Insert you char: ");
            Console.WriteLine("Please choose an option by pressing 1, 2, 3 or \"enter\".");
        }

        //  Die eingegebene Methode überprüft zuerst, ob es sich beim UserInput um eine Zahl handelt, wenn es so ist, ist sie auch
        //  der Rueckgabewert der Methode. 
        public static int ReadNextInt()
        {
            do
            {
                Console.WriteLine("Please insert a integer: ");
                string respond = Console.ReadLine();
                if(int.TryParse(respond, out int number))
                {
                    return number;
                }
            }while (true);

            // Die do-while Schleife wird beendet, sobald ein 'return' ausgeführt wird! Somit muss die Bedingung while(true) 
            // nicht aus 'false' gesetzt werden! -> Wird so lange ausgeführt, bis ein 'return' zurueckkommt.
            return 0;
        }

        public static double ReadNextDouble()
        {
            do
            {
                Console.WriteLine("Please insert a double: ");
                string respond = Console.ReadLine();
                if (double.TryParse(respond, out double numberDouble))
                {
                    return numberDouble;
                }
            } while (true);

            // Die do-while Schleife wird beendet, sobald ein 'return' ausgeführt wird! Somit muss die Bedingung while(true) 
            // nicht aus 'false' gesetzt werden! -> Wird so lange ausgeführt, bis ein 'return' zurueckkommt.
            return 0.5;
        }

        public static char ReadNextChar()
        {
            do
            {
                Console.WriteLine("Please insert a char: ");
                string respond = Console.ReadLine();
                if (char.TryParse(respond, out char c))
                {
                    return c;
                }
            } while (true);

            // Die do-while Schleife wird beendet, sobald ein 'return' ausgeführt wird! Somit muss die Bedingung while(true) 
            // nicht aus 'false' gesetzt werden! -> Wird so lange ausgeführt, bis ein 'return' zurueckkommt.
            return 'c';
        }
    }
}




