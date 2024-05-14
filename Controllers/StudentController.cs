using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using StudentManagement.Services;

namespace StudentManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {
        private IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public List<Student> Index()
        {
            return _studentService.GetAllStudents();
        }

        [HttpGet("GetStudentById")]
        public Student GetStudentById(int sId)
        {
            return _studentService.GetStudentById(sId);
        }

        [HttpPost("AddStudent")]
        public void AddStudent(int sId, string name, int age, double grade)
        {
            _studentService.AddStudent(sId, name, age, grade);
        }

        [HttpDelete("DeleteStudent")]
        public void DeleteStudent(int sId)
        {
            _studentService.DeleteStudent(sId);
        }

        [HttpPut("UpdateStudent")]
        public void UpdateStudent(int sId, double grade)
        {
            _studentService.UpdateStudentById(sId, grade);
        }
    }
}