using Microsoft.AspNetCore.Mvc;
using WebApi_Handson.Filters;
using WebApi_Handson.Models;

namespace WebApi_Handson.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ServiceFilter(typeof(CustomAuthFilter))]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    Id=1,
                    Name="Rahul",
                    Salary=50000,
                    Permanent=true,
                    DateOfBirth=new DateTime(2000,5,15),
                    Department=new Department()
                    {
                        Id=101,
                        Name="IT"
                    },
                    Skills=new List<Skill>()
                    {
                        new Skill(){Id=1,Name="C#"},
                        new Skill(){Id=2,Name="SQL"}
                    }
                }
            };
        }

        [HttpGet]

        [ProducesResponseType(StatusCodes.Status200OK)]

        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public ActionResult<List<Employee>> Get()
        {
            return Ok(GetStandardEmployeeList());
        }

        [HttpPost]

        public IActionResult Post([FromBody] Employee employee)
        {
            return Ok(employee);
        }

        [HttpPut]

        public IActionResult Put([FromBody] Employee employee)
        {
            return Ok(employee);
        }
    }
}