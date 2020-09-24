
namespace KG02Exercises.Filter
{
    class EmployeeFilter : PersonFilter
    {
        public override bool Match(Person person)
        {
            return person is Employee;
        }
    }
}