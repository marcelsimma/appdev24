using BarbaraMarte.Week03;

namespace BarbaraMarte.Week07;

class Hangman
{
    static List<char> input = new List<char>();
    static List<char> output = new List<char>();
    public static void Print()
    {
        input.Clear();
        output.Clear();
        Console.WriteLine("Enter the secret word");
        input = Console.ReadLine().ToLower().ToList();
        for (int i = 0; i < input.Count; i++)
        {
            output.Add('_');
        }

        Console.Clear();
        Console.WriteLine(String.Concat(Enumerable.Repeat("_ ", input.Count)));
        AddLetter();
    }
    public static void AddLetter()
    {
        int letters = 0;
        do
        {
            Console.WriteLine("Chose a letter");
            char choice = Convert.ToChar(Console.ReadLine());

            int one = 0;

            for (int i = 0; i < input.Count; i++)
            {
                if (choice == input[i])
                {
                    output[i] = choice;
                    one++;
                    letters++;
                    if (one == 1)
                    {
                        Console.WriteLine(choice + " was correct!");
                    }
                }

                else if (choice != input[i] && i == input.Count - 1)
                {
                    Console.WriteLine("wrong");
                    WrongInput();
                }
            }
            foreach (char out1 in output)
            {
                Console.Write(out1 + " ");
            }
        } while (letters != input.Count);
    }
    static int Mistakes = 0;
    internal static void WrongInput()
    {
        Mistakes++;
        Console.Clear();
        if (Mistakes > 3)
        {
            Console.WriteLine("   _____________________");
        }
        if (Mistakes > 4)
        {
            Console.WriteLine("   |   /               |\n   |  /                |\n   | /                 |\n   |/                 _|_");
        }
        else if (Mistakes > 2)
        {
            Console.WriteLine("   |   /\n   |  /\n   | /\n   |/");
        }
        if (Mistakes > 9)
        {
            Console.WriteLine("   |                 (°-°)");
        }
        else if (Mistakes > 5)
        {
            Console.WriteLine("   |                 (^-^)");
        }
        if (Mistakes > 9)
        {
            Console.WriteLine("   |                ~~~|~~~\n   |                   |\n   |                   |\n   |                  / \\\n   |                 /   \\\n   |           /\\  /\\  /\\  /\\  /\\  \n   |          /  \\/  \\/  \\/  \\/  \\");
        }
        else if (Mistakes > 8)
        {
            Console.WriteLine("   |                ~~~|~~~\n   |                   |\n   |                   |\n   |                  / \\\n   |                 /   \\\n   |\n   |");
        }
        else if (Mistakes > 7)
        {
            Console.WriteLine("   |                ~~~|~~~\n   |                   |\n   |\n   |\n   |\n   |\n   |");
        }
        else if (Mistakes > 6)
        {
            Console.WriteLine("   |                   |\n   |                   |\n   |\n   |\n   |\n   |\n   |");
        }
        else if (Mistakes > 1)
        {
            Console.WriteLine("   |\n   |\n   |\n   |\n   |\n   |");

        }
        if (Mistakes > 9)
        {
            Console.WriteLine(" __|__       (    (°)      (°)    )\n/_____\\~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
        else if (Mistakes > 0)
        {
            Console.WriteLine(" __|__ \n/_____\\~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
