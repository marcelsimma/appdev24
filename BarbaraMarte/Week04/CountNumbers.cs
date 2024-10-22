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



        //onsole.WriteLine($"Capital Letters: {C} \n lower Letters: {d}");
        Console.WriteLine($"Dotal Digits Amount: {totalDigitAmount} \nTotal sign Amount: {totalSignAmount}");


    }

    public static string GetText()
    {
        return "1. I Love food, 2. but i don't like fish";
    }
}