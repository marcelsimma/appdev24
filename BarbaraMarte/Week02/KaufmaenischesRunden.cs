namespace BarbaraMarte.Week02;

class Runden
{
    public static void Print()
    {
        double number = 123.455678;
        double roundetNumber = RoundOnTwoDecimal(number);
        Console.WriteLine($"Die Gerundete Zahl ist: {roundetNumber}");
    }

    // Methode, die eine Kommazahl manuell auf zwei Nachkommastellen rundet
    static double RoundOnTwoDecimal(double number)
    {
        // number with 100 multipikate to few the komma numbers as a whole number
        double faktor = number * 100;

        // Kaufmaenisches runden (Falls die Ziffer nach der zweiten Nachkommastelle >= 0.5 ist, aufrunden)
        if (faktor - (int)faktor >= 0.5)
        {
            faktor = (int)faktor + 1;
        }
        else
        {
            faktor = (int)faktor;
        }

        return faktor / 100;

    }
}