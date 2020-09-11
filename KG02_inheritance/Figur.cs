namespace KG02_inheritance
{
    public abstract class Figur
    {
        public Figur(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public abstract int Area();
    }
}
