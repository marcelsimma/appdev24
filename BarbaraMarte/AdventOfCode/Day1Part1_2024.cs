using System.Text.RegularExpressions;
using System.IO;
using BarbaraMarte.Week02;

namespace BarbaraMarte.AdventOfCode;


class Day1Part1_2024
{
    private static readonly List<int> _LeftSide = new List<int>();
    private static readonly List<int> _RightSide = new List<int>();
    private static readonly List<int> _Buffer = new List<int>();
    private static readonly List<int> _Total = new List<int>();

    public static void Print()
    {
        string pattern = @"\d+";
        try
        {
            using (StreamReader streamReader = new StreamReader("C:/Advent Of Code/2024Day1.txt"))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (Regex.IsMatch(line, pattern))
                    {
                        string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        int leftSide = int.Parse(parts[0]);
                        int rightSide = Convert.ToInt32(parts[1]);
                        _LeftSide.Add(leftSide);
                        _RightSide.Add(rightSide);
                    }
                    else
                    {
                        System.Console.WriteLine($"Invalid line format {line}");
                    }
                }
                _LeftSide.Sort();
                _RightSide.Sort();
                for (int i = 0; i < _LeftSide.Count(); i++)
                {
                    int left = _LeftSide[i];
                    int right = _RightSide[i];

                    if (_LeftSide[i] > _RightSide[i])
                    {
                        _Buffer.Add(left - right);
                    }
                    else
                    {
                        _Buffer.Add(right - left);
                    }
                }
                int countAllTogether = 0;
                for (int i = 0; i < _Buffer.Count; i++)
                {
                    countAllTogether += _Buffer[i];
                }
                _Total.Add(countAllTogether);
                foreach (int i in _Total)
                {
                    System.Console.WriteLine(i);
                }
            };
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex);
        }
    }
}