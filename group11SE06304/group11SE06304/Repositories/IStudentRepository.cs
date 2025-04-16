using Information_Management_System.model;

namespace Information_Management_System.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int id);
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
    }
}
