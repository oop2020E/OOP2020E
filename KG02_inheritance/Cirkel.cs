using System;

namespace KG02_inheritance
{
    class Cirkel : Figur
    {
        public Cirkel(int radius) : base(0, 0)
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
