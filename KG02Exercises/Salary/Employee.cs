using System;

namespace KG02Exercises.Salary
{
    class Employee
    {
        private int _seniorityLevel;

        public Employee(decimal salary, string name, string jobTitle)
        {
            MonthlySalary = salary;
            Name = name;
            JobTitle = jobTitle;
        }
        public decimal MonthlySalary { get; set; } // Monthly or CalculateYearlySalary wouldnt make sense
        public string Name { get; set; }
        public string JobTitle { get; set; }

        public int SeniorityLevel
        {
            get { return _seniorityLevel; }
            set
            {
                if (value < 1 || value > 10)
                    throw new ArgumentOutOfRangeException("SeniorityLevel must be in [1..10]");
                _seniorityLevel = value;
            }
        }

        public virtual decimal CalculateYearlySalary()
        {
            return MonthlySalary * 12 + SeniorityBonus;
        }

        public decimal SeniorityBonus
        {
            get { return SeniorityLevel * 10m; }
        }
    }
}