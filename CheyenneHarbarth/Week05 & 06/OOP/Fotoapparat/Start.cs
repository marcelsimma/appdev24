using System;

namespace CheyenneHarbarth.Week05.OOP.Fotoapparat
{
    public class Start
    {

        public void Launch()
        {
            FotoapparatAdvanced Nikon = new FotoapparatAdvanced("R10", 24.2, "Canon");

            IObjekt[] Inventorylist = new IObjekt[3];

            Inventorylist[0] = Nikon;

        }
    }
}