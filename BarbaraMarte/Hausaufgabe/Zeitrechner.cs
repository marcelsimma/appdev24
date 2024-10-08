namespace BarbaraMarte.Hausaufgabe;

class Zeitrechner
{
    public static void PrintZeitrechner()
    {
        double num2 = 60;

        Console.WriteLine("Calculate from Minutes to Hour Press /, Calculate from Hours to Minutes Press *");
        char operation = Console.ReadLine()[0];

        

        {
            Console.WriteLine("Write amount of Minutes:");

            string input = Console.ReadLine();

            double num1;

            if (double.TryParse(input, out num1))
            {
                Console.WriteLine($" {num1} / {num2} = {num1 / num2}");
            }

            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number");
            }
        }

       
        {
            Console.WriteLine("Write amount of Hours:");

            string input = Console.ReadLine();

            double num1;

            if (double.TryParse(input, out num1))
            {
                Console.WriteLine($" {num1} * {num2} = {num1 * num2}");
            }

            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number");
            }
        }

        {       // Von Herr Hauser Geschriebener Code als Vorlage
            Console.WriteLine("Bitte Anzahl an Minuten angeben:");
            double minutes = Convert.ToDouble(Console.ReadLine());
            double hoursRounded = Math.Round(minutes / 60, 2);
            Console.WriteLine($"Das sind {hoursRounded} Stunden!");

        }

    }

}
