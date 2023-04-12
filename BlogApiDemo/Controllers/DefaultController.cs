using BlogApiDemo.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var context = new Context();
            var values = context.employees.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            using var context = new Context();
            context.Add(employee);
            context.SaveChanges();
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            using var context = new Context();
            var employee = context.employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(employee);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            using var context = new Context();
            var employee = context.employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                context.Remove(employee);
                context.SaveChanges();
                return Ok();
            }
        }
        [HttpPut]
        public IActionResult UpdateEmployee(Employee employee)
        {
            using var context = new Context();
            var employeeToBeDeleted = context.Find<Employee>(employee.Id);
            if (employeeToBeDeleted == null)
            {
                return NotFound();
            }
            else
            {
                employeeToBeDeleted.Name = employee.Name;
                context.Update(employeeToBeDeleted);
                context.SaveChanges();
                return Ok();
            }
        }
    }
}
