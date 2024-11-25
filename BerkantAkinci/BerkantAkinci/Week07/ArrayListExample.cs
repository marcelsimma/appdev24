using System;
using System.Collections;

namespace BerkantAkinci.Week07
{
    public class ArrayListExample
    {
        public static void Start()
        {
            ArrayList exampleList = new ArrayList();

            exampleList.Add(5);
            exampleList.Add("Text Schrift");
            exampleList.Add(DateTime.Now);

            foreach (var elem in exampleList)
            {
                System.Console.WriteLine(elem.ToString());
            }
            int result = (int)exampleList[0] + 5;

            System.Console.WriteLine(result);

            string fullname = (string)exampleList[1];
            string[] splitedname = fullname.Split(" ");
            System.Console.WriteLine($"{splitedname[0]}, {splitedname[1]}");
        }
    }
}