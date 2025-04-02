using Information_Management_System.model;
using Information_Management_System.Repositories;

namespace Information_Management_System.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository) { _studentRepository = studentRepository; }
        public IEnumerable<Student> GetAllStudents() => _studentRepository.GetAllStudents();
        public Student GetStudentById(int id) => _studentRepository.GetStudentById(id);
        public void AddStudent(Student student) => _studentRepository.AddStudent(student);

        public void UpdateStudent(Student student) => _studentRepository.UpdateStudent(student);
        public void DeleteStudent(int id) => _studentRepository.DeleteStudent(id);
    }
}
