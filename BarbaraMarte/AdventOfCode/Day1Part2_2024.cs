using System;
using System.Text.RegularExpressions;
using BarbaraMarte.Week02;


namespace BarbaraMarte.AdventOfCode
{
    class Day1Part2_2024
    {

        private static List<int> _LeftSide = new List<int>();
        private static List<int> _RightSide = new List<int>();
        private static List<int> _TotalCount = new List<int>();
        public static void Start()
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

                }

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
            CalculateNumber();
        }
        private static void CalculateNumber()
        {
            int totalCount = 0;
            int matchCount = 0;
            int currentTotal = 0;

            for (int l = 0; l < _LeftSide.Count; l++)
            {
                for (int r = 0; r < _RightSide.Count; r++)
                {
                    if (_LeftSide[l] == _RightSide[r])
                    {
                        matchCount++;
                    }
                }
                currentTotal = _LeftSide[l] * matchCount;
                // System.Console.WriteLine("Left side: " + _LeftSide[l]);
                // System.Console.WriteLine("Matches: " + matchCount);
                // System.Console.WriteLine(currentTotal);
                totalCount += currentTotal;
                _TotalCount.Add(totalCount);
                matchCount = 0;
            }
            System.Console.WriteLine("Total amount: " + totalCount);
            // System.Console.WriteLine("All Calculated Totals: " + string.Join(",", _TotalCount));
        }
    }
}

/*

            int count = 0;
            int number = 0;
            int totalCount;
            int whileCount = 0;

            do
            {
                for (int i = 0; i < _LeftSide[i]; i++)
                {
                    var placeholder = 0;
                    _LeftSide[i] = placeholder;
                    System.Console.WriteLine("Step 1");
                    System.Console.WriteLine(_LeftSide[i]);
                    foreach (var tmp2 in _LeftSide)
                    {
                        if (tmp2 == _RightSide[i])
                        {
                            number = tmp2;
                            count += 1;
                            System.Console.WriteLine("Left side count");

                        }
                    }
                    if (count >= 1)
                    {
                        totalCount = count * number;
                        _TotalCount.Add(count * number);
                        System.Console.WriteLine(totalCount);
                    }
                }
                whileCount++;
                System.Console.WriteLine("While Count:");
                System.Console.WriteLine(whileCount);
            } while (_LeftSide.Count > whileCount);
*/