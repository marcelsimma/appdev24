
namespace ManuelHartmann.Week02
{

    public class Reverse_Randomize_String
    {
        static void Start(string[] args)
        {
            string respond = "Hello";
            // Beide WriteLines haben das selbe Ergebnis! Ich übergebe an die Methode den 'string'="Hello my dear."
            // Der definierte 'string reverse' ist nun "Hello my dear". Nun kann ich in der Methode damit arbeiten.
            // Die Variable die ich am Ende 'return' mache, ist Schlussendlich die 'ReverseRespond-Methode', wenn ich sie ausgebe.
            string result = ReverseRespond(respond);

            Console.WriteLine($"The reversed UserInput: \"{result}\"");
            Console.WriteLine($"The reversed UserInput: \"{result}\"");
            // Console.WriteLine($"The reversed UserInput: \"{ReverseRespond("Hello my dear.")}\"");
            Console.WriteLine($"The randomized UserInput: \"{RandomizeRespond(respond)}\"");
            Console.WriteLine($"The randomized UserInput: \"{RandomizeResponding(respond)}\"");
        }
        // ReverseRespond = ReverseRespondFor
        static string ReverseRespond(string transfer)
        {
            // Transfer all single 'chars' from 'transfer' to Array.
            char[] chars = transfer.ToCharArray();
            // Reverse Array.
            Array.Reverse(chars);
            string reversed = new string(chars);
            return reversed;
        }
        // ReverseRespond = ReverseRespondFor
        static string ReverseRespondFor(string transfer)
        {
            string reversing = "";
            for (int i = transfer.Length - 1; i >= 0; i--)
            {
                // Add single 'char' to 'string - reversing'. String ist bereits reversed, weil beim Index von Oben nach Unten gehe.
                reversing += transfer[i];   
            }
            return reversing;
        }
        //  Chooses random 'chars' out of 'transfer' but this method doesn't avoid that specific 'chars' can't be chooses several times.
        public static string RandomizeRespond(string transfer)
        {
            string randomizedText = "";
            for (int i = transfer.Length - 1; i >= 0; i--)
            {
                int randomNumber = RandomGenerator(transfer.Length);
                randomizedText += transfer[randomNumber];
            }
            return randomizedText;
        }
        //  Generates a random number ranging between (0 - respond.Length).
        public static int RandomGenerator(int stringLength)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, stringLength);
            return randomNumber;
        }
        public static string RandomizeResponding(string transfer)
        {
            // Transfer all single 'chars' from 'transfer' to Array.
            char[] chars = transfer.ToCharArray();
            //  OrderBy(c => random.Next()): This LINQ method is used to sort or order the characters in the array.
            //  c => random.Next() is a lambda expression that generates a random number for each character c.This
            //  causes the OrderBy method to sort the characters based on the random numbers, effectively shuffling them.
            //  ToArray(): After the OrderBy method processes the characters, it returns an IEnumerable<char>, which is
            //  converted back to an array using ToArray().
            chars = chars.OrderBy(c => RandomGenerator(transfer.Length)).ToArray();
            //  What it does: This converts the shuffled character array chars back into a string.
            //  The new string(chars) constructor creates a new string from the array of characters.
            string randomized = new string(chars);
            return randomized;
        }
    }
}



