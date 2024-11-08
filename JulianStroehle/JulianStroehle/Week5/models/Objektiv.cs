using System;
namespace JulianStroehle.Week5.models
{
    public class Objektiv
    {
        int width;
        int zoom;
        public Objektiv(int width, int zoom)
        {
            this.width = width;
            this.zoom = zoom;
        }
        public override string ToString()
        {
            return string.Format("Objektiv mit {0} fachem Zoom.", zoom);
        }
    }
}