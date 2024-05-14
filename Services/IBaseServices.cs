using StudentManagement.Repositories;
using StudentManagement.Services;

namespace StudentManagement.Services
{
    public interface IBaseServices<T> where T : class
    {
        void SaveChangesToDatabase();
    }
}

public class BaseService<T> : IBaseServices<T> where T : class
{
    private IBaseRepository<T> _baserepository;
    public BaseService(IBaseRepository<T> baserepositor)
    {
        _baserepository = baserepositor;
    }

    public void SaveChangesToDatabase()
    {
        _baserepository.SaveChangesToDatabase();
    }
}