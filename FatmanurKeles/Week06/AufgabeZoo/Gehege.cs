using System.Runtime.CompilerServices;

namespace FatmanurKeles.Week06.ZOO
{
    public class Gehege
    {
        public string Gehegename {get; set;}

        public Gehege(string gehegename)
        {
            Gehegename = gehegename;
        }

        public override string ToString()
        {
            return 
            String.Format("Gehege:" + Gehegename);
        }



        List<Gehege> gehegen = new List<Gehege>();

        public void AddGehege(Gehege gehege)
        {
            gehegen.Add(gehege);
        }
        
        public void DeleteGehege(Gehege gehege)
        {
            gehegen.Remove(gehege);
        }
        
    } 
}