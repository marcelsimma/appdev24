using System;
namespace JulianStroehle.Week5.models
{
    public class Speicherkarte
    {
        int memory;
        int memoryMax;
        public Speicherkarte(int memory, int memoryMax)
        {
            this.memory = memory;
            this.memoryMax = memoryMax;
        }
        public bool CheckMemory()
        {
            return memory < memoryMax;
        }
        public override string ToString()
        {
            return string.Format("Verbleibender Speicherplatz: {0}", memoryMax - memory);
        }
    }
}