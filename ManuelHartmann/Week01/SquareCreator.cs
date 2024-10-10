
namespace ManuelHartmann.Week01 
{
    public class SquareCreator
    {
        static void Start(string[] args)
        {
            string response = "";
            Console.WriteLine("Please insert a number and i'll produce a square with it.");
            response = Console.ReadLine();
            if (int.TryParse(response, out int result))
            {
                // Beispielaufruf der Methode mit Größe 'result'
                ZeichneQuadrat(result); // Der Uebergabewert entspricht dem Eingabewert des Users.
            }
            else
            {
                Console.WriteLine("That's not a number!");
            }
        }

        static void ZeichneQuadrat(int groesse)
        {

                for (int j = 1; j <= groesse; j++)
                {
                    if (j == 1)
                    {
                        for (int ii = 0; ii < groesse; ii++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine(); // Zeilenumbruch nach jeder Zeile
                    }
                    else if (j == groesse)
                    {
                        for (int ij = 0; ij < groesse; ij++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine(); // Zeilenumbruch nach jeder Zeile
                    }
                    else
                    {
                        Console.Write("X");
                        for (int jj = 2; jj < groesse; jj++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("X");
                        Console.WriteLine(); // Zeilenumbruch nach jeder Zeile
                    }
                }
        }
    }
}




