namespace FigureSample
{
    // TODO 121 Cirkel med Areal-beregner
    public class Circle
    {
        public Circle(int radius, int x, int y, double thinkness=0.1)
        {
            Radius = radius;
            X = x;
            Y = y;
            Thinkness = thinkness;
        }
        public int Radius { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public double Thinkness { get; set; } 
    }
}