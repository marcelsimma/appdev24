using System;
using System.Xml;

namespace SimonJochum.Week05
{
    public class ExerciseOOP
    {
        public static void Start()
        {
            
            // Exercise(); 
            // ExerciseMotorcycle(); 
            // ExerciseCamera(); 
            // ExerciseCameraAdvanced(); 
            ExerciseCameraMoreAdvanced(); 
        }

        public static void Exercise()
        {
            // Erstellt Personen-, Auto- und Bank-Objekte und gibt deren Eigenschaften aus
            Person paul = new Person("Paul", 28, 190, 85, 20000.05);
            Person nina = new Person("Nina", 19, 165, 57, 800.0);
            Car viper = new Car("Dodge", "Viper", 650, 100000, 12345);
            Car polo = new Car("Volkswagen", "Polo", 60, 20000, 123456);
            Bank raiba = new Bank("Kleinkredit", 30000.00, 1000.00, 24);
            Bank sparkasse = new Bank("Kleinkredit", 25000.00, 500.00, 24);

            // Gibt die Details der Personen und Autos sowie ihre spezifischen Methoden aus
            Console.WriteLine(paul);
            Console.WriteLine(nina);
            Console.WriteLine(nina.HasABirthday(19)); // Ändert das Alter von Nina
            Console.WriteLine(viper);
            Console.WriteLine(viper.Kilometerstand(500)); // Erhöht den Kilometerstand der Viper
            Console.WriteLine(polo);
            Console.WriteLine(raiba);
            Console.WriteLine(sparkasse);
        }

        public static void ExerciseMotorcycle()
        {
            // Erstellt zwei Motorräder und demonstriert deren Funktionalitäten
            Motorcycle Motorrad1 = new Motorcycle("Motorrad1", 1000);
            Console.WriteLine(Motorrad1.ToString());
            Motorrad1.Faehrt(); // Startet das Motorrad
            Motorrad1.Fahre(100); // Fährt 100 km
            Console.WriteLine(Motorrad1.ToString());
            Motorrad1.Stop(); // Stoppt das Motorrad
            Console.WriteLine(Motorrad1.ToString());

            Console.WriteLine(new string('-', 24));

            Motorcycle Motorrad2 = new Motorcycle("Motorrad2", 10000);
            Console.WriteLine(Motorrad2.ToString());
            Motorrad2.Faehrt();
            Motorrad2.Fahre(79);
            Console.WriteLine(Motorrad2.ToString());
            Motorrad2.Stop();
            Console.WriteLine(Motorrad2.ToString());

            Motorrad2.Faehrt();
            Motorrad2.Fahre(1079);
            Console.WriteLine(Motorrad2.ToString());
            Motorrad2.Stop();
            Console.WriteLine(Motorrad2.ToString());
        }

        public static void ExerciseCamera()
        {
            // Erstellt eine Kamera und demonstriert verschiedene Kamera-Eigenschaften und Aktionen
            Camera camera1 = new Camera("Canon", "MX1000", 50, 500, 50.0);
            Console.WriteLine(camera1.ToString());

            // Ändert die Megapixel-Einstellung und simuliert das Aufnehmen eines Fotos
            camera1.Megapixel = 100.5;
            Console.WriteLine(camera1.takePhoto());
            Console.WriteLine(camera1.CameraWhoTookPhoto());

            Console.WriteLine(new string('-', 24));

            // Ändert Kameramarke, Modell und Brennweite und gibt die Details erneut aus
            camera1.Brand = "Nikon";
            camera1.Model = "ZRY-955";
            camera1.BrennweiteMin = 100;
            camera1.BrennweiteMax = 1000;
            Console.WriteLine(camera1.CameraWhoTookPhoto());
            Console.WriteLine(camera1.ToString());

            // Ändert nochmals die Kameramarke und Modell
            camera1.Brand = "Sony";
            camera1.Model = "Snapshot";
            camera1.BrennweiteMin = 100;
            camera1.BrennweiteMax = 1000;
            Console.WriteLine(camera1.ToString());
        }

        public static void ExerciseCameraAdvanced()
        {
            // Erstellt eine Kamera mit einem Objektiv und einer Speicherkarte
            Camera camera = new Camera("Canon", "Y-1000", 10);
            Objektiv objektiv = new Objektiv("Obj-1234", 70);
            Speicherkarte karte = new Speicherkarte("Samsung", 32, 4);

            // Gibt Kamera-, Objektiv- und Speicherkarteneigenschaften aus
            Console.WriteLine(camera.ToString() + objektiv.ToString() + karte.ToString());

            // Simuliert das Aufnehmen eines Fotos, das Speicherplatz verbraucht
            Console.WriteLine(camera.takePhoto());
            karte.SpeicherVolumenVerbraucht += 1; // Simuliert Speicherverbrauch
            Console.WriteLine(camera.CameraWhoTookPhoto());
            Console.WriteLine(camera.ToString() + objektiv.ToString() + karte.ToString());
            Console.WriteLine(new string('-', 30));

            // Ändert Kamera- und Objektiveigenschaften und gibt die aktualisierten Details aus
            camera.Brand = "Leica";
            camera.Model = "Zoom3000";
            camera.Megapixel = 100;
            objektiv.Name = "Obj-4321";
            objektiv.Brennweite = 120;
            karte.Name = "San Disk";
            karte.SpeicherVolumenInsgesamt = 64;
            karte.SpeicherVolumenVerbraucht = 0;

            Console.WriteLine(camera.ToString() + objektiv.ToString() + karte.ToString());
            // Simuliert das Aufnehmen eines größeren Fotos, das mehr Speicherplatz benötigt
            Console.WriteLine(camera.takeBiggerPhoto());
            karte.SpeicherVolumenVerbraucht += 2; // Erhöhter Speicherverbrauch
            Console.WriteLine(camera.CameraWhoTookPhoto());
            Console.WriteLine(camera.ToString() + objektiv.ToString() + karte.ToString());
            Console.WriteLine(new string('-', 30));
        }

