using Information_Management_System.model;
using Information_Management_System.Services;
using Microsoft.AspNetCore.Mvc;

namespace Information_Management_System.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService) { _studentService = studentService; }
        [HttpGet] public IActionResult GetAll() => Ok(_studentService.GetAllStudents());
        [HttpGet("{id}")] public IActionResult GetById(int id) => Ok(_studentService.GetStudentById(id));
        [HttpPost] public IActionResult Create(Student student) { _studentService.AddStudent(student); return CreatedAtAction(nameof(GetById), new { id = student.Id }, student); }
        [HttpPut("{id}")] public IActionResult Update(int id, Student student) { if (id != student.Id) return BadRequest(); _studentService.UpdateStudent(student); return NoContent(); }
        [HttpDelete("{id}")] public IActionResult Delete(int id) { _studentService.DeleteStudent(id); return NoContent(); }
    }
}
