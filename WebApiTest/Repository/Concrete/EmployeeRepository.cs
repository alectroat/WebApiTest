using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiTest.Abstract;
using WebApiTest.Models;

namespace WebApiTest.Concrete
{
    public class EmployeeRepository : IEmployeeRepository
    {
        Employee IEmployeeRepository.GetEmployeeById(int Id)
        {
            return new Employee()
            {
                ID = Id,
                Name = "Pranaya",
                Department = "IT",
                Salary = 10000
            };
        }
    }
}