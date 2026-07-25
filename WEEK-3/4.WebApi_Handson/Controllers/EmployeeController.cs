using Microsoft.AspNetCore.Mvc;
using WebApi_Handson.Models;

namespace WebApi_Handson.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>()
        {
            new Employee
            {
                Id = 1,
                Name = "Rahul",
                Salary = 50000,
                Permanent = true,
                DateOfBirth = new DateTime(2000,5,10),
                Department = new Department
                {
                    Id = 101,
                    Name = "IT"
                },
                Skills = new List<Skill>
                {
                    new Skill{Id=1,Name="C#"},
                    new Skill{Id=2,Name="SQL"}
                }
            },

            new Employee
            {
                Id = 2,
                Name = "Shreya",
                Salary = 60000,
                Permanent = true,
                DateOfBirth = new DateTime(2002,8,20),
                Department = new Department
                {
                    Id = 102,
                    Name = "Development"
                },
                Skills = new List<Skill>
                {
                    new Skill{Id=3,Name="ASP.NET"},
                    new Skill{Id=4,Name="Java"}
                }
            }
        };

        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }

        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee employee)
        {
            employees.Add(employee);

            return Ok(employee);
        }

        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee employee)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            var existingEmployee = employees.FirstOrDefault(e => e.Id == id);

            if (existingEmployee == null)
            {
                return BadRequest("Invalid employee id");
            }

            existingEmployee.Name = employee.Name;
            existingEmployee.Salary = employee.Salary;
            existingEmployee.Permanent = employee.Permanent;
            existingEmployee.DateOfBirth = employee.DateOfBirth;
            existingEmployee.Department = employee.Department;
            existingEmployee.Skills = employee.Skills;

            return Ok(existingEmployee);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
            {
                return BadRequest("Invalid employee id");
            }

            employees.Remove(employee);

            return Ok("Employee Deleted Successfully");
        }
    }
}