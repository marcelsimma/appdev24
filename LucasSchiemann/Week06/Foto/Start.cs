using System;

namespace LucasSchiemann.Week06.Foto;

public class Start
{
public void StarterMethod()
{
    Speicher Speicherkarte1 = new Speicher(500,"Sonydiesdas",92759728);
    FotoAparat Camera1 = new FotoAparat("Sony",12090,Speicherkarte1);


    int[] intArray = new int[2];
    Fotoapparat[] fotoArray = new Fotoapparat[2];
    fotoArray[0] = Camera1;

    

}
}