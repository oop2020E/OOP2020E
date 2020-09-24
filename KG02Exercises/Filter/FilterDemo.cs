using System.Collections.Generic;
using LibOOP;

namespace KG02Exercises.Filter
{
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