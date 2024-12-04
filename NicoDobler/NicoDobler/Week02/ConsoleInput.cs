using System;
 
namespace NicoDobler.Week02{


 
public class ConsoleInput
{
 
    public static void ConsoleCalc()
    {
        bool isParseble = false;
        string inteingabe;
        Console.WriteLine("gib einen Inteture ein");
        inteingabe = Console.ReadLine();
 
        TryParsingInt(isParseble,inteingabe);
 
 
 
    }
    public static void TryParsingInt(bool isTrue,string eingabe)
    {
        int isInt;
        if (!int.TryParse(eingabe, out isInt))
        {
                 
            Console.WriteLine("Dass ist kein interger versuch es nochmal");
            ConsoleCalc();            
        }
        else
        {
            Console.WriteLine(eingabe+"ist ein Interger");
            TryParsingDouble();
           
        }
    }
    public static void TryParsingDouble()
    {
        double isDouble;
        Console.WriteLine("Gib einen double ein: ");
        string doublewert = Console.ReadLine();
 
        if (!double.TryParse(doublewert,out isDouble))
        {
            Console.WriteLine("Dass eingegebene ist kein double versuch es nochmal");
            TryParsingDouble();
        }
        else
        {
            Console.WriteLine(doublewert+" ist ein double");
            TryParsingChar();      
        }
 
    }
    public static void TryParsingChar()
    {  
        char isChar;
        Console.WriteLine("Gib einen char ein: ");
        string charwert = Console.ReadLine();
 
        if (!char.TryParse(charwert,out isChar))
        {
            Console.WriteLine("Dass eingegebene ist kein double versuch es nochmal");
            TryParsingChar();
        }
        else
        {
            Console.WriteLine(charwert+"ist ein double");
 
        }
 
 
 
 
    }
}
}
