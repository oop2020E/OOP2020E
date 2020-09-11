using System;

namespace KG02_inheritance
{
    class Cirkel : Figur
    {
        public Cirkel(int radius, int xcoord, int y) : base(xcoord,y)
        {
            Radius = radius;
        }
        public int Radius { get; set; }
        public override int Area()
        {
            return (int)(Math.PI * Radius * Radius);
        }
    }
}
