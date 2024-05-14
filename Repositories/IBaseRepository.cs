using Microsoft.EntityFrameworkCore;
using StudentManagement.DbContexts;

namespace StudentManagement.Repositories
{
    public interface IBaseRepository<T>
    {
        int SaveChangesToDatabase();
    }

    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private StudentManagementDbContext _context;

        public BaseRepository(StudentManagementDbContext context)
        {
            _context = context;
        }
        public int SaveChangesToDatabase()
        {
            return _context.SaveChanges();
        }
    }
}
