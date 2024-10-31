namespace BarbaraMarte.Week04;

class DatenTabelle
{

    public static void Print()
    {
        String[] firtstName = { "Alfons", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
        String[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
        int[] age = { 40, 78, 5, 17, 81 };
        string[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
        double[] distanceFromCapital = { 0f, 654.40f, 12.457634366f, 120.0f, 119.9999f };
        int i = 0;

        /*
        for (int j = 0; j < distanceFromCapital.Length; j++)            you don't need this formel if you put a :F2 behind the position
        {
            distanceFromCapital[j] = (double)Math.Round(distanceFromCapital[j], 2);        // auf zwei Kommastellen Runden.
        }
        */

        Console.WriteLine(string.Format("{0,-20} | {1, -20} | {2, 4}\t | {3,-15}\t | {4, 18}", "First Name", "Last Name", "Age", "Place", "Distance from Capital\n"));

        do
        {                                                                                    // :F2 puts everithing on two commas. You can swith out the number and it will change the amount of 0 behind the comma 
            Console.WriteLine(string.Format("{0,-20} | {1, -20} | {2, 4}\t | {3,-15}\t | {4, 21:F2}", firtstName[i], lastName[i], age[i], place[i], distanceFromCapital[i])); // das i in der Eckigen Klammer wird benötigt um z.B. bei firstName eines weiter zu gehen
            i++;
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
        } while (i < 5);


    }
}