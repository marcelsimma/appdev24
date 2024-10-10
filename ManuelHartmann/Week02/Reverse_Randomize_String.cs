
namespace ManuelHartmann.Week02
{

    public class Reverse_Randomize_String
    {
        static void Start(string[] args)
        {
            string respond = "Hello";

            string result = ReverseRespond(respond);

            Console.WriteLine($"The reversed UserInput: \"{result}\"");
            Console.WriteLine($"The reversed UserInput: \"{result}\"");
            Console.WriteLine($"The randomized UserInput: \"{RandomizeRespond(respond)}\"");
            Console.WriteLine($"The randomized UserInput: \"{RandomizeResponding(respond)}\"");
        }
        static string ReverseRespond(string transfer)
        {
            char[] chars = transfer.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);
            return reversed;
        }
        static string ReverseRespondFor(string transfer)
        {
            string reversing = "";
            for (int i = transfer.Length - 1; i >= 0; i--)
            {
                reversing += transfer[i];   
            }
            return reversing;
        }
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
        public static int RandomGenerator(int stringLength)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, stringLength);
            return randomNumber;
        }
        public static string RandomizeResponding(string transfer)
        {
            char[] chars = transfer.ToCharArray();
            chars = chars.OrderBy(c => RandomGenerator(transfer.Length)).ToArray();
            string randomized = new string(chars);
            return randomized;
        }
    }
}




