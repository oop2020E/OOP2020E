using System;

namespace KG02_inheritance
{
    class Cirkel : Figur
    {
        public int Radius { get; set; }
        public override int Area()
        {
            return (int)(Math.PI * Radius * Radius);
        }
    }
}
