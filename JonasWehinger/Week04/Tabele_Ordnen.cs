namespace JonasWehinger.Week04
{
 
    public class Tabele_Ordner()
    {
        public static void ordner()
    {
        string[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
        string[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
        int[] age = { 40, 78, 5, 18, 81 };
        string[] place = {"Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten"};
        float[] distanceFromCapital = {0f, 654.4f, 12.457634366f, 120.0f, 119.9999f};
        PrintTable(firstName, lastName, age, place, distanceFromCapital);
    }
    public static void PrintTable(string[] firstNames, string[] lastNames, int[] ages, string[] places, float[] distanceFromCapital)
    {

        for (int i = 0; i < firstNames.Length; i++)
            {
                PersonInfo(firstNames[i], lastNames[i], ages[i], places[i], distanceFromCapital[i]);
            }
        }

        private static void PersonInfo(string firstName, string lastName, int age, string place, float distanceFromCapital)
        {
            Console.WriteLine($"{firstName,-20} {lastName,-25} {age,-5} {place,-20} {distanceFromCapital,-15}");
        }
    }
}

