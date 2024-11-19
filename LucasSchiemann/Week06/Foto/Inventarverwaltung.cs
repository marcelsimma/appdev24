using System;

namespace LucasSchiemann.Week06.Foto;

public interface InventarVerwaltung
{

    public string InventarNummer{get;set;}

    public string PrintInventarnummer()
    {
        return "Inventarnummer der Speicherkarte.";
    }

}