using System;
using System.Text.RegularExpressions;
using System.IO;
using BarbaraMarte.Week05;

namespace BarbaraMarte.AdventOfCode;

class ForDictionary
{
    internal Dictionary<int, int> _position;
    internal ForDictionary()
    {
        _position = new Dictionary<int, int>();
    }
}
class Day3_2015
{
    Dictionary<int, int> _position;
    private int _x = 5;
    private int _y = 5;

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

        try
        {
            string input = File.ReadAllText("C:/Advent Of Code/2015Day2.txt");
            foreach (char c in input)
            {
                if (c == '<')
                {
                    // CheckDictionary(5, 5, _position);
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
    private static void CheckDictionary(Dictionary<int, int> _position)
    {
        for (int i = 0; i < _position.Count; i++)
        {

        }

        foreach (var c in _position)
        {

        }
    }
}