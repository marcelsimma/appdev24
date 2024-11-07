using System;
using System.IO;
namespace JulianStroehle.Week5
{
    public class AbwesenheitslisteV2
    {
        public static void Start()
        {
            Console.WriteLine("Array or List? (1/2)");
            switch (Console.ReadLine())
            {
                case "1": Array(); break;
                case "2": List(); break;
                default: Console.WriteLine("Fehler"); Start(); break;
            }
        }
        static void Array()
        {
            string[] names = new string[8];
            int[] ages = new int[8];
            float[] heights = new float[8];
            string[] columns;
            using (StreamReader str = new StreamReader("C:/Users/JUSR/Documents/Coding Campus/StreamTest/Abwesenheiten Daten.txt"))
            {
                columns = str.ReadLine().Split(" ");
                int i = 0;
                do
                {
                    string[] temp = str.ReadLine().Split(" ");
                    names[i] = temp[0];
                    ages[i] = Convert.ToInt32(temp[2]);
                    heights[i] = Convert.ToSingle(temp[1]);
                    i++;
                }
                while (i < names.Length);
            }
            using (StreamWriter stw = new StreamWriter("C:/Users/JUSR/Documents/Coding Campus/StreamTest/Abwesenheitsliste.txt"))
            {
                stw.WriteLine($"{string.Format("{0,-15}", columns[0])}| {columns[1]}\t| {columns[2]}");
                for (int i = 1; i < names.Length; i++)
                {
                    stw.WriteLine("--------------------------------");
                    stw.WriteLine(string.Format("{0,-15}", names[i]) + "| " + heights[i] + "m\t| " + string.Format("{0,5}", ages[i]));
                }
            }
        }
        static void List()
        {
            List<string> names = new List<string>();
            List<int> ages = new List<int>();
            List<float> heights = new List<float>();
            string[] headers;
            using (StreamReader str = new StreamReader("C:/Users/JUSR/Documents/Coding Campus/StreamTest/Abwesenheiten Daten.txt"))
            {
                headers = str.ReadLine().Split(" ");
                do
                {
                    string[] temp = str.ReadLine().Split(" ");
                    names.Add(temp[0]);
                    ages.Add(Convert.ToInt32(temp[2]));
                    heights.Add(Convert.ToSingle(temp[1]));
                }
                while (!str.EndOfStream);
            }
            using (StreamWriter stw = new StreamWriter("C:/Users/JUSR/Documents/Coding Campus/StreamTest/Abwesenheitsliste.txt"))
            {
                stw.WriteLine($"{string.Format("{0,-15}", headers[0])}| {headers[1]}\t| {headers[2]}");
                for (int i = 0; i < names.Count; i++)
                {
                    stw.WriteLine("--------------------------------");
                    stw.WriteLine(string.Format("{0,-15}", names[i]) + "| " + heights[i] + "m\t| " + string.Format("{0,5}", ages[i]));
                }
            }
        }
    }
}