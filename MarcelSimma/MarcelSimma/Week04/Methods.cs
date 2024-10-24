
namespace MarcelSimma.Week04
{


    public class Methods
    {
        public static void Start()
        {
            Print("Hallo");
            Print("Tschau");
            Print("Auf Wiedersehen");
            Print("Grüßgott");

            int zahl = 11;

            // 4 + 3 = ?
            int summe = Add(4, 3, zahl);
            Print(summe.ToString());

            summe = Add(8, 12, 4);

            // 6 * 3 = ?
            double product = Multiply(6, 3);
            Print(product.ToString());


            // Eine Schleife, die alle ungeraden Zahlen von 0 bis 10 in absteigender Reihenfolge auf der Console ausgibt.
            
            /*
            for: Schleifen Keyword
            int i = 0: Inizialisierung der Zählvariable
            i < 11: Abbruchbedingung
            i++: Veränderung unserer Zählvariable
            
            i++ ist die Kurzform für i = i + 1
            i+=2 ist die Kurzform für i = i + 2
            */

            

            for (int i = 9; i >= 0; i-=2) {
                Console.WriteLine(i);
            }

            int number = 11;
            int[] numbers = new int[3];
            numbers[0] = 2;
            numbers[1] = 23;
            numbers[2] = 34;

            Console.WriteLine(number);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers.Length);

            string[] teilnehmer = new string[] {
                "Jonas",    //i = 0
                "Nico",
                "Alessio",  //i = 2
                "Fatma",    //i = 3
                "Berkant"   //i = 4
            };

            // alle Teilnehmer auf der console ausgeben

                        //  4 <= 5 - 1 
            for (int i = 0; i <= teilnehmer.Length - 1; i++) {
                Console.WriteLine(teilnehmer[i]);
            }

            foreach (string tn in teilnehmer) {
                Console.WriteLine(tn);
            }

            //Console.WriteLine(teilnehmer.Length);

            // Den Nutzer solange nach einem input fragen, bis der Nutzer "Hallo" eingibt. 

                // Abbruchbedingung

            string input = "Hallo";

            do {
                Console.WriteLine("Bitte einen int eingeben:");

                input = Console.ReadLine();

            } while (input != "Hallo");

            char c = '5';

            int test = c;

            Console.WriteLine(test);


        }

        // Aufgabe: Methode, die bestimmten Text auf der Console ausgibt.
        public static void Print(string text)
        {
            Console.WriteLine(text);
        }

        // Aufgabe: Methode, die zwei Int-Werte addiert und die Summe zurückgibt.
        public static int Add(int a, int b, int c) {
            int ergebnis = a + b + c;
            return ergebnis;
        }

        // Aufgabe: Methode, die zwei Double-Werte multipliziert und das Produkt zurückgibt.
        public static double Multiply(double a, double b) {
            double ergebnis = a * b;
            return ergebnis; 
        }

    }
}

