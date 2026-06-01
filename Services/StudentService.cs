using StudentAPI.Models;

namespace StudentAPI.Services
{
    public class StudentService : IStudentService
    {
        private static readonly List<Student> _students = new List<Student>
        {
            new Student {Id = 1, Name = "John", Age = 20},
            new Student {Id = 2, Name = "Jane", Age = 22}
        };

        public Student Add(Student student)
        {
            var nextId = _students.Max(s => s.Id) + 1;
            student.Id = nextId;
            _students.Add(student);
            return student;
        }

        public List<Student> GetAll()
        {
            return _students;
        }

        public Student GetById(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id)!;
        }
    }
}
