using StudentManagement.DbContexts;
using StudentManagement.Models;

namespace StudentManagement.Repositories
{
    public interface IStudentRepository : IBaseRepository<Student>
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
        void AddStudent(int sId, string name, int age, double grade);
        void DeleteStudent(int sId);
        void UpdateStudentById(int id, double grade);
    }

    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        private StudentManagementDbContext _context;

        public StudentRepository(StudentManagementDbContext dbContext) : base(dbContext) {
            _context = dbContext;
        }

        public void AddStudent(int sId, string name, int age, double grade)
        {
            _context.Students.Add(new Student(sId, name, age, grade));
        }

        public void DeleteStudent(int sId)
        {
            var student = _context.Students.Where(x => x.SId == sId).First();
            if(student != null)
            {
                _context.Students.Remove(student);
            }
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.ToList().Where(x => x.SId == id).FirstOrDefault();
        }

        public void UpdateStudentById(int id, double grade)
        {
            var student = _context.Students.Where(x => x.SId == id).First();
            if(student != null)
            {
                student.Grade = grade;
            }
        }
    }
}