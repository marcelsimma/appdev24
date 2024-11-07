using System;
using System.Security.Cryptography.X509Certificates;
using LucasSchiemann.Week02;

namespace LucasSchiemann.Week02;

public class TypenTest
{

    public static void DatenTest()
    {
        bool isParseble = false;
        string inteingabe;
        Console.WriteLine("gib einen Inteure ein");
        inteingabe = Console.ReadLine();

        TryParsingInt(inteingabe);
    }
    public static void TryParsingInt(string eingabe)
    {
        int isInt;
        if (!int.TryParse(eingabe, out isInt))
        {
            Console.WriteLine("Dass ist kein interger versuch es nochmal");
            DatenTest();            
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
            Console.WriteLine("Dass eingegebene ist kein char versuch es nochmal");
            TryParsingChar();
        }
        else 
        {
            Console.WriteLine(charwert+"ist ein char");
            
        }
    }
}