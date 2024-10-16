namespace BarbaraMarte.Week02;

class Reverse
{
    public static void PrintReverse(string[] args)

    {
        //input string
        Console.WriteLine("Enter a word or a sentence to reverse");
        string input = Console.ReadLine();



        //Reverse the string
        char[] charArray = input.ToCharArray();       // Convert string to a character array
        Array.Reverse(charArray);                    // Reverse the caracter array
        string reverset = new string(charArray);    // Convert back to a string



        Console.WriteLine($"Reversed word {reverset}");
    }

    // Ein String ist eine Zahlenkette
    public static void PrintRandom(string input)

    /* Das Wort "Hallo" wurde in der Probe geschrieben.
     Mit dem Wort "Fach" unten in der Beschreibung muss man sich ein Bücherregal mit vielen Quadratischen Fächern vorstellen. Jedes Fach ist ein Char groß. Sprich es wird immer nur ein Zeichen abgespeichert
    */
    {
        Random random = new Random();

        // Char speichert nur EIN zeichen/ ein Fach. Eckige Klammer sagen dem Compiler dass ich mehrere chars in mehrere Fächer legen will 
        char[] charInput = input.ToCharArray();

        for (int i = 0; i < input.Length - 2; i++)
        {
            int rand = random.Next(i + 1, input.Length - 1);

            char tmp = charInput[i]; // H
            /* Die Zeile oberhalb wird gebraucht damit der erste Buchstabe/ das erste Zeichen nicht gelöscht (überschrieben) wird.
            Man braucht ein extra Fach damit der erste Buchstabe nicht von dem Letzten überschrieben wird da der Compiler 

            Beispiel: ich habe ein Bücherregal und ich möchte zwei Fächer Tauschen. Der Angestellte dafür macht mir eine Identische Kopie. Er kann aber immer nur ein gegenstand Halten da er nur einen Arm hat.
            Durch die Obere Zeile hat er ein Leeres Fach zur verfügung wo er das erste Fach rein Kopieren kann. Anschließend kopiert er vom Zweiten Fach ins Erste. 
            Zum Schluss fertigt er eine Kopie vom Extra Fach an und fügt dieses ins Zweite Fach ein.
            */
            charInput[i] = charInput[rand]; // H mit a ersetzen
            charInput[rand] = tmp; // alten Speicherort von a mit H aus tmp ersetzen

            Console.WriteLine(rand);
        }

        string result = new string(charInput);
        Console.WriteLine(result);

    }
}