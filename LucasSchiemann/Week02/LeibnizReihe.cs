using System;
using LucasSchiemann.Week01;

namespace LucasSchiemann.Week02;
/*
1. Schreibe eine schleife für die rechnung
1.1 schreib eine eingabe variable die sagt wie viele brüche mann verwenden soll
1.2 Schreib eine variable die denn nenner immer + 2 nimmt und jeden zweiten operand zu + macht und danach wieder zu minus(1-1+1-1+1)


*/
public static class PiCalc
{
    public static void StartCalculator ()
    {
        
        // definiere das Array und initalisiere es? spiel ummanand!
        // jenachdem ob das Array befüllt ist oder nicht??? was muss gemacht werden??
        

        decimal[] allSolutions  ;    
        decimal[] currentCalcArray = new decimal[0];


        currentCalcArray = [CalcMethod()];
        allSolutions = [.. currentCalcArray];
        // hier hast du ein Ergebnis... welches du dem allSolutions hinzufügen kannst

        WriteAllSolutions();


    }
    public static void WriteAllSolutions()
    {
        





    }
    public static decimal CalcMethod()
    {
        
        
        
        Console.WriteLine("Wilkommen im Leibniz Pi-Calculator\n" +
        "Die Genauichkeit von Pi wird bestimmt durch die Anzahl von brüchen mit denen Gerechnet wird.\n" +
        "Gib ein mit wievielen Brüchen gerechnet werden soll: ");

        decimal UserInput = Convert.ToDecimal(Console.ReadLine());
        decimal Result = PiCalculator(UserInput);
        decimal[] TEstArray =  [UserInput,Result];
        
        return TEstArray[0];


    }

    public static decimal PiCalculator(decimal UserInput)
    {
        int denominator = 1;
        decimal MyPi = 0;
        for (int i = 0; i < UserInput; i++)
        {

            if (i % 2 == 0)
            {
                //Plus Rechnen
                MyPi += (1m / denominator);

            }
            else
            {
                //decimal val = 1m / denominator;
                MyPi -= (1m / denominator);
                //MinusRechnen
            }
            denominator += 2;
        }
        return MyPi * 4;
    }
    public static void BetterPutInArray(int UserInput,decimal PISolution,int counterArray)
    {
        decimal[] initialArray = new decimal[] { 1, 4 }; // erstes Array
        decimal[] appendingArray = [UserInput, PISolution]; // zweites Array
        decimal[] bothArrays = [.. initialArray, .. appendingArray]; // concat
        decimal[] allSolutions = [.. appendingArray];

        foreach (var currentPosOfArray in bothArrays)
        {
            Console.Write($"{currentPosOfArray}, ");
        }



    }
    /*
    public static void PutInArray(int UserInput, decimal PISolution, int counterArray)
    {
        decimal[][] Solutions = new decimal[5][];
        switch (counterArray)
        {
            case 1:
                Solutions[0] = [UserInput, PISolution];
                break;
            case 2:
                Solutions[1] = [UserInput, PISolution];
                break;
            case 3:
                Solutions[2] = [UserInput, PISolution];
                break;
            case 4:
                Solutions[3] = [UserInput, PISolution];
                break;
            case 5:
                Solutions[4] = [UserInput, PISolution];
                break;
        }
        Console.WriteLine("Deine "+counterArray+". Eingabe + Ergebnis sind: ");
        switch (counterArray)
        {
            case 1:
                foreach (decimal i in Solutions[0])
                {
                    //Console.WriteLine("Deine Erste Eingabe + Ergebnis sind: ");
                    Console.WriteLine(i);
                }
                break;
            case 2:
                foreach (decimal i in Solutions[1])
                {
                    //Console.WriteLine("Deine Zweite Eingabe + Ergebnis sind: ");
                    Console.WriteLine(i);
                }
                break;
            case 3:
                foreach (decimal i in Solutions[2])
                {
                    //Console.WriteLine("Deine Dritte Eingabe + Ergebnis sind: ");
                    Console.WriteLine(i);
                }
                break;
            case 4:
                foreach (decimal i in Solutions[3])
                {
                    //Console.WriteLine("Deine Vierte Eingabe + Ergebnis sind: ");
                    Console.WriteLine(i);
                }
                break;
            case 5:
                foreach (decimal i in Solutions[4])
                {
                    //Console.WriteLine("Deine Fünfte Eingabe + Ergebnis sind: ");
                    Console.WriteLine(i);
                }
                break;



        }
    */

    /*
    Console.WriteLine(Solutions[1][2]);
    Console.WriteLine(Solutions[3][4]);
    Console.WriteLine(Solutions[5]);
    */



}


// 1 methode : Array handling
// 2 methode : write array to console