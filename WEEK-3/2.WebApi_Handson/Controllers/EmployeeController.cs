using Microsoft.AspNetCore.Mvc;

namespace WebApi_Handson.Controllers
{
    [ApiController]
    [Route("api/Emp")]
    public class EmployeeController : ControllerBase
    {
        private static List<string> employees = new List<string>
        {
            "Rahul",
            "Priya",
            "Amit",
            "Shreya"
        };

        // GET api/Emp
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<string>> GetEmployees()
        {
            return Ok(employees);
        }

        // GET api/Emp/1
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<string> GetEmployee(int id)
        {
            if (id < 0 || id >= employees.Count)
                return BadRequest("Invalid Employee Id");

            return Ok(employees[id]);
        }

        // POST api/Emp
        [HttpPost]
        public IActionResult AddEmployee([FromBody] string employee)
        {
            employees.Add(employee);
            return Ok("Employee Added Successfully");
        }

        // PUT api/Emp/1
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody] string employee)
        {
            if (id < 0 || id >= employees.Count)
                return BadRequest("Invalid Employee Id");

            employees[id] = employee;

            return Ok("Employee Updated Successfully");
        }

        // DELETE api/Emp/1
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            if (id < 0 || id >= employees.Count)
                return BadRequest("Invalid Employee Id");

            employees.RemoveAt(id);

            return Ok("Employee Deleted Successfully");
        }
    }
}