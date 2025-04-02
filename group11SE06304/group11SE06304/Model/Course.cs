namespace Information_Management_System.model
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Student> Students { get; set; }
    }
}
