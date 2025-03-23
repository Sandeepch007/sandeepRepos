using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Curdoperationwithangular.Models;

namespace Curdoperationwithangular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly Appdbcontext _context;

        public EmployeesController(Appdbcontext context)
        {
            _context = context;
        }

        // GET: api/Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> Getemployee()
        {
            return await _context.employee.ToListAsync();
        }

        // GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            var employee = await _context.employee.FindAsync(id);

            if (employee == null)
            {
                return NotFound();
            }

            return employee;
        }

        // PUT: api/Employees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, [FromBody] Employee emp)
        {
            if (emp == null)
            {
                return BadRequest("Request body is null.");
            }

            if (id != emp.Empid)
            {
                return BadRequest($"Route ID ({id}) does not match employee ID ({emp.Empid}).");
            }

            var emp1 = await _context.employee.FindAsync(id);

            if (emp1 == null)
            {
                return NotFound("Employee not found.");
            }

            emp1.Empname = emp.Empname;
            emp1.Empmobile = emp.Empmobile;
            emp1.Empsalary = emp.Empsalary;
            emp1.Empemail = emp.Empemail;

            await _context.SaveChangesAsync();

            return Ok("Employee updated successfully.");
        }




        // POST: api/Employees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        {
            _context.employee.Add(employee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployee", new { id = employee.Empid }, employee);
        }

        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employee = await _context.employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            _context.employee.Remove(employee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        
    }
}
