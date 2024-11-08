using System;

namespace LucasSchiemann.Week05;

public class Motorrad
{
    int _kmStand;
    bool _inBewegung = false;

        
    public Motorrad(int kmStand)
    {

        _kmStand = kmStand;
    
    }
    
    public void fahre(int kilometer)
    {

        _kmStand += kilometer;
        _inBewegung = true;
        
        Console.WriteLine($"Motorrad fährt {kilometer}km.");
    }
    public void stop()
    {

        _inBewegung = false;
    
    }
    public string faehrt()
    {

        if (_inBewegung)
        {
            return "Ja";
        }
        else
        {
            return "Nein";
        }

    }
    public override string ToString()
    {

        return string.Format("{0} km", _kmStand);

    }

    }


