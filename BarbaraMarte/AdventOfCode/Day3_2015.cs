using System;
using System.Text.RegularExpressions;
using System.IO;
using BarbaraMarte.Week05;

namespace BarbaraMarte.AdventOfCode;

class Day3_2015
{
    private Dictionary<int, int> position = new Dictionary<int, int>();
    public static void Part1()
    {
        /*{
            {0 1,0 2,0 3,0 4,0 5,0 6,0 7,0 8,0 9},
            {1 1,1 2,1 3,1 4,1 5,1 6,1 7,1 8,1 9},
            {2 1, 2 2, 2 3,},
            {},
            {},
            {},
            {},
            {},
            {}
        }*/

        int xPos = 5;
        int yPos = 5;

        try
        {
            string input = File.ReadAllText("C:/Advent Of Code/2015Day2.txt");
            foreach (char c in input)
            {
                if (c == '<')
                {
                    CheckDictionary();
                }
                else if (c == '>')
                {

                }
                else if (c == '^')
                {

                }
                else
                {

                }
            }
        }
        catch (Exception ex)
        {
            System.Console.WriteLine("Error" + ex);
        }
    }
    private static void CheckDictionary()
    {
        
    }
}