using System;

namespace JonasWehinger.Week02
{

    public class ConsoleInput
    {
        public static void Console_()
        {

        Console.Write("Geben Sie eine Ganzzahl ein: ");
        string intInput = Console.ReadLine();
        bool isInteger = true;
 
        
        for (int i = 0; i < intInput.Length; i++)
        {
            if (intInput[i] < '0' || intInput[i] > '9')
            {
                isInteger = false;
                break;
            }
        }
 
        if (isInteger && intInput.Length > 0)
        {
            Console.WriteLine("Gültige Ganzzahl: " + intInput);
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe für Ganzzahl.");
        }
 
       
        Console.Write("Geben Sie eine Fließkommazahl ein: ");
        string doubleInput = Console.ReadLine();
        bool isDouble = true;
        bool hasDecimalPoint = false;
 
        
        for (int i = 0; i < doubleInput.Length; i++)
        {
            if (doubleInput[i] == '.')
            {
                if (hasDecimalPoint) 
                {
                    isDouble = false;
                    break;
                }
                hasDecimalPoint = true;
            }
            else if (doubleInput[i] < '0' || doubleInput[i] > '9')
            {
                isDouble = false;
                break;
            }
        }
 
        if (isDouble && doubleInput.Length > 0)
        {
            Console.WriteLine("Gültige Fließkommazahl: " + doubleInput);
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe für Fließkommazahl.");
        }
 
        
        Console.Write("Geben Sie einen Buchstaben ein: ");
        string charInput = Console.ReadLine();
        if (charInput.Length == 1)
        {
            Console.WriteLine("Gültiger Buchstabe: " + charInput);
        }
        else
        {
            Console.WriteLine("Bitte geben Sie nur einen Buchstaben ein.");
        }
    }
}
}