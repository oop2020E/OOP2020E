using System;

namespace KG02_inheritance
{
    class Cirkel : Figur
    {
        public Cirkel() : this(10)
        {

        }
        public Cirkel(Figur figur): base(figur.X,figur.Y)
        {

        }
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

    class Powercircle : Cirkel
    {
        public Powercircle() 
        {

        }
    }
}
