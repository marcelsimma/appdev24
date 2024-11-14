
namespace BarbaraMarte.Week06.CameraEasy
{

    public class Start
    {


        /*
        1. Grundannahmen definieren und Context abstecken
        Grundannahme: Speicher und Objektiv sind fix mit dem Fotoapparat verbunden und können nicht ausgetauscht werden.

        2. Klassendiagramm erstellen mit allen Klassen(, Interfaces, Beziehungen, etc.)

        3. Klassen programmieren
        */

        public static void Launch()
        {
            System.Console.WriteLine("Hallo");

            Camera temu = new Camera("Temu Schrottkamera 2000X", 2.5, 10, 20, "Temu China Ltd.", 5);
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