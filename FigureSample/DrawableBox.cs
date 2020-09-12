namespace FigureSample
{
    class DrawableBox : Box // Drawablebox med nedarvning
    {
        public DrawableBox(int x, int y, int width, int height, double thickness = 1) : base(x, y, width, height, thickness)
        {
        }

        public void Draw(Canvas c)
        {
            BoxDrawer bd = new BoxDrawer(c);
            bd.Draw(this);
        }
    }
}