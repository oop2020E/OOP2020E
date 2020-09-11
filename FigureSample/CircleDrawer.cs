namespace FigureSample
{
    class DrawableCircle : Circle
    {
        public DrawableCircle(int radius, int x, int y, double thinkness = 0.1) : base(radius, x, y, thinkness)
        {
            
        }


    }

    //TODO 140 
    class CircleDrawer
    {
        private readonly ConsoleCanvas _canvas;
        public CircleDrawer(ConsoleCanvas canvas)
        {
            _canvas = canvas;
        }

        public void Draw(ConsoleCanvas canvas, Circle circle)
        {
            double inner = circle.Radius - circle.Thinkness;
            double outer = circle.Radius + circle.Thinkness;
            for (int x = -circle.Radius * 2; x <= circle.Radius * 2; x++)
            {
                for (int y = -circle.Radius; y <= circle.Radius; y++)
                {
                    double value = (x / 2.0) * (x / 2.0) + y * y;
                    if (value >= inner * inner && value <= outer * outer)
                    {
                        canvas.PutPixel(circle.X + x, circle.Y + y);
                    }
                }
            }

        }
        public void Draw(Circle circle)
        {
            Draw(_canvas,circle);
        }
    }

    //TODOEXTRA 40 Create list of circles -- circlecollection?
}