        public static void ExerciseCameraMoreAdvanced()
        {
            // Erste Kamera-Instanz
            Camera kamera = new Camera("Sony", "Cybershot", 50.0);

            // Übergabe der Megapixel von der Kamera an die Speicherkarte
            kamera.Karte.UebergabeAusCamera(kamera.Megapixel);

            Console.WriteLine($"Kamera: {kamera.Brand} {kamera.Model}, Objektiv: {kamera.Objektiv.Name} Brennweite: {kamera.Objektiv.Brennweite}mm, Speicherkarte: {kamera.Karte.Name}, Speicherplatz: {kamera.Karte.SpeicherVolumenVerbraucht}/{kamera.Karte.SpeicherVolumenInsgesamt}MB verbraucht");
            Console.WriteLine("Auf der Speicherkarte von " + kamera.Karte.Name + " sind " + (int)kamera.Karte.BilderAufSpeicherkarte() + " Bild(er) gespeichert.");

            Console.WriteLine(kamera.takePhoto());
            Console.WriteLine(kamera.CameraWhoTookPhoto());

            // Übergabe der Megapixel erneut, falls Speicherplatz oder andere Eigenschaften verändert wurden
            kamera.Karte.UebergabeAusCamera(kamera.Megapixel);

            Console.WriteLine("Auf der Speicherkarte von " + kamera.Karte.Name + " sind " + (int)kamera.Karte.BilderAufSpeicherkarte() + " Bild(er) gespeichert.");
            Console.WriteLine($"Kamera: {kamera.Brand} {kamera.Model}, Objektiv: {kamera.Objektiv.Name} Brennweite: {kamera.Objektiv.Brennweite}mm, Speicherkarte: {kamera.Karte.Name}, Speicherplatz: {kamera.Karte.SpeicherVolumenVerbraucht}/{kamera.Karte.SpeicherVolumenInsgesamt}MB verbraucht" + "\n" + new string('-', 30));

            // Zweite Kamera-Instanz
            kamera = new Camera("Leica", "Zoom", 100.0);

            // Neues Objektiv und Speicherkarte zuweisen
            kamera.Objektiv = new Objektiv("Obj-4321", 90);
            kamera.Karte = new Speicherkarte("San Disk", 64, 0);

            // Übergabe der Megapixel an die neue Speicherkarte
            kamera.Karte.UebergabeAusCamera(kamera.Megapixel);

            Console.WriteLine(kamera.takePhoto());
            Console.WriteLine(kamera.CameraWhoTookPhoto());

            // Übergabe der Megapixel erneut, falls Speicherplatz oder andere Eigenschaften verändert wurden
            kamera.Karte.UebergabeAusCamera(kamera.Megapixel);

            Console.WriteLine("Auf der Speicherkarte von " + kamera.Karte.Name + " sind " + (int)kamera.Karte.BilderAufSpeicherkarte() + " Bild(er) gespeichert.");
            Console.WriteLine($"Kamera: {kamera.Brand} {kamera.Model}, Objektiv: {kamera.Objektiv.Name} Brennweite: {kamera.Objektiv.Brennweite}mm, Speicherkarte: {kamera.Karte.Name}, Speicherplatz: {kamera.Karte.SpeicherVolumenVerbraucht}/{kamera.Karte.SpeicherVolumenInsgesamt}MB verbraucht");
            Console.WriteLine(kamera.takePhoto());
            Console.WriteLine(kamera.takePhoto());
            Console.WriteLine(kamera.takePhoto());
            Console.WriteLine(kamera.takePhoto());
            kamera.Objektiv = new Objektiv("Obj-4444", 40);
            Console.WriteLine("Auf der Speicherkarte von " + kamera.Karte.Name + " sind " + (int)kamera.Karte.BilderAufSpeicherkarte() + " Bild(er) gespeichert.");
            Console.WriteLine($"Kamera: {kamera.Brand} {kamera.Model}, Objektiv: {kamera.Objektiv.Name} Brennweite: {kamera.Objektiv.Brennweite}mm, Speicherkarte: {kamera.Karte.Name}, Speicherplatz: {kamera.Karte.SpeicherVolumenVerbraucht}/{kamera.Karte.SpeicherVolumenInsgesamt}MB verbraucht" + "\n" + new string('-', 30));
            Console.WriteLine(kamera.takePhoto());
            Console.WriteLine(kamera.takePhoto());
            Console.WriteLine("Auf der Speicherkarte von " + kamera.Karte.Name + " sind " + (int)kamera.Karte.BilderAufSpeicherkarte() + " Bild(er) gespeichert.");
            Console.WriteLine($"Kamera: {kamera.Brand} {kamera.Model}, Objektiv: {kamera.Objektiv.Name} Brennweite: {kamera.Objektiv.Brennweite}mm, Speicherkarte: {kamera.Karte.Name}, Speicherplatz: {kamera.Karte.SpeicherVolumenVerbraucht}/{kamera.Karte.SpeicherVolumenInsgesamt}MB verbraucht" + "\n" + new string('-', 30));
        }
    }
}