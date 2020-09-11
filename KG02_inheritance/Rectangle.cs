namespace KG02_inheritance
{
    class Rectangle : Figur
    {
        public int Area()
        {
            return H * B;
        }
        public int H { get; set; }
        public int B { get; set; }
    }
}
