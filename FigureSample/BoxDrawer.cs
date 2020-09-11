namespace FigureSample
{
    public class BoxDrawer
    {
        private readonly LineDrawer _lineDrawer;
        public BoxDrawer(ConsoleCanvas c)
        {
            _lineDrawer = new LineDrawer(c);
        }
        public void Draw(Box b)
        {
            _lineDrawer.DrawLine(new Line(b.X,b.Y,b.X+b.Width,b.Y));
            _lineDrawer.DrawLine(new Line(b.X,b.Y,b.X,b.Y+b.Height));
            _lineDrawer.DrawLine(new Line(b.X + b.Width, b.Y + b.Height, b.X, b.Y + b.Height));
            _lineDrawer.DrawLine(new Line(b.X + b.Width, b.Y + b.Height, b.X+b.Width, b.Y ));
        }
    }
}