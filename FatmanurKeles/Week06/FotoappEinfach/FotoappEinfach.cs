using FatmanurKeles.Week06.FotoappEinfach.FotoEinfach;

namespace FatmanurKeles.Week06.FotoappEinfach
{
    public class FotoappEinfach
    {
           public static void Launch()
        {
            System.Console.WriteLine("Hallo");

            Fotoapparat temu = new Fotoapparat("Temu Schrottkamera 2000X", 2.5, 10, 20, "Temu China Ltd.", 5);
            System.Console.WriteLine(temu.ToString());
            temu.TakePhoto();
            temu.TakePhoto();
            temu.TakePhoto();
            temu.TakePhoto();
            temu.TakePhoto();
            temu.TakePhoto();
            temu.TakePhoto();
            temu.TakePhoto();
            temu.TakePhoto();
            temu.TakePhoto();
            System.Console.WriteLine(temu.ToString());
        }
    }
}