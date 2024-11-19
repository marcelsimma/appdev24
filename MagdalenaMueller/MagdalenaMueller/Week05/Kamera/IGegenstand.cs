using System;


public interface IGegenstand
{
    public string inventarNumber {get; set;}
    public int costs {get; set;}

    public string PrintInventarnummer();


}

