using System.Text.RegularExpressions;
using System.IO;
using BarbaraMarte.Week02;

namespace BarbaraMarte.AdventOfCode;

class Day1Part2_2019
{
    public static void Start()
    {
        List<int> numberList = new List<int>();
        int totalCount = 0;
        int tmp = 0;
        try
        {
            using (StreamReader streamReader = new StreamReader("C:/Advent Of Code/2019Day1.txt"))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    int numbers = int.Parse(line);
                    numberList.Add(numbers);
                }
                for (int i = 0; i < numberList.Count; i++)
                {
                    tmp = numberList[i];
                    // System.Console.WriteLine("tmp " + tmp);
                    tmp /= 3;
                    // System.Console.WriteLine("tmp / 3 = " + tmp);
                    tmp -= 2;
                    // tmp2 = tmp;
                    // System.Console.WriteLine("tmp - = 2 " + tmp);
                    totalCount += tmp;
                    // System.Console.WriteLine("Step 1 = " + tmp);
                    while (tmp >= 9)
                    {
                        System.Console.WriteLine();
                        tmp /= 3;
                        // System.Console.WriteLine("tmp /= 3 = " + tmp);
                        tmp -= 2;
                        // tmp2 = tmp;
                        // System.Console.WriteLine("tmp - 2 = " + tmp);
                        totalCount += tmp;
                        // System.Console.WriteLine("Step 2 = " + tmp);
                        // System.Console.WriteLine(totalCount);

                    }
                }
                System.Console.WriteLine(totalCount);
            }
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex);
        }
    }
}

