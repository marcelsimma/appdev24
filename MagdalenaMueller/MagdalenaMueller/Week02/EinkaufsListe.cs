using System;
using System.Diagnostics;

namespace MagdalenaMueller.Week02
{
    class EinkaufsListe
    {
        public static void EinkaufsListeProgram()
        {
            bool again = true;
            int counter = 0; // Starte bei 0
            string[] productList = new string[10]; // Anfangsgröße für 10 Produkte
            string[] amountList = new string[10]; // Anfangsgröße für 10 Mengen
            string task = "1";
        while (again)
        {
            if (counter <= 0 || task == "1")
            {
                Console.WriteLine("Produkt, das du hinzufügen möchtest: ");
                productList[counter] = Console.ReadLine();
                Console.WriteLine($"Wie oft möchtest du {productList[counter]} hinzufügen: ");
                amountList[counter] = Console.ReadLine();
                Console.WriteLine();
            }
            

            Console.WriteLine("Möchtest du ein weiteres Produkt hinzufügen (1)");
            Console.WriteLine("Möchtest du die Liste sehen (2)");
            Console.WriteLine("Möchtest du das Programm beenden (3)");
            task = Console.ReadLine();
            Console.WriteLine();

            switch (task)
            {
                case "1":
                    counter++;
                    // Überprüfen, ob der Array voll ist und ggf. erweitern
                    if (counter >= productList.Length)
                    {
                        Array.Resize(ref productList, productList.Length * 2);
                        Array.Resize(ref amountList, amountList.Length * 2);
                    }
                    again = true;
                    break;
                case "2":
                    for (int i = 0; i <= counter; i++)
                    {
                        Console.WriteLine($"{amountList[i]}x {productList[i]}");
                    }
                    Console.WriteLine("----------------------");
                    Console.WriteLine($"{counter + 1} Produkte in der Liste");
                    task = "10";
                    break;
                case "3":
                    again = false;
                    break;
                default:
                    Console.WriteLine("Ungültige Auswahl. Bitte versuche es erneut.");
                    break;
            }
        }
            
        }
    }
}