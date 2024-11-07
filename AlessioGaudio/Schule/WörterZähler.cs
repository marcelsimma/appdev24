using System;
using System.Reflection;

namespace AlessioGaudio.Schule
{
    public class WordCounterr
    {
        public static void Start()
        {
            Console.WriteLine("Bitte geben Sie einen Text ein:");
            string input = Console.ReadLine();

            string[] words = input.ToLower().Split(new[] { ' ', '.', ',', '!', '?', ';', ':', '-', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            
            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            Console.WriteLine("\n Häufigkeit der Wörter im Text:");
            foreach (KeyValuePair<string, int> entry in wordCount.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }

     }} 