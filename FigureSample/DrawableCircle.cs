namespace FigureSample
{
    class DrawableCircle  // drawablecircle med ren composition
    {        
        private Circle circle;
        public DrawableCircle(int radius, int x, int y, double thinkness = 0.1)
        {
            this.circle = new Circle(radius, x, y, thinkness);
        }
        public void Draw(Canvas canvas)
        {
            CircleDrawer cd = new CircleDrawer(canvas);
            cd.Draw(circle);
        }
    }
}
