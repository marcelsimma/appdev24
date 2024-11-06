using System;
using System.IO;

namespace SimonJochum.Week05
{
    public class OutputTextfile
    {
        public static void Start()
        {
            using (StreamReader reader = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/input.txt"))
            {
                string headline = reader.ReadLine();
                string inputRaw = reader.ReadToEnd();
                string[] input = inputRaw.Split('\n', StringSplitOptions.None);
                int count = 1;

        	    Console.WriteLine(headline);
                foreach (string inp in input)
                {
                    Console.WriteLine($"Nr.{count} {inp}");
                    count++;
                }
            }
        }
    }
}