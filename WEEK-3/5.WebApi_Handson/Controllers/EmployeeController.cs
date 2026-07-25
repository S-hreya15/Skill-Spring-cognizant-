using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi_Handson.Models;

namespace WebApi_Handson.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin,POC")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new()
        {
            new Employee
            {
                Id=1,
                Name="Rahul",
                Salary=50000,
                Permanent=true,
                DateOfBirth=new DateTime(2000,5,10),
                Department=new Department
                {
                    Id=101,
                    Name="IT"
                },
                Skills=new List<Skill>
                {
                    new Skill{Id=1,Name="C#"},
                    new Skill{Id=2,Name="SQL"}
                }
            }
        };

        [HttpGet]

        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }

        [HttpPost]

        public IActionResult Post([FromBody] Employee employee)
        {
            employees.Add(employee);

            return Ok(employee);
        }
    }
}