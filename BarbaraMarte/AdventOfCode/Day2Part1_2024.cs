using System.Text.RegularExpressions;
using System.IO;
using BarbaraMarte.Week02;

namespace BarbaraMarte.AdventOfCode;

class Day2Part1_2024
{
    private static List<int> _Row = new List<int>();
    public static void Start()
    {
        string pattern = @"\d+";
        try
        {
            using (StreamReader streamReader = new StreamReader("C:/Advent Of Code/2024Day2Example.txt"))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (Regex.IsMatch(line, pattern))
                    {
                        string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        List<int> numbers = parts.Select(int.Parse).ToList();
                        bool stopPoint = true;

                        for (int i = 0; i < numbers.Count - 1; i++)
                        {
                            int current = numbers[i];
                            int next = numbers[i + 1];
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


/*
Umständliche Lösung:

string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (Regex.IsMatch(line, pattern))
                    {
                        string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        int zerothNumber = int.Parse(parts[0]);
                        int firstNumber = Convert.ToInt32(parts[1]);
                        bool stopPoint = true;


                        // need to build in a false counter and subtract it from the total row amount 


                        if (zerothNumber + 1 == firstNumber || zerothNumber - 1 == firstNumber || zerothNumber + 2 == firstNumber || zerothNumber - 2 == firstNumber)
                        {
                            System.Console.WriteLine("True");
                            System.Console.WriteLine(zerothNumber + " " + firstNumber);
                            int secondNumber = int.Parse(parts[2]);
                            System.Console.WriteLine("zeroth and first number look good");

                            if (stopPoint == true && firstNumber + 1 == secondNumber || firstNumber - 1 == secondNumber || firstNumber + 2 == secondNumber || firstNumber - 2 == secondNumber)
                            {
                                System.Console.WriteLine(firstNumber + " " + secondNumber);
                                System.Console.WriteLine("first and second number look good");
                                int thirdNumber = int.Parse(parts[3]);

                                if (stopPoint == true && secondNumber + 1 == thirdNumber || secondNumber - 1 == thirdNumber || secondNumber + 2 == thirdNumber || secondNumber - 2 == thirdNumber)
                                {
                                    System.Console.WriteLine(secondNumber + " " + thirdNumber);
                                    System.Console.WriteLine("Second and third number look good");
                                    int fourthNumber = int.Parse(parts[4]);

                                    if (parts.Length >= 5 && stopPoint == true && thirdNumber + 1 == fourthNumber || thirdNumber - 1 == fourthNumber || thirdNumber + 2 == fourthNumber || thirdNumber - 2 == fourthNumber)
                                    {
                                        System.Console.WriteLine(thirdNumber + " " + fourthNumber);
                                        System.Console.WriteLine("third and fourth number look good");
                                        int fifthNumber = int.Parse(parts[5]);

                                        if (parts.Length >= 6 && stopPoint == true && fourthNumber + 1 == fifthNumber || fourthNumber - 1 == fifthNumber || fourthNumber + 2 == fifthNumber || fourthNumber - 2 == fifthNumber)
                                        {
                                            System.Console.WriteLine(fourthNumber + " " + fifthNumber);
                                            System.Console.WriteLine("fourth and fifth number look good");
                                            int sixthNumber = int.Parse(parts[6]);

                                            if (stopPoint == true && fifthNumber + 1 == sixthNumber || fifthNumber - 1 == sixthNumber || fifthNumber + 2 == sixthNumber || fifthNumber - 2 == sixthNumber)
                                            {
                                                System.Console.WriteLine(fifthNumber + " " + sixthNumber);
                                                System.Console.WriteLine("fifth and sixth number look good");
                                            }
                                            else
                                            {
                                                stopPoint = false;
                                                System.Console.WriteLine("line five is wrong");
                                            }
                                        }
                                        else
                                        {
                                            stopPoint = false;
                                            System.Console.WriteLine("line four is wrong");
                                        }
                                    }
                                    else
                                    {
                                        stopPoint = false;
                                        System.Console.WriteLine("line three is wrong");
                                    }
                                }
                                else
                                {
                                    stopPoint = false;
                                    System.Console.WriteLine("Line two is Wrong " + stopPoint);
                                }
                            }
                            else
                            {
                                stopPoint = false;
                                System.Console.WriteLine("Line One is Wrong " + stopPoint);
                            }
                        }
                        else
                        {
                            stopPoint = false;
                            System.Console.WriteLine("Line Zero is Wrong " + stopPoint);
                        }
                        System.Console.WriteLine("new Row");
                        System.Console.WriteLine();

                    }
                    else
                    {
                        System.Console.WriteLine($"Invalid line format {line}");
                    }
                }
            }
*/