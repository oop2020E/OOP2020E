using System.Collections.Generic;
using LibOOP;

namespace KG02Exercises.Filter
{
    class Person
    {
        public Person(string navn)
        {
            Navn = navn;
        }
        public string Navn { get; set; }
    }

    class Employee : Person
    {
        public string Title { get; set; }
        public Employee(string navn) : base(navn)
        {
        }
    }
    public class FilterDemo : IExerciseSolution
    {
        public void Run()
        {
            List<Person> plist = new List<Person>();
            plist.Add(new Employee("Thomas"));
            plist.Add(new Person("Erik"));
            plist.Add(new Person("Bo"));
            plist.Add(new Employee("Hans"));
            plist.Add(new Employee("Kurt"));
            PersonFilter pfilter = new VerySimpleThomasFilter();
            List<Person> filteredList = pfilter.Filter(plist);
        }
    }
}