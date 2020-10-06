using System.Web.Http;
using WebApiTest.Abstract;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEmployeeRepository EmployeeRepo;
        public EmployeeController(IEmployeeRepository _EmployeeRepo)
        {
            EmployeeRepo = _EmployeeRepo;
        }
        public IHttpActionResult Get()
        {
            Employee _Employee = EmployeeRepo.GetEmployeeById(5);
            return Ok(_Employee);
        }
    }
}
