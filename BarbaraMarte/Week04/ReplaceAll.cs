namespace BarbaraMarte.Week04;

class ReplaceAll
{

    public static void Print()
    {
        string startString = GetText();
        Console.WriteLine(startString);
        Console.WriteLine("Which do you want to correct?");
        string? WordYouChange = Convert.ToString(Console.ReadLine());
        Console.WriteLine("What do you want to have instead?");
        string? change = Convert.ToString(Console.ReadLine());
        string correctWord = startString.Replace(WordYouChange, change);
        Console.WriteLine($"Text with your new changes: {Environment.NewLine}'{correctWord}");

        string counting = CountingCharacter();
        Console.WriteLine(counting);
    }

    public static string CountingCharacter()
    {
        string textString = GetText();

        char[] textArray = textString.ToCharArray();
        int[] counter = new int[65536];

        foreach (char c in textArray)
        {
            counter[c]++;
        }
        for (int i = 0; i < counter.Length; i++)
        {
            if (counter[i] > 0)
            {
                Console.WriteLine($"Der Character {(char)i} kommt {counter[i]} vor. ");
            }
        }
        return "Ende";
    }

    public static void Numbers()
    {
        Console.WriteLine("Enter numbers: ");
        string? numbers = Console.ReadLine();

        string withoutAllNumbers = numbers;
        for (int i = 0; i <= 9; i++)
        {
            withoutAllNumbers = withoutAllNumbers.Replace(i.ToString(), "");
        }
        Console.WriteLine($"Without Numbers 0-9 {withoutAllNumbers}");

        string without1to9 = numbers;
        for (int i = 1; i <= 9; i++)
        {
            without1to9 = without1to9.Replace(i.ToString(), "");
        }
        Console.WriteLine($"Without 1-9 {without1to9}");

        string without2to4 = numbers;
        for (int i = 2; i <= 4; i++)
        {
            without2to4 = without2to4.Replace(i.ToString(), "");
        }
        Console.WriteLine($"Without Numbers 2-4 {without2to4}");

        string without1to3and6to9 = numbers;
        for (int i = 1; i <= 3; i++)
        {
            without1to3and6to9 = without1to3and6to9.Replace(i.ToString(), "");
        }
        for (int i = 6; i <= 9; i++)
        {
            without1to3and6to9 = without1to3and6to9.Replace(i.ToString(), "");
        }
        Console.WriteLine($"Without Numbers 1-3 and 6-9 {without1to3and6to9}");
    }


    public static string GetText()
    {
        return "Pluck this little flower and take it, delay not! I fear lest it droop and drop into the dust." +
                "I may not find a place in thy garland, but honour it with a touch of pain from thy hand and pluck it." +
                "I fear lest the day end before I am aware, and the time of offering go by." +
                "Though its colour be not deep and its smell be faint, use this flower in thy service and pluck it while there is time.";
    }
}