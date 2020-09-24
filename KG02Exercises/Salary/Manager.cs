namespace KG02Exercises.Salary
{
    class Manager : Employee
    {
        public decimal ManagerBonus { get; set; }

        public Manager(decimal salary, string name, string jobTitle, decimal managerBonus) : base(salary, name, jobTitle)
        {
            ManagerBonus = managerBonus;
        }

        public override decimal CalculateYearlySalary()
        {
            return base.CalculateYearlySalary() + ManagerBonus;
        }
    }
}