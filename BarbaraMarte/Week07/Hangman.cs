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
                }
            }
            foreach (char out1 in output)
            {
                Console.Write(out1 + " ");
            }
        } while (letters != input.Count);
    }
}