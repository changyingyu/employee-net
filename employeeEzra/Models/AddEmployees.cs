using System;
using System.Collections.Generic;

namespace employeeEzra.Models
{
    public class AddEmployees
    {
        List<Employees> employees = new List<Employees>();
        public AddEmployees()
        {
            employees.Add(new Employees { Id = "1", Name = "John Smith", Email = "john.smith@ezra.com", Phone = "416-999-9999" });
            employees.Add(new Employees { Id = "2", Name = "Jane Doe", Email = "jane.doe@ezra.com", Phone = "905-111-1111" });
            employees.Add(new Employees { Id = "3", Name = "John Doe", Email = "john.doe@ezra.com", Phone = "416-555-5555" });

          
        }
    }
}
