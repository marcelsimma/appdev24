using System.Runtime.CompilerServices;

namespace FatmanurKeles.Week06.ZOO
{
    public class Gehege
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public Gehege(string name)
        {
            _name = Name;
        }

        public override string ToString()
        {
            return 
            String.Format("Gehege:" + _name);
        }
    } 
}