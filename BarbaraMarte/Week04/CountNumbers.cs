namespace BarbaraMarte.Week04;

class CountNumber
{

    public static void Print()
    {
        // Console.WriteLine("Please enter a sentense: ");
        string letters = GetText();

        int numberOfLetters = 0;
        foreach (char letter in letters)
        {
            numberOfLetters++;
        }
        Console.WriteLine($"You have {numberOfLetters} chars in your Text.");

        int totalDigitAmount = 0;
        int totalSignAmount = 0;

        foreach (char letter in letters)
        {
            if (char.IsDigit(letter))
            {
                totalDigitAmount++;
            }
            if (char.IsLetter(letter))
            {
                totalSignAmount++;
            }
        }
        Console.WriteLine($"Dotal Digits Amount: {totalDigitAmount} \nTotal sign Amount: {totalSignAmount}");
    }

    public static void CountingCharacter()
    {
        string textString = GetText();
        int max = char.MaxValue;
        int[] count = new int[max];

        foreach (char c in textString)
        {
            count[Convert.ToInt32(c)]++;       // counts each character
        }

        for (int i = 0; i < max; i++)
        {
            if (count[i] > 0)
            {
                Console.WriteLine($"{(char)i}: {count[i]}"); // returns character and amount
            }
        }
    }

    public static string GetText()
    {
        return "1. I Love food, 2. but i don't like fish";
    }
}