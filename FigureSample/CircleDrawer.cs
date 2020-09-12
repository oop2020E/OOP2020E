namespace FigureSample
{

    class CircleDrawer
    {
        private readonly Canvas _canvas;
        public CircleDrawer(Canvas canvas)
        {
            _canvas = canvas;
        }

        public void Draw(Canvas canvas, Circle circle)
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
}
