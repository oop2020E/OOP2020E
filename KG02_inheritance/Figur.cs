namespace KG02_inheritance
{
    public abstract class Figur
    {

        public override sealed string ToString()
        {
            
        }
        public virtual string Name()
        {
            return "figur";
        }

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
