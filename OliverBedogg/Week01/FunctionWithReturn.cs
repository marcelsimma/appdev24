using System;

namespace OliverBedogg.Week01
{
	public class FunctionWithReturn
	{
		public static void Start()
		{
			printLine("Zeile 1");

			for (int i = 2; i <= 5; i++)
			{
				Console.WriteLine(
					returnLineText(i) + " - " + returnRandomNumber(300, 80)
					);
			}
		}

		public static void printLine(string text)
		{
			Console.WriteLine(text);
		}

		public static string returnLineText(int i)
		{
			i = i * 10;
			string text = "Zeile " + i;

			return text;
		}
		public static int returnRandomNumber(int from, int to)
		{
			Random rand = new Random();

			if (to < from)
			{
				return 0;
			}

			printLine("Erzeuge Zufallszahl");
			return rand.Next(from, to);
		}

	}
}