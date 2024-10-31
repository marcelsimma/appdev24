namespace BarbaraMarte.Week04;

class Hesse
{

    public static void Print()
    {
        string errString = "Geboren am 2.7.1877 in Calw, gestorben am 9.8.1962 in Montagnola. Thematik der frühen Romane: Widerstand gegen konventionelle Normen, geistige Unruhe und Zweifel, Gegensatz zwischen kontemplativer und „sinnlicher“ Lebensweise," +
            " Verhältnis des Künstlers zum Leben. Nach dem Ersten Weltkrieg wird Hesses Werk von der Psychoanalyse (Demian) als auch von orientalischer Meditation (Siddhartha) beeinflusst; vor allem im „Steppenwolf“ übt Hesse vehemente Kritik" +
            " an der technokratischen Zivilisation und den Widersprüchen der bürgerlichen Gesellschaft, an einer Welt der Maschinen und der Kommerzialisierung. Der Altersroman Glasperlenspiel gestaltet das neue Ideal eines „Reichs des Geistes und" +
            "der Seele“ als Gegenentwurf zur Geistverneinung des Nationalsozialismus. Hesses Werke waren mehrmals Identifikationstexte der gegen Gesellschaftszwänge aufbegehrenden jungen Generation: nach dem Ersten (Demian) und dem Zweiten Weltkrieg" +
            "(Glasperlenspiel) und im Jugendprotest der späten sechziger Jahre. Vor dem Hintergrund des Vietnam-Kriegs kam es von den USA aus zu einer Hesse-Renaissance. Der Romantiker, Mystiker und Anti-Bürger Hesse wurde zum Klassiker der Hippiekultur," +
            "die sich in seinen Texten wiederfand (Steppenwolf).\r\n\r\nHesse über sich selbst: „Ich habe mich im Lauf meiner Entwicklung den Problemen der Zeit nicht entzogen und nie, wie meine politischen Kritiker meinen, im elfenbeinernen Turme" +
            "gelebt – aber das erste und brennendste meiner Probleme war nie der Staat, die Gesellschaft oder die Kirche, sondern der einzelne Mensch, die Persönlichkeit, das einmalige, nicht normierte Individuum“ (1951).\r\nIn den USA und Japan der" +
            "meistgelesene europäische Autor seit hundert Jahren; Millionenauflage seiner Bücher, Übersetzungen in 40 Sprachen.";

        Console.WriteLine($"the origanal string is: {Environment.NewLine}'{errString}");

        // Hess hervorheben 1
        string correctString = errString.Replace("Hesse", "HESSE");
        Console.WriteLine();
        Console.WriteLine($"After correcting the text, the result is{Environment.NewLine}'{correctString}");
        Console.WriteLine();

        // Word change by yourselfe:
        Console.WriteLine("Which Word do you want to Correct?");
        string? WordYouChange = Convert.ToString(Console.ReadLine());
        Console.Write("How do you want to correct it?");
        string? change = Convert.ToString(Console.ReadLine());
        string correctWord = errString.Replace(WordYouChange, change);
        Console.WriteLine($"After correcting the text, the result is {Environment.CommandLine}' {correctWord}");


    }
}