using System;
using System.Text.RegularExpressions;
using BarbaraMarte.Week02;


namespace BarbaraMarte.AdventOfCode
{
    class Day1Part2
    {

        private static List<int> _LeftSide = new List<int>();
        private static List<int> _RightSide = new List<int>();
        public static void Start()
        {

            string pattern = @"\d+";
            try
            {
                using (StreamReader streamReader = new StreamReader("C:/Advent Of Code/Day1Example.txt"))
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
                    int count = 0;
                    foreach (int tmp in _LeftSide)
                    {
                        for (int i = 0; i < _RightSide.Count(); i++)
                        {
                            if (_LeftSide[i] == _RightSide[i])
                            {

                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }


        }
    }
}