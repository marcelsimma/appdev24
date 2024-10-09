using System;
using System.Buffers.Text;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Net.Mime;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ManuelHartmann
{

    public class Program
    {
        static void Main(string[] args)
        {
            string respond = "Hello";

            string result = reverseRespond(respond);
            
            Console.WriteLine($"The reversed UserInput: \"{result}\"");
            Console.WriteLine($"The reversed UserInput: \"{result}\"");
            Console.WriteLine($"The randomized UserInput: \"{randomizeRespond(respond)}\"");
            Console.WriteLine($"The randomized UserInput: \"{randomizeResponding(respond)}\"");
        }
        static string reverseRespond(string transfer)
        {
            char[] chars = transfer.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);
            return reversed;
        }
        static string reverseRespondFor(string transfer)
        {
            string reversing = "";
            for (int i = transfer.Length - 1; i >= 0; i--)
            {
                reversing += transfer[i];   
            }
            return reversing;
        }
        public static string randomizeRespond(string transfer)
        {
            string randomizedText = "";
            for (int i = transfer.Length - 1; i >= 0; i--)
            {
                int randomNumber = randomGenerator(transfer.Length);
                randomizedText += transfer[randomNumber];
            }
            return randomizedText;
        }
        public static int randomGenerator(int stringLength)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, stringLength);
            return randomNumber;
        }
        public static string randomizeResponding(string transfer)
        {
            char[] chars = transfer.ToCharArray();
            chars = chars.OrderBy(c => randomGenerator(transfer.Length)).ToArray();
            string randomized = new string(chars);
            return randomized;
        }
    }
}




