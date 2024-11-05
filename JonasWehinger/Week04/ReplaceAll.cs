using System;
using System.Security.Cryptography;
using JonasWehinger.Week02;

namespace JonasWehinger.Week04
{
 
    public class ReplaceAll()
    {
            public static void Replace()
        {
            string input = ("Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!");

            char[] inputArray = input.ToCharArray();

            string lowerResult = "", higherResult = "", spaceResult = "", markResult = "";

            foreach (char element in inputArray)
            {  if(char.IsLower(element)){

                    lowerResult += element;
                }if(char.IsUpper(element)){

                    higherResult += element;
                }if(char.IsWhiteSpace(element)){

                    spaceResult += element;
                }if(element == '!'){

                    markResult += element;
                }
            }

            Console.WriteLine(lowerResult);
            Console.WriteLine(higherResult);
            Console.WriteLine(spaceResult);
            Console.WriteLine(markResult);
        }
    }
}
