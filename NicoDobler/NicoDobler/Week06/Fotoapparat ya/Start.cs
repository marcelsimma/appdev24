using System; 
namespace NicoDobler.Week06
{
    public class Start{
 
        public static void SelfStart(){
 
            Fotoapparat kamera1 = new Fotoapparat(20, 60, "ABC123", "Canon", 24);
            Fotoapparat kamera2 = new Fotoapparat(24, 70, "Alpha 7R IV", "Sony", 61);
 
            kamera1.TakePhoto();
            Console.WriteLine(kamera1.FotoapparatDetails());
            System.Console.WriteLine("---------------");
 
           
            kamera2.Model = "Alpha 7C";
            kamera2.Megapixel = 33;
 
            kamera2.TakePhoto();
            Console.WriteLine(kamera2.FotoapparatDetails());
            System.Console.WriteLine("---------------");
 
        }
    }
 
 
}