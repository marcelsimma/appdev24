using System;

namespace JonasWehinger.A1{

    public class ZooStater{

        public static void ZooStart()
        {
            Zoo zoo = new Zoo ("Zoo: Tiergarten Dornbirn", 2022);

            zoo.AddGehege(new Gehege("Alpenwiese"));
            zoo.AddGehege(new Gehege("Ried"));
            zoo.AddGehege(new Gehege("Lucas"));

            zoo.GehegeStrucktur();

        }
}
}