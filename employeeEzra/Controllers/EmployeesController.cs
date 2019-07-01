using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using employeeEzra.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.Cors;

namespace employeeEzra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public List<Employees> Get()
        {
            return employeeEzra.Startup.employees;
        }

        // POST api/employees
        [HttpPost]
        public OkObjectResult Post(string id, string name, string email, string phone)
        {
            employeeEzra.Startup.employees.Add(new Employees { Id = id, Name = name, Email = email, Phone = phone });
            return Ok(employeeEzra.Startup.employees);

        }
        // PUT api/employees/
        //[HttpPut("{id}")]
        [HttpPut("{id}")]
        public OkObjectResult Put(string id, string name, string phone)
        {

            Employees findEmployee =  this.FindEmplyeeFromId(id);
            findEmployee.Name = name;
            findEmployee.Phone = phone;
            return Ok(employeeEzra.Startup.employees);  
        }

        private Employees FindEmplyeeFromId(string id)
        {
            return employeeEzra.Startup.employees.Find(x => x.Id == id);
        }

        // DELETE api/employees/5
        [HttpDelete("{id}")]
        public OkObjectResult Delete(string id)
        {
            employeeEzra.Startup.employees.Remove(this.FindEmplyeeFromId(id));
            return Ok(employeeEzra.Startup.employees);
        }
    }
}
