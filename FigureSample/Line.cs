using System;

namespace FigureSample
{
    public class Line
    {
        public Line(int x1, int y1, int x2, int y2, double thickness=1.0)
        {
            X = x1;
            Y = y1;
            XEnd = x2;
            YEnd = y2;
            Thickness = thickness;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int XEnd { get; set; }
        public int YEnd { get; set; }
        public double Thickness { get; set; }
    }
}