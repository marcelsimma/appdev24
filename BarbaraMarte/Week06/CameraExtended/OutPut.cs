namespace BarbaraMarte.Week06.CameraExtended;

public class OutPut
{
    public static void Print()
    {
        MemoryCard memoryCard = new MemoryCard("SMemoryCard505", "Samsung", 500, "KSDJ4512", 200);
        Objective objective = new Objective(200, 100, "Super god Lens 5000", "Canon", "SgL5000", 4999.99);
        Camera camera = new Camera("Philips XD 1200", 1200, "Philips", memoryCard, objective, "ADE7420", 500);

        Console.WriteLine(camera.ToString());
    }
}