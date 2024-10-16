namespace BarbaraMarte.Ausbildung;

class Program
{
    public static void Rechnen.printRechnen()
    {
        int amountCent = 57; // Must not be bigger than 99   0 <= x < 100  
        int amountEuro = 499;
        //Ausgabe
        Console.WriteLine($"{amountEuro} Euro und {amountCent} Cent durch die folgenden Scheine und Münzen zusammengesetzt werden");

        // Größte Stückelung suchen und vom Wert abziehen. Wird mit dem Ergebniss wiederholt bis es 0 ergibt.

        // Euro Berechnen
        while (amountEuro > 0) //dinge die in der Runden Klammer bei der WHILE Schleife stehen heißen "Laufbedingungen"
        {
            if (amountEuro >= 500)
            {
                Console.WriteLine("1x 500€");
                amountEuro = amountEuro - 50; //PC liest die =,Zuweisungs,assigment von Rechts nach Links
            }
            else if (amountEuro >= 200)
            {
                Console.WriteLine("1x 200€");
                amountEuro = amountEuro - 200;
            }
            else if (amountEuro >= 100)
            {
                Console.WriteLine("1x 100€");
                amountEuro = amountEuro - 100;
            }
            else if (amountEuro >= 50)
            {
                Console.WriteLine("1x 50€");
                amountEuro = amountEuro - 50;
            }
            else if (amountEuro >= 20)
            {
                Console.WriteLine("1x 20€");
                amountEuro = amountEuro - 20;
            }
            else if (amountEuro >= 10)
            {
                Console.WriteLine("1x 10€");
                amountEuro = amountEuro - 10;
            }
            else if (amountEuro >= 5)
            {
                Console.WriteLine("1x 5€");
                amountEuro = amountEuro - 5;
            }
            else if (amountEuro >= 2)
            {
                Console.WriteLine("1x 2€");
                amountEuro = amountEuro - 2;
            }
            else if (amountEuro >= 1)
            {
                Console.WriteLine("1x 1€");
                amountEuro = amountEuro - 1;
            }


            // Cent ausrechnen
            while (amountCent > 0) // 
            {
                if (amountCent >= 50)
                {
                    Console.WriteLine("1x 50€");
                    amountCent = amountCent - 50;
                }
                else if (amountCent >= 20)
                {
                    Console.WriteLine("1x 20€");
                    amountCent = amountCent - 20;
                }
                else if (amountCent >= 10)
                {
                    Console.WriteLine("1x 10€");
                    amountCent = amountCent - 10;
                }
                else if (amountCent >= 5)
                {
                    Console.WriteLine("1x 5€");
                    amountCent = amountCent - 5;
                }
                else if (amountCent >= 2)
                {
                    Console.WriteLine("1x 2€");
                    amountCent = amountCent - 2;
                }
                else if (amountCent >= 1)
                {
                    Console.WriteLine("1x 1€");
                    amountCent = amountCent - 1;
                }
            }

        }
    }
}