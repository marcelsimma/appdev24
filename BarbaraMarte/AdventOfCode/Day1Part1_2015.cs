using System;
using System.Text.RegularExpressions;
using System.IO;
using BarbaraMarte.Week05;

namespace BarbaraMarte.AdventOfCode;

class Day1Part1_2015
{
    public static void Part1()
    {
        string input = File.ReadAllText("C:/Advent Of Code/2015Day1.txt");
        int floor = 0;
        foreach (char c in input)
        {
            if (c == '(')
            {
                floor += 1;
            }
            else
            {
                floor -= 1;
            }
        }
        System.Console.WriteLine(floor);

    }
    public static void Part2()
    {
        string input = File.ReadAllText("C:/Advent Of Code/2015Day1.txt");
        int floor = 0;
        int count = 0;

        foreach (char c in input)
        {
            count++;
            if (c == '(')
            {
                floor += 1;
            }
            else if (c == ')')
            {
                floor -= 1;
            }
            if (floor < 0)
            {
                System.Console.WriteLine(floor + " count " + count);
                return;
            }
        }

    }

}