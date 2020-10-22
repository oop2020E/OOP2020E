using System.Collections.Generic;

namespace LiveCode
{
    class StudentCatalog
    {
        private List<Student> _students = new List<Student>();
        public void Add(Student p)
        {
            _students.Add(p);
        }

        public List<Student> FindByProgramme(StudyProgramme p)
        {
            List<Student> result = new List<Student>();
            foreach (Student student in _students)
            {
                if (student.Programme == p)
                    result.Add(student);
            }
            return result;
        }
    }
}