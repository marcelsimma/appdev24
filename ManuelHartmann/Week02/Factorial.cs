
namespace ManuelHartmann.Week02
{

    public class Factorial
    {
        static void Start(string[] args)
        {
            long fact = 1;
            string response = "";
            Console.WriteLine("Please enter a number and I'll output the factorial of it.");
            response = Console.ReadLine();
            if (int.TryParse(response, out int factorial))
            {
                Console.Clear();
                for (int i = 1; i <= factorial; i++)
                {
                    if (i == factorial)
                    {
                        fact *= i;
                    }
                    else
                    {
                        fact *= i;
                        Console.Write(fact + "*");
                    }
                }
                Console.WriteLine();
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("Result = " + fact);
            }
        }
    }
}




