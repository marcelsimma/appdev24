﻿
using System;
//using LucasSchiemann.Week02;
using LucasSchiemann.Week03;
using LucasSchiemann.Week04;
using LucasSchiemann.Week05;
using LucasSchiemann.SortAlgorithmChooser;
using LucasSchiemann.Week06;
using LucasSchiemann.Week06.Zoo;
using LucasSchiemann.Week07.SuperMarkt;
using LucasSchiemann.Week10;
namespace LucasSchiemann;

    class Program
    {
    static void Main()
    {
        MysqlConnectExample.Start();
        //StartOfZoo.StartMethod();
        //Bankkonto.Start();
        //AlgorythmChooser.ChoseSortAlgorythm();
        //Teilnehmerliste.Start();
        //AlgorithmTester.ChoseSortAlgorythm();
        //Tabellensorter.Start();
        //AlgorithmTester.excecuteSelectionSort();
        //TikTakToe.Processor();
        //SearchingInArray.Processor();
        //Week02.AgeCalc.Calc();
        //Week02.Test.Zähler();
        //HochZähler();
        //Teilen();
    }
 


    public static void HochZähler()
    {

        double x = 0.0;

        while (x < 100)
        {
            x += 0.1;
            Console.WriteLine(x);
        }
    }
    static void Teilen()
    {
        int x = 0;
        while (x <= 20)
        {
            Console.WriteLine($"{x} / 5 = {x / 5}");
            Console.WriteLine($"{x} / 5.0 = {x / 5.0}");
            Console.WriteLine("");
            x++;
        }
    }
    }

