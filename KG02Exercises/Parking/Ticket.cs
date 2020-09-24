namespace KG02Exercises.Parking
{
    class Ticket
    {
        public Ticket(decimal price, int minutes)
        {
            Price = price;
            Minutes = minutes;
        }
        public decimal Price { get; set; }
        public int Minutes { get; set; }
    }
}