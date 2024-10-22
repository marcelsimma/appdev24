namespace BarbaraMarte.Week03;

class Charater
{

    public static void PrintUsedCharacterAmount()
    {

        Console.WriteLine("Please write a sentcense :");
        string? userInput = Console.ReadLine();

        int totalLetterAmount = 0;
        int totalDigitAmount = 0;
        int totalWhitespacesAmount = 0;
        int totalSignAmount = 0;

        char[] charArray = userInput.ToCharArray();

        foreach (char character in charArray)
        {
            if (char.IsLetter(character))
            {
                totalLetterAmount++;
            }
            else if (char.IsDigit(character))
            {
                totalDigitAmount++;
            }
            else if (char.IsWhiteSpace(character))
            {
                totalWhitespacesAmount++;
            }
            else
            {
                totalSignAmount++;
            }
        }
        Console.WriteLine($"Letters: {totalLetterAmount}\n" +
                          $"Numbers:{totalDigitAmount}\n" +
                          $"Empty Space: {totalWhitespacesAmount}\n" +
                          $"Special sing: {totalSignAmount}");
    }
}

