using System;

namespace KG02_inheritance
{
    class Cirkel : Figur
    {
        public Cirkel(int radius, int x, int y)
        {
            Radius = radius;
            X = x;
            Y = y;
        }
        public int Radius { get; set; }
        public override int Area()
        {
            return (int)(Math.PI * Radius * Radius);
        }
    }
}
