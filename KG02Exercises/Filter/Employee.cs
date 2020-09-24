namespace KG02Exercises.Filter
{
    class Employee : Person
    {
        public string Title { get; set; }
        public Employee(string navn) : base(navn)
        {
        }
    }
}