using System.Collections.Generic;

namespace KG02Exercises.Filter
{
    abstract class PersonFilter
    {
        public abstract bool Match(Person person);
        public virtual List<Person> Filter(List<Person> people)
        {
            List<Person> result = new List<Person>();
            foreach (Person person in people)
            {
                if (Match(person))
                    result.Add(person);
            }
            return result;
        }
    }
}
