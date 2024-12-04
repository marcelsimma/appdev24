using System;

namespace LucasSchiemann.Week06;

public static class Bankkonto
{
    public static void Start()
    {
        float Kontostand = 0;
        bool EndorNah = false;
        
        ChooseAction(Kontostand,EndorNah);
        

        


    }
    public static float Einzahlen(float KontoStand)
    {
        System.Console.WriteLine("Gib ein Wieviel du einzahlen möchtest");
        float UserInput = Convert.ToInt32(Console.ReadLine());
        float NewKontostand = UserInput+KontoStand;
        return UserInput;
    }
    public static float Abheben(float KontoStand)
    {
        System.Console.WriteLine("Gib ein wieviel du abheben möchtest: ");
        float UserInput = Convert.ToInt32(Console.ReadLine());
        if (UserInput > KontoStand)
        {
            System.Console.WriteLine("Der eingegebene betrag ist zu Groß du hast nicht soviel geld auf dem Konto\nDu wirst jetzt zurück zur auwahl geschickt ");
            return KontoStand;
        } 
        float CurrentKontostand = KontoStand- UserInput;
        return CurrentKontostand;
    }
    public static void ChooseAction(float KontoStand,bool EndorNah)
    {
        System.Console.WriteLine("Folgende Funktionen stehen zur Verfügung: \n1.Geld Einzahlen möchtest\n2.Geld Abheben möchtest\n3.Deinen Kontostand sehen möchtest\n4. Beenden möchtest\nWählen sie eine Funktion durch Eingabe des entsprechenden Buchstabens vor der Funktion ");
        int UserInput = Convert.ToInt32(Console.ReadLine());
        switch(UserInput)
        {
            case 1:
                KontoStand = Einzahlen(KontoStand);
                break;
            case 2:
                KontoStand =Abheben(KontoStand);
                break;
            case 3:
                System.Console.WriteLine("Dein aktueller Kontostand:\n"+KontoStand+"€");
                break;
            case 4:
                EndorNah = true;
                System.Console.WriteLine("Jetzt isch fertig");
                break;
        }
        do 
        ChooseAction(KontoStand,EndorNah);
        while (EndorNah == false);
    }

} 