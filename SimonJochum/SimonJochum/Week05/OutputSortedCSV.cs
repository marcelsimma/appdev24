using System;
using System.IO;

namespace SimonJochum.Week05
{
    public class OutputSortedCSV
    {
        public static void Start()
        {
            using StreamReader reader1 = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/input1.csv");// Menge Preis Bezeichnung
            using StreamReader reader2 = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/input2.csv");// Preis Bezeichnung Menge
            using StreamWriter writer = new StreamWriter("C:/Users/SIJO/Documents/Testaufgaben/output.csv");

           
            string inputHeader = reader1.ReadLine();
            string[] inputHeaderParts = inputHeader.Split(new[] { ';' }, StringSplitOptions.TrimEntries);
            string headlineToRemove = reader2.ReadLine();
            writer.WriteLine(string.Format("{0, 1}; {1, 1}; {2,1}", inputHeaderParts[2], inputHeaderParts[1], inputHeaderParts[0]));
            //writer.WriteLine(string.Format("{0, 1}; {1, 1}; {2,1}", input2[0], input2[1], input2[2]));
            string input1Raw;
            while ((input1Raw = reader1.ReadLine()) != null)
            {
                string[] parts1 = input1Raw.Split(new[] { ';' }, StringSplitOptions.TrimEntries);
                if (parts1.Length == 3)
                {
                    writer.WriteLine(string.Format("{0, 1}; {1, 1}; {2,1}", parts1[2], parts1[1], parts1[0]));
                }
            }
            string input2Raw;
            while ((input2Raw = reader2.ReadLine()) != null)
            {
                string[] parts2 = input2Raw.Split(new[] { ';' }, StringSplitOptions.TrimEntries);
                if (parts2.Length == 3)
                {
                    writer.WriteLine(string.Format("{0, 1}; {1, 1}; {2,1}", parts2[1], parts2[0], parts2[2]));
                }
            }
        }
    }
}