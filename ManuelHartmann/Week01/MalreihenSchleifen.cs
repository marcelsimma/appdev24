
namespace ManuelHartmann.Week01
{

    public class MalreihenSchleifen 
    {
        static void Start(string[] args)
        {
            int lowerNumberInt, higherNumberInt = 0;
            string lowerNumber, higherNumber = "";
            Console.WriteLine("Give me a rang in which u want to know the integer numbers. \nPlease insert the min number:");
            lowerNumber = Console.ReadLine();
            Console.WriteLine("Please insert the max number:");
            higherNumber = Console.ReadLine();
            if (int.TryParse(lowerNumber, out lowerNumberInt))
            if (int.TryParse(higherNumber, out higherNumberInt))

            for (int i = lowerNumberInt; i <= higherNumberInt; i++) 
            {
                if (i % 2 == 0) // Modulo-Oerator
                    Console.WriteLine($"The number: {i} is a integer number!");
                else 
                {
                    Console.WriteLine($"{i} -> Not a integer number!");
                }
            }

            int ii = lowerNumberInt;
            while (ii <= higherNumberInt)
            {
                if (ii % 2 == 0) // Modulo-Oerator 
                    Console.WriteLine($"The number: {ii} is a integer number!");
                else 
                {
                    Console.WriteLine($"{ii} -> Not a integer number!");
                }
                ii++;
            }

            int ij = lowerNumberInt;
            do
            {
                if (ij % 2 == 0) // Modulo-Oerator
                    Console.WriteLine($"The number: {ij} is a integer number!");
                else 
                {
                    Console.WriteLine($"{ij} -> Not a integer number!");
                }
                ij++;
            } while (ij <= higherNumberInt);
        }
    }
}




