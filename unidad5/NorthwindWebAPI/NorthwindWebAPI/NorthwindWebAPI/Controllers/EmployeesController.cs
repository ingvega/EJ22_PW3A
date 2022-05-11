using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NorthwindWebAPI.Data;
using NorthwindWebAPI.Models;

namespace NorthwindWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly NorthwindContext _context;

        public EmployeesController(NorthwindContext context)
        {
            _context = context;
        }

        // GET: api/Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        // GET: api/
        [HttpGet]
        [Route("ByCompany")]
        public IEnumerable<Object> GetEmployeesByCompany()
        {
            return _context.Employees
                .GroupBy(e => e.CompanyId)
                .Select(e => new {
                    Company = e.Key,
                    Empleados = e.Count()
                });
            
        }

        // GET: api/
        [HttpGet]
        [Route("top5")]
        public IEnumerable<Object> GetTop5()
        {
            return _context.Employees
                .Where(e => e.CompanyId == 1)
                .Join(_context.Movements,
                e => e.EmployeeId,
                m => m.EmployeeId,
                (e, m) => new
                {
                    Empleado = e.FirstName + " " + e.LastName,
                    IdMovimiento = m.MovementId,
                    Anio = m.Date.Year
                })
                .Where(em=>em.Anio==1996)
                .Join(_context.Movementdetails,
                em => em.IdMovimiento,
                md => md.MovementId,
                (em, md) => new
                {
                    Empleado = em.Empleado,
                    Cantidad = md.Quantity
                })
                .GroupBy(e=> e.Empleado)
                .Select(e=> new { 
                    Empleado = e.Key,
                    Ventas = e.Sum(g=>g.Cantidad)
                });

        }




        // GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);

            if (employee == null)
            {
                return NotFound();
            }

            return employee;
        }

        // PUT: api/Employees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return BadRequest();
            }

            _context.Entry(employee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Employees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployee", new { id = employee.EmployeeId }, employee);
        }

        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeId == id);
        }
    }
}
