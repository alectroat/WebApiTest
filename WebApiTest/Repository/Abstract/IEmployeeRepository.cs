using WebApiTest.Models;

namespace WebApiTest.Abstract
{
    public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int Id);
    }
}
