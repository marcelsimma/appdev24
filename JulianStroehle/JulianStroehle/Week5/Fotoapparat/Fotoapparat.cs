using System;
namespace JulianStroehle.Week5.Fotoapparat
{
    public class Fotoapparat : Hardware, IInv
    {
        public string InvNr { get; set; }
        public double Price { get; set; }
        public double Megapixel
        {
            get;
        }
        public string Model
        {
            get => base.Model;
        }
        Objektiv _objektiv;
        public Fotoapparat(string model, string producer, double megapixel, Speicherkarte speicherkarte, Objektiv objektiv, string invNr, double price)
        {
            base.Model = model;
            Producer = producer;
            _objektiv = objektiv;
            Megapixel = megapixel;
            InvNr = invNr;
            Price = price;
        }
        public void GetInvNr()
        {
            Console.WriteLine(string.Format("{0,-15}", InvNr) +"│" + string.Format("{0,10}", Price) + "€");
        }
        public void takePhoto()
        {
            if (_objektiv._zoom < 3)
            {
            Console.Write(@"
               O
              /|\
              / \
");
            }
            else if (_objektiv._zoom > 2 && _objektiv._zoom < 5)
            {
                Console.WriteLine(@"
     ▄████████████▄
   ▄▄█░░░░░░░░░░░░█▄
   █░░░░█████████░░█▄
 ██░░░░░░░░░░░░░░░░░██
██░░█████████████░░░░██
█░░░░░░░░░░░░░░░░█░░░░█
█░░░████░█████░░░░░░░░█
█░░████████████░░░░░░░█
█░░█─██─█─██──██░░░░░░█
▀▄░█─▀▀─█─▀▀──█░░░░░▄█▀
 ▀██▄▄▄▄█▄────█░░▄▄█▀
 ▄█░░░░░░█▄▄▄▄▀░░█
▄█░░░░░░█▀░░░░░░░▀▀█▄
█░░░░░░█▌░▄██████▄░░█
█░░░░░░░███████████░█
█░░░░░░░██░░█░░░██░░█
▀█░░░░░██░░░░░░██░░█
 ▀▀▀▀▀█░████████░░█
      ▀▄░░░░░░░░░█
");
//             Console.Write(@"
//              ┌─┐
//              │ │
//             _│_│_
//             (°¿°)
//              /|\
//             / | \
//            /  |  \
//              / \
//             /   \
//            /     \
// "); 
            }
            else
            {
                Console.Write(@"
⠄⠄⠄⢰⣧⣼⣯⠄⣸⣠⣶⣶⣦⣾⠄⠄⠄⠄⡀⠄⢀⣿⣿⠄⠄⠄⢸⡇⠄⠄
⠄⠄⠄⣾⣿⠿⠿⠶⠿⢿⣿⣿⣿⣿⣦⣤⣄⢀⡅⢠⣾⣛⡉⠄⠄⠄⠸⢀⣿⠄
⠄⠄⢀⡋⣡⣴⣶⣶⡀⠄⠄⠙⢿⣿⣿⣿⣿⣿⣴⣿⣿⣿⢃⣤⣄⣀⣥⣿⣿⠄
⠄⠄⢸⣇⠻⣿⣿⣿⣧⣀⢀⣠⡌⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠿⠿⣿⣿⣿⠄
⠄⢀⢸⣿⣷⣤⣤⣤⣬⣙⣛⢿⣿⣿⣿⣿⣿⣿⡿⣿⣿⡍⠄⠄⢀⣤⣄⠉⠋⣰
⠄⣼⣖⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⣿⣿⣿⣿⣿⢇⣿⣿⡷⠶⠶⢿⣿⣿⠇⢀⣤
⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣽⣿⣿⣿⡇⣿⣿⣿⣿⣿⣿⣷⣶⣥⣴⣿⡗
⢀⠈⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠄
⢸⣿⣦⣌⣛⣻⣿⣿⣧⠙⠛⠛⡭⠅⠒⠦⠭⣭⡻⣿⣿⣿⣿⣿⣿⣿⣿⡿⠃⠄
⠘⣿⣿⣿⣿⣿⣿⣿⣿⡆⠄⠄⠄⠄⠄⠄⠄⠄⠹⠈⢋⣽⣿⣿⣿⣿⣵⣾⠃⠄
⠄⠘⣿⣿⣿⣿⣿⣿⣿⣿⠄⣴⣿⣶⣄⠄⣴⣶⠄⢀⣾⣿⣿⣿⣿⣿⣿⠃⠄⠄
⠄⠄⠈⠻⣿⣿⣿⣿⣿⣿⡄⢻⣿⣿⣿⠄⣿⣿⡀⣾⣿⣿⣿⣿⣛⠛⠁⠄⠄⠄
⠄⠄⠄⠄⠈⠛⢿⣿⣿⣿⠁⠞⢿⣿⣿⡄⢿⣿⡇⣸⣿⣿⠿⠛⠁⠄⠄⠄⠄⠄
⠄⠄⠄⠄⠄⠄⠄⠉⠻⣿⣿⣾⣦⡙⠻⣷⣾⣿⠃⠿⠋⠁⠄⠄⠄⠄⠄⢀⣠⣴
⣿⣿⣿⣶⣶⣮⣥⣒⠲⢮⣝⡿⣿⣿⡆⣿⡿⠃⠄⠄⠄⠄⠄⠄⠄⣠⣴⣿⣿⣿
");
            }
        }
        public override string ToString()
        {
            return string.Format("Hersteller: {0}, Model: {1}, Megapixel: {2}", Producer, base.Model, Megapixel);
        }
    }
}