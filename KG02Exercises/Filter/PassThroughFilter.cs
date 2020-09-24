using System.Collections.Generic;

namespace KG02Exercises.Filter
{
    abstract class PassThroughFilter : PersonFilter
    {
        public sealed override List<Person> Filter(List<Person> people)
        {
            foreach (Person person in people)
            {
                Match(person);
            }
            return people;
        }
    }
}