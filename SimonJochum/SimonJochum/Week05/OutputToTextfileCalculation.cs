using System;
using System.IO;

namespace SimonJochum.Week05
{
    public class OutputToTextfileCalculation
    {
        public static void Start()
        {
            using (StreamReader reader = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/inputcalc.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\SIJO\Documents\Testaufgaben\outputcalc.txt"))
                {
                    string inputRaw = reader.ReadToEnd();
                    string[] input = inputRaw.Split('\n', StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < input.Length; i++)
                    {
                        int inputDigit = Convert.ToInt32(input[i]);
                        int outputDigit = inputDigit * inputDigit;
                        writer.WriteLine("Das Quadrat von " + inputDigit + " = " + outputDigit);
                    }
                }
            }
        }

        public static void Start2()
        {
            using (StreamReader reader = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/inputcalc.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\SIJO\Documents\Testaufgaben\outputcalc.txt"))
                {
                    string inputRaw;
                    while ((inputRaw = reader.ReadLine()) != null)

                        if (int.TryParse(inputRaw, out int inputDigit))
                        {
                            int outputDigit = inputDigit * inputDigit;
                            writer.WriteLine("Das Quadrat von " + inputDigit + " = " + outputDigit);
                        }
                        else
                        {
                            writer.WriteLine("Ungültige Eingabe: " + inputRaw);
                        }
                }
            }
        }
    }
}
