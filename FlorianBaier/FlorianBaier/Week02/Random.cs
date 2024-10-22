namespace FlorianBaier.Week02
{

    public class StringMethod
    {
        public static void First()
        {
            string lorem = "Lorem";
            Console.WriteLine("Textlänge: " + lorem.Length);
            Console.WriteLine("in Großbuchstaben: " + lorem.ToUpper());
            Console.WriteLine("in Kleinbuchstaben: " + lorem.ToLower());
            Console.WriteLine("--------------------");

            string ipsum = "Lorem " + "ipsum";
            Console.WriteLine("string: " + ipsum);
            ipsum = "10" + 20;
            Console.WriteLine("string: " + ipsum);

            string loremIpsum = string.Concat(ipsum, " dolor", " sit", " amet");
            Console.WriteLine("string: " + loremIpsum);
            loremIpsum = string.Concat(ipsum, 10, 20);
            Console.WriteLine("string: " + loremIpsum);
            Console.WriteLine("--------------------");

            lorem = "Lorem";
            ipsum = "ipsum";
            loremIpsum = $"{lorem} {ipsum}";
            Console.WriteLine("string: " + loremIpsum);
            Console.WriteLine("--------------------");

            string quote = "The more you learn. The more you earn.";
            for (int i = 0; i < quote.Length; i++)
            {
                Console.WriteLine($"Character {i}: " + quote[i]);
            }
            Console.WriteLine("--------------------");

            Console.WriteLine("index von \"learn\" " + quote.IndexOf("learn"));

            Console.WriteLine("index von \"earn\" " + quote.IndexOf("earn"));
            Console.WriteLine("index von \"earn\" " + quote.IndexOf("life"));
            Console.WriteLine("--------------------");

            Console.WriteLine("Substring ab Index: " + quote.Substring(20));
            Console.WriteLine("--------------------");
        }

        public static void StringExercise()
        {
            string word = "Random";
            Console.WriteLine($"Random: {word} --> " + RandomGenerator(word));
            Console.WriteLine("--------------------");

            word = "Hello";
            Console.WriteLine($"Random: {word} --> " + RandomGenerator(word));
            Console.WriteLine("--------------------");
        }

        public static string RandomGenerator(string word)
        {
            string randomString = "";
            Random rnd = new Random();
            string tempString = word;

            for (int i = 0; i < word.Length; i++)
            {
                int randomPosition = rnd.Next(0, tempString.Length);
                char randomCharacter = tempString[randomPosition];
                randomString += randomCharacter;

                tempString = String.Concat(
                    tempString.Substring(0, randomPosition),
                    tempString.Substring(randomPosition + 1)
                );
                Console.WriteLine($"Residual: {i} --> " + tempString);
            }

            return randomString;
        }

        
    }
}