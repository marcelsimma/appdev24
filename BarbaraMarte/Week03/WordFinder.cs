namespace BarbaraMarte.Week03;

class WordFinder
{

    public static void Print()
    {
        string textString = getText();

        Console.WriteLine("Which word are you looking for?");
        string? searchFor = Console.ReadLine();

        int pos = 0;
        int count = -1;

        do
        {
            pos = textString.IndexOf(searchFor, pos + 1);
            Console.WriteLine($"Count {count}, Next Index: {pos}");
            count++;
        } while (pos >= 0); 
    }

    public static string getText()
    {
        Console.WriteLine("Please enter a Text:");
        string? text;
        return text = Console.ReadLine();
    }
    public static void Letters() 
    {
        Console.WriteLine("Please enter a Text:");
        string? letters = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Enter the Letter you are looking for:");
        char searchFor = Convert.ToChar(Console.ReadLine());

        int pos = 0;
        int count = -1;

        do
        {
            pos = letters.IndexOf(searchFor, pos + 1);
            Console.WriteLine($"Count {count}, Next Index: {pos}");         // writes the position from the Letter wich you are swarching for. Count from 0 and not from 1!
            count++;
        } while (pos >= 0);

        Console.WriteLine();
        Console.WriteLine($@"Letter ""{searchFor}"" appears {count} times in:
        {letters}");

        int numberOfLetters = 0;
        foreach (char letter in letters)
        {
            numberOfLetters++;              // counts together all the chars in the code. Letters, additional character and numbers.
        }

        Console.WriteLine($"You have {letters.Count(char.IsLetter)} letters and {numberOfLetters} chars in your text.");

        
    }
}