using System;

namespace LucasSchiemann.Week06.Foto
{
    public class Hardware
    {
    public int _Megapixel{get; set;}

    public string _Model{get; set;}

    public int _SerienNummer{get; set;}

    public Hardware(int serienNummer)
    {
        _SerienNummer = serienNummer;
    }
    
    


    public virtual string WriteSeriennummer()
    {
        return"Deine Seriennummer ist: "+ _SerienNummer;
    } 
    }

}