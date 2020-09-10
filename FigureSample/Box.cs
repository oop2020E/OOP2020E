namespace FigureSample
{

    //TODO 120 Box med Areal-beregner
    public class Box
    {
        public Box(int x, int y, int width, int height,double thickness=1.0)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Thickness = thickness;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }
        public double Thickness { get; set; }

    }
}