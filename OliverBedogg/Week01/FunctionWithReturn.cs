using System;

namespace OliverBedogg.Week01
{
	public class FunctionWithReturn
	{


		public static int Add(int a, int b)
		{
			int result = a + b;
			Console.WriteLine($"1/ Addition {a}+{b} = " + result);
			// $ ersetzt:
			Console.WriteLine("2/ Addition " + a + "+" + b + " = " + result);

			return result;
		}
		public static void debug(string text)
		{
			// Einfache Konsolen-Ausgabe mit debug-Vermerk
			Console.WriteLine("debug: " + text);
		}
		public static void Start(int AnzahlZeilen)
		{
			int ergebnis = Add(5, 1); // 6

			debug("Addition " + ergebnis);

			Console.WriteLine("3/ Addition " + ergebnis);
			// gleiche Ausgabe wie mit Variable:
			Console.WriteLine("4/ Addition " + Add(5, 1));


			Console.WriteLine(new string('-', 10));
			// Ausgabe über eigene Funktion
			printLine("Zeile 1");

			for (int i = 2; i <= 5; i++)
			{
				// Konsolenausgabe mit den Ergebnissen von zwei Funktionen
				Console.WriteLine(
					returnLineText(i) + " - " + returnRandomNumber(30, 80)
					);
			}

			printLine("Ungültige Parameterübergabe " + returnRandomNumber(100, 1));
		}

		public static void printLine(string text)
		{
			Console.WriteLine(text);
		}

		public static string returnLineText(int i)
		{
			i = i * 10;
			// Erzeuge eine Zeichenkette (string) mit der Zeilenzahl
			string text = "Zeile " + i;

			return text;
		}
		public static int returnRandomNumber(int from, int to)
		{
			Random rand = new Random();

			// wenn maxWert unter vonWert
			if (to < from)
			{
				// return Beendet die Ausführung der Funktion
				printLine("Fehlerhafte Übergabe: to < from");
				return 0;
			}

			// folgender Code wird bei (to < from) nicht mehr ausgeführt
			printLine("Erzeuge Zufallszahl");
			return rand.Next(from, to);
		}

	}
}