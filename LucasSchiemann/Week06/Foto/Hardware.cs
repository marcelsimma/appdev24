using System;

namespace LucasSchiemann.Week06.Foto
{
    public class Hardware
    {
    public string _Publisher;

    public string _Model;

    public int _SerienNummer;

    public Hardware(int serienNummer,string model,string publisher)
    {
        _SerienNummer = serienNummer; 
    }
    


    public virtual string WriteSeriennummer()
    {
        return"Deine Seriennummer ist: "+ _SerienNummer;
    } 
    
    }

}