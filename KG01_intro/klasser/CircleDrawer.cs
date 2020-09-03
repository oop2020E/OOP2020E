namespace KG01_intro.klasser
{
    class CircleDrawer
    {
        public int Width { get; set; }
        public int Height { get; set; }
        private Canvas _canvas;
        public CircleDrawer(Canvas canvas)
        {
            _canvas = canvas;
        }
        public void Draw(Circle c)
        {
            double Inner = c.Radius - c.Thinkness;
            double Outer = c.Radius + c.Thinkness;
            for (int x = -c.Radius * 2; x <= c.Radius * 2; x++)
            {
                for (int y = -c.Radius; y <= c.Radius; y++)
                {
                    double value = (x / 2.0) * (x / 2.0) + y * y;
                    if (value >= Inner * Inner && value <= Outer * Outer)
                    {
                        _canvas.Putpixel(c.X + x, c.Y + y);
                    }
                }
            }
        }
    }

    //TODOEXTRA 40 Create list of circles -- circlecollection?



}
