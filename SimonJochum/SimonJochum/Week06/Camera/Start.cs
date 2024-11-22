using System;

namespace SimonJochum.Week06.Camera
{
    public class Start
    {
        public static void StartNow()
        {
            bool check = false;
            Objectiv o1 = new Objectiv("Obj-1234", "Scope", "ABC123", 50, 80);
            SDCard c1 = new SDCard("Samsung", "Pro-8 GB", "SASD8", 5, 4);
            Camera cam1 = new Camera("Sony", "Snapshot", "SONYSNAP1", 50, o1, c1);

            Console.WriteLine(cam1.TakePhoto());
            Console.WriteLine(cam1.CameraWhoTookPhoto());
            c1.GotMegapixelFromCamera(cam1.Megapixel);
            Console.WriteLine(c1.PicturesOnSDCard());
            Console.WriteLine(c1.GetVolume());
            do
            {
                Console.WriteLine(cam1.TakePhoto());
                Console.WriteLine(cam1.CameraWhoTookPhoto());
                Console.WriteLine(c1.PicturesOnSDCard());
                Console.WriteLine(c1.GetVolume());
                Console.WriteLine("Möchtest du noch ein Foto machen? Ja/Nein");
                string input = Console.ReadLine().ToLower();
                if (input == "ja")
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            while(check);

            Console.WriteLine(c1.PicturesOnSDCard());
            Console.WriteLine(c1.GetVolume());
        }

        public static void PrintInventarliste()
        {
            Objectiv o1 = new Objectiv("Obj-1234", "Scope", "ABC123", 50, 80);
            o1.Inventarnummer = "ObjNr1";
            o1.Anschaffungswert = 1000;
            Objectiv o2 = new Objectiv("Obj-4321", "X-Scope", "ABC123", 40, 100);
            o2.Inventarnummer = "ObjNr2";
            o2.Anschaffungswert = 2500;
            Objectiv o3 = new Objectiv("Obj-2222", "Y-Scope", "ABC123", 90, 300);
            o3.Inventarnummer = "ObjNr3";
            o3.Anschaffungswert = 800;
            Objectiv o4 = new Objectiv("Obj-4444", "Z-Scope", "ABC123", 120, 16);
            o4.Inventarnummer = "ObjNr4";
            o4.Anschaffungswert = 1500;
            SDCard c1 = new SDCard("Samsung", "Pro-8 GB", "SASD8", 5, 4);
            c1.Inventarnummer = "CardNr1";
            c1.Anschaffungswert = 10;
            Camera cam1 = new Camera("Sony", "Snapshot", "SONYSNAP1", 50, o1, c1);
            cam1.Inventarnummer = "CamNr1";
            cam1.Anschaffungswert = 10000;
            Sitzsack sack1 = new Sitzsack("SackNr1", 50);
            Sitzsack sack2 = new Sitzsack("SackNr2", 60);
            Sitzsack sack3 = new Sitzsack("SackNr3", 40);
            Sitzsack sack4 = new Sitzsack("SackNr4", 70);
            Tisch table1 = new Tisch("Tisch1", 120);
            Tisch table2 = new Tisch("Tisch2", 100);
            Tisch table3 = new Tisch("Tisch3", 150);
            Tisch table4 = new Tisch("Tisch4", 175);

            string invNum = "Inventarnummer";
            string price = "Preis";

            IGegenstand[] Inventarliste = {o1, o2, o3, o4, c1, cam1, sack1, sack2, sack3, sack4, table1, table2, table3, table4};

            Console.WriteLine("\n" + string.Format("{0, -10}{1, 16}", invNum, price));
            Console.WriteLine(new string('-',30));
            int amountpieces = 0;
            int completePrice = 0;
            foreach (IGegenstand gegenstand in Inventarliste)
            {
                Console.WriteLine(string.Format("{0, -10}{1,20}",gegenstand.PrintInventarnummer(), gegenstand.PrintAnschaffungswert()));
                amountpieces++;
                completePrice += gegenstand.Anschaffungswert;
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Anzahl der Inventargegenstände:\t\t   "+ amountpieces + " Stk." +"\nGesamtwert der Inventargegenstände:\t" + completePrice + " EUR");
        }
    }
}




           