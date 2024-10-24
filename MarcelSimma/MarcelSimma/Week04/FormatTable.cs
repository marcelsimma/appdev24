using System;

class FormatTable
{
    public static void Start()
    {
        // Daten
        string[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil",      "Daniel",  "Elmar", "Berkant", "Jonas", "Lucas" };
        string[] lastName =  { "Klein",   "Kinderdorfer",    "Al Elmenar", "Schmidt", "Simma" };
        int[] age =          { 40, 78, 5, 18, 81 };
        string[] place =     { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
        float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };


        for (int i = 0; i < firstName.Length; i++) {
            //Console.WriteLine(firstName[i]);
            //Console.WriteLine("{0, 20}", firstName[i]);
            //Console.WriteLine($"{firstName[i], -20} | {lastName[i], -20} | {age[i], 3} | {place[i], -20} | {Math.Round(distanceFromCapital[i], 2), 20:F2}" );
        
            if (i < firstName.Length) {
                Console.Write($"{firstName[i], -20} |");
            } else {
                Console.Write($"                     |");
            }
            if (i < lastName.Length) {
                Console.Write($"{lastName[i], -20} |");
            } else {
                Console.Write($"                     |");
            }
            if (i < age.Length) {
                Console.Write($"{age[i], 3} |");
            } else {
                Console.Write($"    |");
            }
            if (i < place.Length) {
                Console.Write($"{place[i], -20} |");
            } else {
                Console.Write($"                     |");
            }
            if (i < distanceFromCapital.Length) {
                Console.Write($"{distanceFromCapital[i], 20:F2} |");
            } else {
                Console.Write($"                     |");
            }
            Console.WriteLine();
        
        }
    }
}

