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

    public static string GetText()
    {
        return "Pluck this little flower and take it, delay not! I fear lest it droop and drop into the dust." +
                "I may not find a place in thy garland, but honour it with a touch of pain from thy hand and pluck it." +
                "I fear lest the day end before I am aware, and the time of offering go by." +
                "Though its colour be not deep and its smell be faint, use this flower in thy service and pluck it while there is time.";
    }
}