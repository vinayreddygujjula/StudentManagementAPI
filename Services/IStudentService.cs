using StudentManagement.Models;
using StudentManagement.Repositories;

namespace StudentManagement.Services
{
    public interface IStudentService : IBaseServices<Student>
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
        void AddStudent(int sId, string name, int age, double grade);
        void DeleteStudent(int sId);
        void UpdateStudentById(int id, double grade);
    }

    public class StudentService : BaseService<Student>, IStudentService {

        private IStudentRepository _repo;

        public StudentService(IStudentRepository repo) : base(repo)
        {
            _repo = repo;
        }

        public void AddStudent(int sId, string name, int age, double grade)
        {
            _repo.AddStudent(sId, name, age, grade);
            _repo.SaveChangesToDatabase();
        }

        public void DeleteStudent(int sId)
        {
            _repo.DeleteStudent(sId);
            _repo.SaveChangesToDatabase();
        }

        public List<Student> GetAllStudents()
        {
            return _repo.GetAllStudents();
        }

        public Student GetStudentById(int id)
        {
            return _repo.GetStudentById(id);
        }

        public void UpdateStudentById(int id, double grade)
        {
            _repo.UpdateStudentById(id, grade);
            _repo.SaveChangesToDatabase();
        }
    }
}
