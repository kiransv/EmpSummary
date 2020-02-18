using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using EmpSummary.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmpSummary.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        IList<Employee> employeeList = new List<Employee>()
        {
            new Employee()
                {
                    EmployeeId = 101, EmployeeName = "Emp1", Location = "Hyderabad", Unit = "Telecom"
                },
                new Employee()
                {
                    EmployeeId = 102, EmployeeName = "Emp2", Location = "US", Unit = "Insurance"
                },
                new Employee()
                {
                    EmployeeId = 103, EmployeeName = "Emp3", Location = "Pune", Unit = "Finance"
                },
                new Employee()
                {
                    EmployeeId = 104, EmployeeName = "Emp4", Location = "Mumbai", Unit = "Sales"
                },
                new Employee()
                {
                    EmployeeId = 105, EmployeeName = "Emp5", Location = "Bengaluru", Unit = "IT"
                },
                new Employee()
                {
                    EmployeeId = 106, EmployeeName = "Emp6", Location = "Delhi", Unit = "Telecom"
                },
                new Employee()
                {
                    EmployeeId = 107, EmployeeName = "Emp7", Location = "Chennai", Unit = "IT"
                },
                new Employee()
                {
                    EmployeeId = 108, EmployeeName = "Emp8", Location = "Mysore", Unit = "Finance"
                },
                new Employee()
                {
                    EmployeeId = 109, EmployeeName = "Emp9", Location = "Hyderabad", Unit = "IT"
                },
                new Employee()
                {
                    EmployeeId = 110, EmployeeName = "Emp10", Location = "Pune", Unit = "HR"
                },
        };

        /// <summary>
        /// Get All Employee List.
        /// </summary>
        /// <returns>List of Employees</returns>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employeeList;
        }
    }
}