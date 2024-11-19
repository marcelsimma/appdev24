using System;

public class Gehege:Zoo
{    
    public static string ZooName{get;set;}

    public static string GruendungsJahr{get;set;}

    public static string GehegeName{get;set;}   

    public List<string>GehegeZoo = new List<string>();

    //public string GehegeParamenter;
    public Gehege(string zooName,string gruendungsJahr,string gehegeName)
    {
        GehegeName = gehegeName;
        ZooName = zooName;
        //GehegeParamenter = gehegeParamenter;
        GruendungsJahr = gruendungsJahr;
    }
    public static void CreateNewEnclosure()
    {
        System.Console.WriteLine("Gib ein wie du dein Neues Gehege nennen möchtest");

    }

    public static string PrintGehege()
    {
        return  $"|--Zoo: {ZooName}, {GruendungsJahr}\n|---{GehegeName} ";
    }

}