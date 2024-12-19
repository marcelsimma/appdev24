using System.Text.RegularExpressions;
using System.IO;
using BarbaraMarte.Week02;

namespace BarbaraMarte.AdventOfCode;

class Day2_2015
{
    public static void Part1()
    {
        int squareFeet = 0;
        try
        {
            string[] lines = File.ReadAllLines("C:/Advent Of Code/2015Day2.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(new char[] { 'x' }, StringSplitOptions.RemoveEmptyEntries);

                int l = int.Parse(parts[0]);
                int w = Convert.ToInt32(parts[1]);
                int h = int.Parse(parts[2]);

                int lw = l * w;
                int wh = w * h;
                int lh = l * h;
                int smallestSide = Math.Min(lw, Math.Min(wh, lh));
                int presentPaper = 2 * (lw + wh + lh) + smallestSide;
                squareFeet += presentPaper;
            }
            System.Console.WriteLine(squareFeet);
        }
        catch (Exception ex)
        {
            System.Console.WriteLine("Error" + ex);
        }
    }
    public static void Part2()
    {
        int squareFeet = 0;

        try
        {
            string[] lines = File.ReadAllLines("C:/Advent Of Code/2015Day2.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(new char[] { 'x' }, StringSplitOptions.RemoveEmptyEntries);

                int l = int.Parse(parts[0]);
                int w = Convert.ToInt32(parts[1]);
                int h = int.Parse(parts[2]);

                List<int> middleNumber = new List<int> { l, w, h };
                middleNumber.Sort();
                int smallSide = 2 * (middleNumber[0] + middleNumber[1]);

                int wrap = l * w * h;
                squareFeet += wrap + smallSide;
            }
            System.Console.WriteLine(squareFeet);
        }
        catch (Exception ex)
        {
            System.Console.WriteLine("Error" + ex);
        }
    }




}