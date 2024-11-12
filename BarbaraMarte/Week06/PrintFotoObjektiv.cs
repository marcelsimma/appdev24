using System;

namespace BarbaraMarte.Week06;

class PrintFotoObjekt
{
    public static void Print()
    {   //  BrennweiteMin BrennweiteMax, Producer, Megapixel
        Camera camera = new Camera(100, 500, "Philips", 500, "Super Camera 500");
        Console.WriteLine(camera);
        Console.WriteLine(camera.TakePhoto());
        Console.WriteLine(camera.CameraUseZoom());
        Console.WriteLine(camera.BrennweiteMin);
    }
}